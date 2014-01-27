using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JsonToClass
{
    /// <summary>
    /// 类结构描述
    /// </summary>
    public class ClassDescripe
    {
        /// <summary>
        /// 类名
        /// </summary>
        public string ClassName { set; get; }

        /// <summary>
        /// 类的属性
        /// </summary>
        public List<PropertyDescripe> Propertis { set; get; }

        /// <summary>
        /// 两个类是否相同
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool IsSame(ClassDescripe c1, ClassDescripe c2)
        {
            if (c1.Propertis.Count == 0 || c2.Propertis.Count == 0)
            {
                return false;
            }
            //你中有我
            foreach (PropertyDescripe pd in c1.Propertis)
            {
                if (!c2.containProperty(pd)) //name 是否相同
                {
                    return false;
                }
            }
            //我中有你
            foreach (PropertyDescripe pd in c2.Propertis)
            {
                if (!c1.containProperty(pd)) //name 是否相同
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// 是否包含属性
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public bool containProperty(PropertyDescripe property)
        {
            if (property == null || 
                string.IsNullOrEmpty(property.PropertyName))
                return false;

            foreach (PropertyDescripe pd in this.Propertis)
            {
                if (pd.Class==null && 
                    property.Class==null &&
                    pd.PropertyName == property.PropertyName ) //大小写敏感
                {
                    return true;
                }
                else if (pd.Class != null && property.Class != null && pd.PropertyName == property.PropertyName)
                {
                    return IsSame(property.Class, pd.Class);
                }
            }
            return false;
        }
    }

    /// <summary>
    /// 属性描述
    /// </summary>
    public class PropertyDescripe
    {
        /// <summary>
        /// 属性名称
        /// </summary>
        public string PropertyName { set; get; }
        /// <summary>
        /// 类型
        /// </summary>
        public Type MyType { set; get; }
        /// <summary>
        /// 属性为类时，所属类
        /// </summary>
        public ClassDescripe Class { set; get; }
        /// <summary>
        /// 类是否为List 0/1
        /// </summary>
        public int  IsList { set; get; }
        
    }

}
