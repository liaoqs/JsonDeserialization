namespace JsonToClass
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.jonText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.classCodeText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UseInt = new System.Windows.Forms.CheckBox();
            this.ReGeneratorBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.classText1 = new System.Windows.Forms.TextBox();
            this.classText2 = new System.Windows.Forms.TextBox();
            this.classText4 = new System.Windows.Forms.TextBox();
            this.classText3 = new System.Windows.Forms.TextBox();
            this.classText6 = new System.Windows.Forms.TextBox();
            this.classText5 = new System.Windows.Forms.TextBox();
            this.classText8 = new System.Windows.Forms.TextBox();
            this.classText7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // jonText
            // 
            this.jonText.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jonText.Location = new System.Drawing.Point(6, 15);
            this.jonText.Multiline = true;
            this.jonText.Name = "jonText";
            this.jonText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.jonText.Size = new System.Drawing.Size(949, 254);
            this.jonText.TabIndex = 1;
            this.jonText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jonText_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(813, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "开始构建类";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CreateClass_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.classCodeText);
            this.groupBox1.Location = new System.Drawing.Point(6, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 393);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "类结构";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // classCodeText
            // 
            this.classCodeText.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.classCodeText.Location = new System.Drawing.Point(7, 14);
            this.classCodeText.Multiline = true;
            this.classCodeText.Name = "classCodeText";
            this.classCodeText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.classCodeText.Size = new System.Drawing.Size(777, 373);
            this.classCodeText.TabIndex = 2;
            this.classCodeText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.classCodeText_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.jonText);
            this.groupBox2.Location = new System.Drawing.Point(7, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(961, 275);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "json数据";
            // 
            // UseInt
            // 
            this.UseInt.AutoSize = true;
            this.UseInt.Checked = true;
            this.UseInt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseInt.Location = new System.Drawing.Point(814, 308);
            this.UseInt.Name = "UseInt";
            this.UseInt.Size = new System.Drawing.Size(114, 16);
            this.UseInt.TabIndex = 7;
            this.UseInt.Text = "数字用Int32类型";
            this.UseInt.UseVisualStyleBackColor = true;
            // 
            // ReGeneratorBtn
            // 
            this.ReGeneratorBtn.Location = new System.Drawing.Point(830, 637);
            this.ReGeneratorBtn.Name = "ReGeneratorBtn";
            this.ReGeneratorBtn.Size = new System.Drawing.Size(116, 23);
            this.ReGeneratorBtn.TabIndex = 8;
            this.ReGeneratorBtn.Text = "重新构建替换的类";
            this.ReGeneratorBtn.UseVisualStyleBackColor = true;
            this.ReGeneratorBtn.Click += new System.EventHandler(this.ReGenerator_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(811, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "类2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(811, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "类3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(811, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "类4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(811, 529);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "类5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(811, 582);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "类7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(811, 555);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "类6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(812, 609);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "类8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(811, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 14);
            this.label8.TabIndex = 15;
            this.label8.Text = "类1";
            // 
            // classText1
            // 
            this.classText1.Location = new System.Drawing.Point(845, 417);
            this.classText1.Name = "classText1";
            this.classText1.Size = new System.Drawing.Size(100, 21);
            this.classText1.TabIndex = 16;
            // 
            // classText2
            // 
            this.classText2.Location = new System.Drawing.Point(845, 445);
            this.classText2.Name = "classText2";
            this.classText2.Size = new System.Drawing.Size(100, 21);
            this.classText2.TabIndex = 17;
            // 
            // classText4
            // 
            this.classText4.Location = new System.Drawing.Point(844, 499);
            this.classText4.Name = "classText4";
            this.classText4.Size = new System.Drawing.Size(100, 21);
            this.classText4.TabIndex = 19;
            // 
            // classText3
            // 
            this.classText3.Location = new System.Drawing.Point(844, 472);
            this.classText3.Name = "classText3";
            this.classText3.Size = new System.Drawing.Size(100, 21);
            this.classText3.TabIndex = 18;
            // 
            // classText6
            // 
            this.classText6.Location = new System.Drawing.Point(845, 553);
            this.classText6.Name = "classText6";
            this.classText6.Size = new System.Drawing.Size(100, 21);
            this.classText6.TabIndex = 21;
            // 
            // classText5
            // 
            this.classText5.Location = new System.Drawing.Point(845, 526);
            this.classText5.Name = "classText5";
            this.classText5.Size = new System.Drawing.Size(100, 21);
            this.classText5.TabIndex = 20;
            // 
            // classText8
            // 
            this.classText8.Location = new System.Drawing.Point(846, 608);
            this.classText8.Name = "classText8";
            this.classText8.Size = new System.Drawing.Size(100, 21);
            this.classText8.TabIndex = 19;
            // 
            // classText7
            // 
            this.classText7.Location = new System.Drawing.Point(846, 580);
            this.classText7.Name = "classText7";
            this.classText7.Size = new System.Drawing.Size(100, 21);
            this.classText7.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(810, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "替换左侧的类名，从上向下";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 691);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.classText8);
            this.Controls.Add(this.classText6);
            this.Controls.Add(this.classText7);
            this.Controls.Add(this.classText5);
            this.Controls.Add(this.classText4);
            this.Controls.Add(this.classText3);
            this.Controls.Add(this.classText2);
            this.Controls.Add(this.classText1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReGeneratorBtn);
            this.Controls.Add(this.UseInt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Json到类生产器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox jonText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox classCodeText;
        private System.Windows.Forms.CheckBox UseInt;
        private System.Windows.Forms.Button ReGeneratorBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox classText1;
        private System.Windows.Forms.TextBox classText2;
        private System.Windows.Forms.TextBox classText4;
        private System.Windows.Forms.TextBox classText3;
        private System.Windows.Forms.TextBox classText6;
        private System.Windows.Forms.TextBox classText5;
        private System.Windows.Forms.TextBox classText8;
        private System.Windows.Forms.TextBox classText7;
        private System.Windows.Forms.Label label9;
    }
}

