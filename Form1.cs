using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JsonToClass
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<ClassDescripe> allClass = new List<ClassDescripe>();//存放存在的结构
        private object jonSickObject = null; //json弱类型结构
        private List<ClassDescripe> displayNumClass = new List<ClassDescripe>(); //最后总结出来的类的个数
        private ClassDescripe classDescripe = new ClassDescripe(); //根类
        private static int classID = 1; //类的随机号

     

        /// <summary>
        /// 创建类，以及初始化代码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateClass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.jonText.Text))
            {
                return;
            }
            allClass.Clear();
            displayNumClass.Clear();
            classDescripe = new ClassDescripe();
            this.jonSickObject = fastJSON.JSON.Instance.Parse(this.jonText.Text);
            this.allClass = new List<ClassDescripe>(); //存放存在的结构

            if (jonSickObject is Dictionary<string, object>)
            {
                classDescripe.ClassName = "classRootDic"; 
                ParseDic(jonSickObject as Dictionary<string, object>, classDescripe);
            }
            else if (jonSickObject is List<object>)
            {
                classDescripe.ClassName = "classRootList";
                ParseList(jonSickObject as List<object>, classDescripe);
            }
            //合并相同的结构
            JoinSameStruct();

            //列出出所有的类以及初始化代码
            DisplayNumClass();

        }
        /// <summary>
        /// 列出出所有的类以及初始化代码
        /// </summary>
        public void DisplayNumClass()
        { 

            StringBuilder builder = new StringBuilder(1024);
            foreach (ClassDescripe cd in displayNumClass)
            {
                builder.AppendLine("public class " + cd.ClassName);
                builder.AppendLine("{ ");
                foreach (PropertyDescripe pd in cd.Propertis)
                {
                    if (pd.Class == null)
                    {
                        builder.AppendLine("   public " + pd.MyType.Name + "  " + pd.PropertyName + " {set;get;}");
                    }
                    else
                    {
                        if (pd.IsList == 1)
                        {
                            builder.AppendLine("   public List<" + pd.Class.ClassName + ">  " + pd.PropertyName + " {set;get;}");
                        }
                        else
                        {
                            builder.AppendLine("   public " + pd.Class.ClassName + "  " + pd.PropertyName + " {set;get;}");
                        }
                    }
                }
                builder.AppendLine("   public static " + cd.ClassName + " Create(Dictionary<string, object> dic)");
                builder.AppendLine("   { ");
                builder.AppendLine("        if (dic == null) ");
                builder.AppendLine("            return null; ");
                builder.AppendLine("        " + cd.ClassName + " classResult = new " + cd.ClassName + "();");

                foreach (PropertyDescripe pd in cd.Propertis)
                {
                    if (pd.Class == null)
                    {
                        builder.AppendLine("        if(dic[\"" + pd.PropertyName + "\"]!= null)");
                        builder.AppendLine("        { ");
                        if (pd.MyType == typeof(System.Int32))
                        {
                            builder.AppendLine("            classResult." + pd.PropertyName + " = (int)(long)dic[\"" + pd.PropertyName + "\"];");
                        }
                        else if (pd.MyType == typeof(System.Int64))
                        {
                            builder.AppendLine("            classResult." + pd.PropertyName + " = (long)dic[\"" + pd.PropertyName + "\"];");
                        }
                        else if (pd.MyType == typeof(System.String))
                        {
                            builder.AppendLine("            classResult." + pd.PropertyName + " = (string)dic[\"" + pd.PropertyName + "\"];");
                        }
                        else if (pd.MyType == typeof(System.Boolean))
                        {
                            builder.AppendLine("            classResult." + pd.PropertyName + " = (bool)dic[\"" + pd.PropertyName + "\"];");
                        }
                        else if (pd.MyType == typeof(System.Double))
                        {
                            builder.AppendLine("            classResult." + pd.PropertyName + " = (double)dic[\"" + pd.PropertyName + "\"];");
                        }
                        builder.AppendLine("        } ");
                     
                    }
                    else
                    {
                        if (pd.IsList==1)
                        {
                            builder.AppendLine("        List<object> " + pd.PropertyName.ToLower() + "Obj = dic[\"" + pd.PropertyName + "\"] as List<object>;");
                            builder.AppendLine("        if (" + pd.PropertyName.ToLower() + "Obj != null)");
                            builder.AppendLine("        {");
                            builder.AppendLine("            classResult." + pd.PropertyName + " = new List<" + pd.Class.ClassName + ">();");
                            
                            builder.AppendLine("            " + pd.Class.ClassName + " " + pd.PropertyName.ToLower() + "Item;");
                            builder.AppendLine("            foreach (object obj in " + pd.PropertyName.ToLower() + "Obj)");
                            builder.AppendLine("            {");
                            builder.AppendLine("                " + pd.PropertyName.ToLower() + "Item = " + pd.Class.ClassName + ".Create(obj as Dictionary<string, object>);");
                            builder.AppendLine("                if (" + pd.PropertyName.ToLower() + "Item != null)");
                            builder.AppendLine("                {");
                            builder.AppendLine("                    classResult." + pd.PropertyName + ".Add(" + pd.PropertyName.ToLower() + "Item);");
                            builder.AppendLine("                }");
                            builder.AppendLine("            }");
                            builder.AppendLine("       }");
                        }
                        else
                        {
                            builder.AppendLine("       classResult." + pd.PropertyName + " = " + pd.Class.ClassName + ".Create(dic[\"" + pd.PropertyName + "\"] as Dictionary<string, object>);");
                        }
                    }
                }
                builder.AppendLine("       return classResult;");

                builder.AppendLine("   } ");
                builder.AppendLine("} ");
            }

            classCodeText.Text = builder.ToString();
            
        }
        /// <summary>
        /// 合并相同的结构
        /// </summary>
        public void JoinSameStruct()
        {
            if (this.allClass == null)
                return;
            //看是否相同 不同的guid要合并
            for (int i = 1; i < allClass.Count; i++)
            {
                for (int j = i + 1; j < allClass.Count; j++)
                {
                    if (allClass[i].ClassName == allClass[j].ClassName)
                    {
                        continue;
                    }
                    if (ClassDescripe.IsSame(allClass[i], allClass[j]))
                    {
                        if (allClass[i].ClassName != allClass[j].ClassName)
                        {
                            allClass[j].ClassName = allClass[i].ClassName;
                        }
                    }
                }
            }
            //
            foreach (ClassDescripe cd in this.allClass)
            {
                bool isHas = false;
                foreach (ClassDescripe cd2 in displayNumClass)
                {
                    if (cd2.ClassName == cd.ClassName)
                    {
                        isHas = true;
                        break;
                    }
                }
                if (!isHas)
                {
                    displayNumClass.Add(cd);
                }
            }

        }

        /// <summary>
        /// Dic to Parse
        /// </summary>
        /// <param name="dic"></param>
        /// <param name="classDes"></param>
        public void ParseDic(Dictionary<string, object> dic, ClassDescripe classDes)
        {
            allClass.Add(classDes);
            classDes.Propertis = new List<PropertyDescripe>();
            foreach (string key in dic.Keys)
            {
                PropertyDescripe propertyDescript = new PropertyDescripe();
                propertyDescript.PropertyName = key;


                if (dic[key].GetType() == typeof(System.Int64) && UseInt.Checked)
                {
                    propertyDescript.MyType = typeof(System.Int32);
                }
                else
                {
                    propertyDescript.MyType = dic[key].GetType();
                }
              
                classDes.Propertis.Add(propertyDescript);
             
                if (typeof(Dictionary<string, object>) == propertyDescript.MyType)
                {
                    ClassDescripe classDescripe2 = new ClassDescripe();
                    classDescripe2.ClassName = "Class_" + classID++;
                    propertyDescript.Class = classDescripe2;
                    ParseDic(dic[key] as Dictionary<string, object>, classDescripe2);
                }
                else if(typeof(List<object>)==propertyDescript.MyType)
                {
                    ClassDescripe classDescripe2 = new ClassDescripe();
                    classDescripe2.ClassName = "Class_" + classID++;
                    propertyDescript.Class = classDescripe2;
                    propertyDescript.IsList = 1;
                    ParseList(dic[key] as List<object>, classDescripe2);
                }
  
            }

            //看属性名称是否一致
        }
        
        /// <summary>
        /// List to Parse
        /// </summary>
        /// <param name="list"></param>
        /// <param name="classDes"></param>
        public void ParseList(List<object> list, ClassDescripe classDes)
        {
            object key = list[0];
            if (typeof(Dictionary<string, object>) == key.GetType())
            {
                ParseDic(key as Dictionary<string, object>, classDes);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ReGenerator_Click(object sender, EventArgs e)
        {
            string className1 = classText1.Text;
            string className2 = classText2.Text;
            string className3 = classText3.Text;
            string className4 = classText4.Text;
            string className5 = classText5.Text;
            string className6 = classText6.Text;
            string className7 = classText7.Text;
            string className8 = classText8.Text;

            # region alias
            Dictionary<string, string> alias = new Dictionary<string, string>();
            for (int i = 0; i < displayNumClass.Count; i++)
            {
                if (i == 0 && !string.IsNullOrEmpty(className1))
                {
                    alias.Add(displayNumClass[0].ClassName, className1);
                }
                else if (i == 1 && !string.IsNullOrEmpty(className2))
                {
                    alias.Add(displayNumClass[1].ClassName, className2);
                }
                else if (i == 2 && !string.IsNullOrEmpty(className3))
                {
                    alias.Add(displayNumClass[2].ClassName, className3);
                }
                else if (i == 3 && !string.IsNullOrEmpty(className4))
                {
                    alias.Add(displayNumClass[3].ClassName, className4);
                }
                else if (i == 4 && !string.IsNullOrEmpty(className5))
                {
                    alias.Add(displayNumClass[4].ClassName, className5);
                }
                else if (i == 5 && !string.IsNullOrEmpty(className6))
                {
                    alias.Add(displayNumClass[5].ClassName, className6);
                }
                else if (i == 6 && !string.IsNullOrEmpty(className7))
                {
                    alias.Add(displayNumClass[6].ClassName, className7);
                }
                else if (i == 7 && !string.IsNullOrEmpty(className8))
                {
                    alias.Add(displayNumClass[7].ClassName, className8);
                }
            }

            foreach (ClassDescripe cd in displayNumClass)
            {
                if (alias.Keys.Contains(cd.ClassName))
                {
                    cd.ClassName = alias[cd.ClassName];
                }
                foreach (PropertyDescripe pd in cd.Propertis)
                {
                    if (pd.Class != null)
                    {
                        if (alias.Keys.Contains(pd.Class.ClassName))
                        {
                            pd.Class.ClassName = alias[pd.Class.ClassName];
                        }
                    }
                }
            }
            # endregion

            DisplayNumClass();

        }

        private void jonText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            } 
        }

   
        private void classCodeText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            } 
        }
       
    }
}
