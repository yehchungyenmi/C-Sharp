namespace _10714D025
{
    partial class Form_my_calculator
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_calculator = new System.Windows.Forms.GroupBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_正負建 = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.label_機算機螢幕 = new System.Windows.Forms.Label();
            this.button_等於 = new System.Windows.Forms.Button();
            this.button_除 = new System.Windows.Forms.Button();
            this.button_乘 = new System.Windows.Forms.Button();
            this.button_減 = new System.Windows.Forms.Button();
            this.button_加 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_percent = new System.Windows.Forms.Button();
            this.button_退回 = new System.Windows.Forms.Button();
            this.button_階乘 = new System.Windows.Forms.Button();
            this.button_開根號 = new System.Windows.Forms.Button();
            this.button_累加 = new System.Windows.Forms.Button();
            this.button_乘冪數 = new System.Windows.Forms.Button();
            this.groupBox_calculator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_calculator
            // 
            this.groupBox_calculator.BackColor = System.Drawing.Color.Black;
            this.groupBox_calculator.Controls.Add(this.button_clear);
            this.groupBox_calculator.Controls.Add(this.button_正負建);
            this.groupBox_calculator.Controls.Add(this.button_dot);
            this.groupBox_calculator.Controls.Add(this.label_機算機螢幕);
            this.groupBox_calculator.Controls.Add(this.button_等於);
            this.groupBox_calculator.Controls.Add(this.button_除);
            this.groupBox_calculator.Controls.Add(this.button_乘);
            this.groupBox_calculator.Controls.Add(this.button_減);
            this.groupBox_calculator.Controls.Add(this.button_加);
            this.groupBox_calculator.Controls.Add(this.button_9);
            this.groupBox_calculator.Controls.Add(this.button_8);
            this.groupBox_calculator.Controls.Add(this.button_5);
            this.groupBox_calculator.Controls.Add(this.button_6);
            this.groupBox_calculator.Controls.Add(this.button_3);
            this.groupBox_calculator.Controls.Add(this.button_2);
            this.groupBox_calculator.Controls.Add(this.button_1);
            this.groupBox_calculator.Controls.Add(this.button_4);
            this.groupBox_calculator.Controls.Add(this.button_7);
            this.groupBox_calculator.Controls.Add(this.button_0);
            this.groupBox_calculator.Controls.Add(this.panel1);
            this.groupBox_calculator.Font = new System.Drawing.Font("新細明體", 14F);
            this.groupBox_calculator.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox_calculator.Location = new System.Drawing.Point(3, 3);
            this.groupBox_calculator.Name = "groupBox_calculator";
            this.groupBox_calculator.Size = new System.Drawing.Size(535, 365);
            this.groupBox_calculator.TabIndex = 0;
            this.groupBox_calculator.TabStop = false;
            this.groupBox_calculator.Text = "calculator";
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.OrangeRed;
            this.button_clear.Location = new System.Drawing.Point(284, 128);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(57, 46);
            this.button_clear.TabIndex = 3;
            this.button_clear.Text = "CLR";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_正負建
            // 
            this.button_正負建.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_正負建.Location = new System.Drawing.Point(284, 180);
            this.button_正負建.Name = "button_正負建";
            this.button_正負建.Size = new System.Drawing.Size(57, 46);
            this.button_正負建.TabIndex = 3;
            this.button_正負建.Text = "+/-";
            this.button_正負建.UseVisualStyleBackColor = false;
            this.button_正負建.Click += new System.EventHandler(this.button_正負建_Click);
            // 
            // button_dot
            // 
            this.button_dot.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_dot.Location = new System.Drawing.Point(158, 287);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(57, 46);
            this.button_dot.TabIndex = 3;
            this.button_dot.Text = ".";
            this.button_dot.UseVisualStyleBackColor = false;
            this.button_dot.Click += new System.EventHandler(this.button_dot_Click);
            // 
            // label_機算機螢幕
            // 
            this.label_機算機螢幕.BackColor = System.Drawing.Color.White;
            this.label_機算機螢幕.ForeColor = System.Drawing.Color.Black;
            this.label_機算機螢幕.Location = new System.Drawing.Point(29, 48);
            this.label_機算機螢幕.Name = "label_機算機螢幕";
            this.label_機算機螢幕.Size = new System.Drawing.Size(312, 66);
            this.label_機算機螢幕.TabIndex = 2;
            this.label_機算機螢幕.Text = "0";
            this.label_機算機螢幕.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_等於
            // 
            this.button_等於.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_等於.Location = new System.Drawing.Point(284, 233);
            this.button_等於.Name = "button_等於";
            this.button_等於.Size = new System.Drawing.Size(57, 100);
            this.button_等於.TabIndex = 1;
            this.button_等於.Tag = "=";
            this.button_等於.Text = "=";
            this.button_等於.UseVisualStyleBackColor = false;
            this.button_等於.Click += new System.EventHandler(this.button_等於_Click);
            // 
            // button_除
            // 
            this.button_除.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_除.Location = new System.Drawing.Point(221, 286);
            this.button_除.Name = "button_除";
            this.button_除.Size = new System.Drawing.Size(57, 47);
            this.button_除.TabIndex = 1;
            this.button_除.Tag = "/";
            this.button_除.Text = "/";
            this.button_除.UseVisualStyleBackColor = false;
            this.button_除.Click += new System.EventHandler(this.button_加_Click);
            // 
            // button_乘
            // 
            this.button_乘.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_乘.Location = new System.Drawing.Point(221, 233);
            this.button_乘.Name = "button_乘";
            this.button_乘.Size = new System.Drawing.Size(57, 47);
            this.button_乘.TabIndex = 1;
            this.button_乘.Tag = "*";
            this.button_乘.Text = "*";
            this.button_乘.UseVisualStyleBackColor = false;
            this.button_乘.Click += new System.EventHandler(this.button_加_Click);
            // 
            // button_減
            // 
            this.button_減.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_減.Location = new System.Drawing.Point(221, 180);
            this.button_減.Name = "button_減";
            this.button_減.Size = new System.Drawing.Size(57, 47);
            this.button_減.TabIndex = 1;
            this.button_減.Tag = "-";
            this.button_減.Text = "-";
            this.button_減.UseVisualStyleBackColor = false;
            this.button_減.Click += new System.EventHandler(this.button_加_Click);
            // 
            // button_加
            // 
            this.button_加.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_加.Location = new System.Drawing.Point(221, 127);
            this.button_加.Name = "button_加";
            this.button_加.Size = new System.Drawing.Size(57, 47);
            this.button_加.TabIndex = 1;
            this.button_加.Tag = "+";
            this.button_加.Text = "+";
            this.button_加.UseVisualStyleBackColor = false;
            this.button_加.Click += new System.EventHandler(this.button_加_Click);
            // 
            // button_9
            // 
            this.button_9.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_9.Location = new System.Drawing.Point(157, 233);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(58, 47);
            this.button_9.TabIndex = 0;
            this.button_9.Tag = "";
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = false;
            this.button_9.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_8
            // 
            this.button_8.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_8.Location = new System.Drawing.Point(93, 233);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(58, 47);
            this.button_8.TabIndex = 0;
            this.button_8.Tag = "";
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = false;
            this.button_8.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_5
            // 
            this.button_5.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_5.Location = new System.Drawing.Point(93, 180);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(58, 47);
            this.button_5.TabIndex = 0;
            this.button_5.Tag = "";
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = false;
            this.button_5.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_6
            // 
            this.button_6.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_6.Location = new System.Drawing.Point(157, 180);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(58, 47);
            this.button_6.TabIndex = 0;
            this.button_6.Tag = "";
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = false;
            this.button_6.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_3
            // 
            this.button_3.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_3.Location = new System.Drawing.Point(157, 127);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(58, 47);
            this.button_3.TabIndex = 0;
            this.button_3.Tag = "";
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = false;
            this.button_3.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_2
            // 
            this.button_2.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_2.Location = new System.Drawing.Point(93, 127);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(58, 47);
            this.button_2.TabIndex = 0;
            this.button_2.Tag = "";
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = false;
            this.button_2.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_1
            // 
            this.button_1.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_1.Location = new System.Drawing.Point(29, 127);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(58, 47);
            this.button_1.TabIndex = 0;
            this.button_1.Tag = "";
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = false;
            this.button_1.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_4
            // 
            this.button_4.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_4.Location = new System.Drawing.Point(29, 180);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(58, 47);
            this.button_4.TabIndex = 0;
            this.button_4.Tag = "";
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = false;
            this.button_4.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_7
            // 
            this.button_7.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_7.Location = new System.Drawing.Point(29, 233);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(58, 47);
            this.button_7.TabIndex = 0;
            this.button_7.Tag = "";
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = false;
            this.button_7.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_0
            // 
            this.button_0.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_0.Location = new System.Drawing.Point(29, 286);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(122, 47);
            this.button_0.TabIndex = 0;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = false;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_percent);
            this.panel1.Controls.Add(this.button_退回);
            this.panel1.Controls.Add(this.button_階乘);
            this.panel1.Controls.Add(this.button_開根號);
            this.panel1.Controls.Add(this.button_累加);
            this.panel1.Controls.Add(this.button_乘冪數);
            this.panel1.Location = new System.Drawing.Point(347, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 207);
            this.panel1.TabIndex = 5;
            // 
            // button_percent
            // 
            this.button_percent.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_percent.ForeColor = System.Drawing.SystemColors.Info;
            this.button_percent.Location = new System.Drawing.Point(85, 108);
            this.button_percent.Name = "button_percent";
            this.button_percent.Size = new System.Drawing.Size(82, 45);
            this.button_percent.TabIndex = 5;
            this.button_percent.Tag = "%";
            this.button_percent.Text = "百分比";
            this.button_percent.UseVisualStyleBackColor = false;
            this.button_percent.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_退回
            // 
            this.button_退回.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_退回.Location = new System.Drawing.Point(3, 3);
            this.button_退回.Name = "button_退回";
            this.button_退回.Size = new System.Drawing.Size(82, 46);
            this.button_退回.TabIndex = 4;
            this.button_退回.Text = "退回";
            this.button_退回.UseVisualStyleBackColor = false;
            this.button_退回.Click += new System.EventHandler(this.button_退回_Click);
            // 
            // button_階乘
            // 
            this.button_階乘.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_階乘.Location = new System.Drawing.Point(3, 107);
            this.button_階乘.Name = "button_階乘";
            this.button_階乘.Size = new System.Drawing.Size(82, 46);
            this.button_階乘.TabIndex = 4;
            this.button_階乘.Tag = "階乘";
            this.button_階乘.Text = "階乘";
            this.button_階乘.UseVisualStyleBackColor = false;
            this.button_階乘.Click += new System.EventHandler(this.button_階乘_Click);
            // 
            // button_開根號
            // 
            this.button_開根號.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_開根號.Location = new System.Drawing.Point(85, 3);
            this.button_開根號.Name = "button_開根號";
            this.button_開根號.Size = new System.Drawing.Size(82, 46);
            this.button_開根號.TabIndex = 4;
            this.button_開根號.Tag = "開根號";
            this.button_開根號.Text = "開根號";
            this.button_開根號.UseVisualStyleBackColor = false;
            this.button_開根號.Click += new System.EventHandler(this.button_開根號_Click);
            // 
            // button_累加
            // 
            this.button_累加.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_累加.Location = new System.Drawing.Point(3, 55);
            this.button_累加.Name = "button_累加";
            this.button_累加.Size = new System.Drawing.Size(82, 46);
            this.button_累加.TabIndex = 4;
            this.button_累加.Tag = "累加";
            this.button_累加.Text = "累加";
            this.button_累加.UseVisualStyleBackColor = false;
            this.button_累加.Click += new System.EventHandler(this.button_加_Click);
            // 
            // button_乘冪數
            // 
            this.button_乘冪數.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_乘冪數.Location = new System.Drawing.Point(85, 55);
            this.button_乘冪數.Name = "button_乘冪數";
            this.button_乘冪數.Size = new System.Drawing.Size(82, 46);
            this.button_乘冪數.TabIndex = 4;
            this.button_乘冪數.Tag = "乘冪數";
            this.button_乘冪數.Text = "乘冪數";
            this.button_乘冪數.UseVisualStyleBackColor = false;
            this.button_乘冪數.Click += new System.EventHandler(this.button_乘冪數_Click);
            // 
            // Form_my_calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 369);
            this.Controls.Add(this.groupBox_calculator);
            this.Name = "Form_my_calculator";
            this.Text = "my calulator";
            this.Load += new System.EventHandler(this.Form_my_calculator_Load);
            this.groupBox_calculator.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_calculator;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Label label_機算機螢幕;
        private System.Windows.Forms.Button button_等於;
        private System.Windows.Forms.Button button_除;
        private System.Windows.Forms.Button button_乘;
        private System.Windows.Forms.Button button_減;
        private System.Windows.Forms.Button button_加;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_dot;
        private System.Windows.Forms.Button button_階乘;
        private System.Windows.Forms.Button button_乘冪數;
        private System.Windows.Forms.Button button_累加;
        private System.Windows.Forms.Button button_開根號;
        private System.Windows.Forms.Button button_退回;
        private System.Windows.Forms.Button button_正負建;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_percent;
    }
}

