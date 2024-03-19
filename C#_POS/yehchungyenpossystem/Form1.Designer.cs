namespace yehchungyenpossystem
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox_主菜區 = new System.Windows.Forms.GroupBox();
            this.comboBoxfish_hotlevel = new System.Windows.Forms.ComboBox();
            this.comboBoxbigmac_hotlevel = new System.Windows.Forms.ComboBox();
            this.comboBoxchicken_hotlevel = new System.Windows.Forms.ComboBox();
            this.comboBoxbeef_hotlevel = new System.Windows.Forms.ComboBox();
            this.numericUpDown_fishburger = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_bigmac = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_chickenburger = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_beefburger = new System.Windows.Forms.NumericUpDown();
            this.checkBox_fishburger = new System.Windows.Forms.CheckBox();
            this.checkBox_Bigmac = new System.Windows.Forms.CheckBox();
            this.checkBox_chickenburger = new System.Windows.Forms.CheckBox();
            this.checkBox_beefburger = new System.Windows.Forms.CheckBox();
            this.button_送單 = new System.Windows.Forms.Button();
            this.button_預覽 = new System.Windows.Forms.Button();
            this.button_print = new System.Windows.Forms.Button();
            this.textBox_detail = new System.Windows.Forms.TextBox();
            this.label_total = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_redtea = new System.Windows.Forms.RadioButton();
            this.radioButton_coffee = new System.Windows.Forms.RadioButton();
            this.radioButton_coke = new System.Windows.Forms.RadioButton();
            this.checkBox_drink = new System.Windows.Forms.CheckBox();
            this.pictureBox_drink = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_big = new System.Windows.Forms.RadioButton();
            this.radioButton_medium = new System.Windows.Forms.RadioButton();
            this.radioButton_small = new System.Windows.Forms.RadioButton();
            this.checkBox_french = new System.Windows.Forms.CheckBox();
            this.label_datetime = new System.Windows.Forms.Label();
            this.timer_datetime = new System.Windows.Forms.Timer(this.components);
            this.label_runninglight = new System.Windows.Forms.Label();
            this.timer_runninglight = new System.Windows.Forms.Timer(this.components);
            this.listBox_discount = new System.Windows.Forms.ListBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox_主菜區.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_fishburger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bigmac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_chickenburger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_beefburger)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_drink)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_主菜區
            // 
            this.groupBox_主菜區.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox_主菜區.Controls.Add(this.comboBoxfish_hotlevel);
            this.groupBox_主菜區.Controls.Add(this.comboBoxbigmac_hotlevel);
            this.groupBox_主菜區.Controls.Add(this.comboBoxchicken_hotlevel);
            this.groupBox_主菜區.Controls.Add(this.comboBoxbeef_hotlevel);
            this.groupBox_主菜區.Controls.Add(this.numericUpDown_fishburger);
            this.groupBox_主菜區.Controls.Add(this.numericUpDown_bigmac);
            this.groupBox_主菜區.Controls.Add(this.numericUpDown_chickenburger);
            this.groupBox_主菜區.Controls.Add(this.numericUpDown_beefburger);
            this.groupBox_主菜區.Controls.Add(this.checkBox_fishburger);
            this.groupBox_主菜區.Controls.Add(this.checkBox_Bigmac);
            this.groupBox_主菜區.Controls.Add(this.checkBox_chickenburger);
            this.groupBox_主菜區.Controls.Add(this.checkBox_beefburger);
            this.groupBox_主菜區.Font = new System.Drawing.Font("新細明體", 12F);
            this.groupBox_主菜區.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox_主菜區.Location = new System.Drawing.Point(18, 21);
            this.groupBox_主菜區.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_主菜區.Name = "groupBox_主菜區";
            this.groupBox_主菜區.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_主菜區.Size = new System.Drawing.Size(626, 308);
            this.groupBox_主菜區.TabIndex = 0;
            this.groupBox_主菜區.TabStop = false;
            this.groupBox_主菜區.Text = "主菜區";
            // 
            // comboBoxfish_hotlevel
            // 
            this.comboBoxfish_hotlevel.FormattingEnabled = true;
            this.comboBoxfish_hotlevel.Items.AddRange(new object[] {
            "normal ",
            "little",
            "medium",
            "big"});
            this.comboBoxfish_hotlevel.Location = new System.Drawing.Point(360, 164);
            this.comboBoxfish_hotlevel.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxfish_hotlevel.Name = "comboBoxfish_hotlevel";
            this.comboBoxfish_hotlevel.Size = new System.Drawing.Size(180, 24);
            this.comboBoxfish_hotlevel.TabIndex = 1;
            this.comboBoxfish_hotlevel.Text = "normal";
            // 
            // comboBoxbigmac_hotlevel
            // 
            this.comboBoxbigmac_hotlevel.FormattingEnabled = true;
            this.comboBoxbigmac_hotlevel.Items.AddRange(new object[] {
            "normal ",
            "little",
            "medium",
            "big"});
            this.comboBoxbigmac_hotlevel.Location = new System.Drawing.Point(360, 125);
            this.comboBoxbigmac_hotlevel.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxbigmac_hotlevel.Name = "comboBoxbigmac_hotlevel";
            this.comboBoxbigmac_hotlevel.Size = new System.Drawing.Size(180, 24);
            this.comboBoxbigmac_hotlevel.TabIndex = 1;
            this.comboBoxbigmac_hotlevel.Text = "normal ";
            // 
            // comboBoxchicken_hotlevel
            // 
            this.comboBoxchicken_hotlevel.FormattingEnabled = true;
            this.comboBoxchicken_hotlevel.Items.AddRange(new object[] {
            "normal ",
            "little",
            "medium",
            "big"});
            this.comboBoxchicken_hotlevel.Location = new System.Drawing.Point(360, 91);
            this.comboBoxchicken_hotlevel.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxchicken_hotlevel.Name = "comboBoxchicken_hotlevel";
            this.comboBoxchicken_hotlevel.Size = new System.Drawing.Size(180, 24);
            this.comboBoxchicken_hotlevel.TabIndex = 1;
            this.comboBoxchicken_hotlevel.Text = "normal";
            // 
            // comboBoxbeef_hotlevel
            // 
            this.comboBoxbeef_hotlevel.FormattingEnabled = true;
            this.comboBoxbeef_hotlevel.Items.AddRange(new object[] {
            "normal ",
            "little",
            "medium",
            "big"});
            this.comboBoxbeef_hotlevel.Location = new System.Drawing.Point(360, 53);
            this.comboBoxbeef_hotlevel.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxbeef_hotlevel.Name = "comboBoxbeef_hotlevel";
            this.comboBoxbeef_hotlevel.Size = new System.Drawing.Size(180, 24);
            this.comboBoxbeef_hotlevel.TabIndex = 1;
            this.comboBoxbeef_hotlevel.Text = "normal ";
            // 
            // numericUpDown_fishburger
            // 
            this.numericUpDown_fishburger.Location = new System.Drawing.Point(272, 160);
            this.numericUpDown_fishburger.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_fishburger.Name = "numericUpDown_fishburger";
            this.numericUpDown_fishburger.Size = new System.Drawing.Size(56, 27);
            this.numericUpDown_fishburger.TabIndex = 1;
            this.numericUpDown_fishburger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_fishburger.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_bigmac
            // 
            this.numericUpDown_bigmac.Location = new System.Drawing.Point(272, 127);
            this.numericUpDown_bigmac.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_bigmac.Name = "numericUpDown_bigmac";
            this.numericUpDown_bigmac.Size = new System.Drawing.Size(56, 27);
            this.numericUpDown_bigmac.TabIndex = 1;
            this.numericUpDown_bigmac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_bigmac.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_chickenburger
            // 
            this.numericUpDown_chickenburger.Location = new System.Drawing.Point(272, 91);
            this.numericUpDown_chickenburger.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_chickenburger.Name = "numericUpDown_chickenburger";
            this.numericUpDown_chickenburger.Size = new System.Drawing.Size(56, 27);
            this.numericUpDown_chickenburger.TabIndex = 1;
            this.numericUpDown_chickenburger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_chickenburger.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_beefburger
            // 
            this.numericUpDown_beefburger.Location = new System.Drawing.Point(272, 53);
            this.numericUpDown_beefburger.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_beefburger.Name = "numericUpDown_beefburger";
            this.numericUpDown_beefburger.Size = new System.Drawing.Size(56, 27);
            this.numericUpDown_beefburger.TabIndex = 1;
            this.numericUpDown_beefburger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_beefburger.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox_fishburger
            // 
            this.checkBox_fishburger.AutoSize = true;
            this.checkBox_fishburger.Checked = true;
            this.checkBox_fishburger.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_fishburger.Location = new System.Drawing.Point(58, 169);
            this.checkBox_fishburger.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_fishburger.Name = "checkBox_fishburger";
            this.checkBox_fishburger.Size = new System.Drawing.Size(123, 20);
            this.checkBox_fishburger.TabIndex = 0;
            this.checkBox_fishburger.Text = "fish burger $45";
            this.checkBox_fishburger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_fishburger.UseVisualStyleBackColor = true;
            // 
            // checkBox_Bigmac
            // 
            this.checkBox_Bigmac.AutoSize = true;
            this.checkBox_Bigmac.Checked = true;
            this.checkBox_Bigmac.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Bigmac.Location = new System.Drawing.Point(58, 135);
            this.checkBox_Bigmac.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_Bigmac.Name = "checkBox_Bigmac";
            this.checkBox_Bigmac.Size = new System.Drawing.Size(108, 20);
            this.checkBox_Bigmac.TabIndex = 0;
            this.checkBox_Bigmac.Text = "Big Mac $65";
            this.checkBox_Bigmac.UseVisualStyleBackColor = true;
            // 
            // checkBox_chickenburger
            // 
            this.checkBox_chickenburger.AutoSize = true;
            this.checkBox_chickenburger.Checked = true;
            this.checkBox_chickenburger.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_chickenburger.Location = new System.Drawing.Point(58, 100);
            this.checkBox_chickenburger.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_chickenburger.Name = "checkBox_chickenburger";
            this.checkBox_chickenburger.Size = new System.Drawing.Size(149, 20);
            this.checkBox_chickenburger.TabIndex = 0;
            this.checkBox_chickenburger.Text = "chicken burger $55";
            this.checkBox_chickenburger.UseVisualStyleBackColor = true;
            // 
            // checkBox_beefburger
            // 
            this.checkBox_beefburger.AutoSize = true;
            this.checkBox_beefburger.Checked = true;
            this.checkBox_beefburger.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_beefburger.Location = new System.Drawing.Point(58, 65);
            this.checkBox_beefburger.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_beefburger.Name = "checkBox_beefburger";
            this.checkBox_beefburger.Size = new System.Drawing.Size(127, 20);
            this.checkBox_beefburger.TabIndex = 0;
            this.checkBox_beefburger.Text = "beef burger $75";
            this.checkBox_beefburger.UseVisualStyleBackColor = true;
            // 
            // button_送單
            // 
            this.button_送單.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_送單.Location = new System.Drawing.Point(107, 341);
            this.button_送單.Margin = new System.Windows.Forms.Padding(4);
            this.button_送單.Name = "button_送單";
            this.button_送單.Size = new System.Drawing.Size(122, 59);
            this.button_送單.TabIndex = 1;
            this.button_送單.Text = "送單";
            this.button_送單.UseVisualStyleBackColor = false;
            this.button_送單.Click += new System.EventHandler(this.button_送單_Click);
            // 
            // button_預覽
            // 
            this.button_預覽.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_預覽.Location = new System.Drawing.Point(107, 404);
            this.button_預覽.Margin = new System.Windows.Forms.Padding(4);
            this.button_預覽.Name = "button_預覽";
            this.button_預覽.Size = new System.Drawing.Size(122, 59);
            this.button_預覽.TabIndex = 1;
            this.button_預覽.Text = "預覽";
            this.button_預覽.UseVisualStyleBackColor = false;
            this.button_預覽.Click += new System.EventHandler(this.button_列印收據_Click);
            // 
            // button_print
            // 
            this.button_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_print.Location = new System.Drawing.Point(107, 471);
            this.button_print.Margin = new System.Windows.Forms.Padding(4);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(122, 59);
            this.button_print.TabIndex = 1;
            this.button_print.Text = "列印";
            this.button_print.UseVisualStyleBackColor = false;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // textBox_detail
            // 
            this.textBox_detail.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox_detail.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_detail.Location = new System.Drawing.Point(1150, 21);
            this.textBox_detail.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_detail.Multiline = true;
            this.textBox_detail.Name = "textBox_detail";
            this.textBox_detail.ReadOnly = true;
            this.textBox_detail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_detail.Size = new System.Drawing.Size(371, 618);
            this.textBox_detail.TabIndex = 2;
            this.textBox_detail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_total
            // 
            this.label_total.BackColor = System.Drawing.SystemColors.Info;
            this.label_total.Location = new System.Drawing.Point(1150, 659);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(371, 45);
            this.label_total.TabIndex = 3;
            this.label_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Controls.Add(this.radioButton_redtea);
            this.groupBox1.Controls.Add(this.radioButton_coffee);
            this.groupBox1.Controls.Add(this.radioButton_coke);
            this.groupBox1.Location = new System.Drawing.Point(651, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 278);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // radioButton_redtea
            // 
            this.radioButton_redtea.AutoSize = true;
            this.radioButton_redtea.Location = new System.Drawing.Point(6, 182);
            this.radioButton_redtea.Name = "radioButton_redtea";
            this.radioButton_redtea.Size = new System.Drawing.Size(68, 20);
            this.radioButton_redtea.TabIndex = 1;
            this.radioButton_redtea.TabStop = true;
            this.radioButton_redtea.Text = "red tea";
            this.radioButton_redtea.UseVisualStyleBackColor = true;
            this.radioButton_redtea.MouseLeave += new System.EventHandler(this.radioButton_redtea_MouseLeave);
            this.radioButton_redtea.MouseHover += new System.EventHandler(this.radioButton_redtea_MouseHover);
            // 
            // radioButton_coffee
            // 
            this.radioButton_coffee.AutoSize = true;
            this.radioButton_coffee.Location = new System.Drawing.Point(6, 105);
            this.radioButton_coffee.Name = "radioButton_coffee";
            this.radioButton_coffee.Size = new System.Drawing.Size(97, 20);
            this.radioButton_coffee.TabIndex = 1;
            this.radioButton_coffee.TabStop = true;
            this.radioButton_coffee.Text = "coffee + 5$";
            this.radioButton_coffee.UseVisualStyleBackColor = true;
            this.radioButton_coffee.MouseLeave += new System.EventHandler(this.radioButton_coffee_MouseLeave);
            this.radioButton_coffee.MouseHover += new System.EventHandler(this.radioButton_coffee_MouseHover);
            // 
            // radioButton_coke
            // 
            this.radioButton_coke.AutoSize = true;
            this.radioButton_coke.Location = new System.Drawing.Point(6, 35);
            this.radioButton_coke.Name = "radioButton_coke";
            this.radioButton_coke.Size = new System.Drawing.Size(56, 20);
            this.radioButton_coke.TabIndex = 1;
            this.radioButton_coke.TabStop = true;
            this.radioButton_coke.Text = "coke";
            this.radioButton_coke.UseVisualStyleBackColor = true;
            this.radioButton_coke.MouseLeave += new System.EventHandler(this.radioButton_coke_MouseLeave);
            this.radioButton_coke.MouseHover += new System.EventHandler(this.radioButton_coke_MouseHover);
            // 
            // checkBox_drink
            // 
            this.checkBox_drink.AutoSize = true;
            this.checkBox_drink.Location = new System.Drawing.Point(651, 21);
            this.checkBox_drink.Name = "checkBox_drink";
            this.checkBox_drink.Size = new System.Drawing.Size(88, 20);
            this.checkBox_drink.TabIndex = 0;
            this.checkBox_drink.Text = "drink $30";
            this.checkBox_drink.UseVisualStyleBackColor = true;
            // 
            // pictureBox_drink
            // 
            this.pictureBox_drink.Image = global::yehchungyenpossystem.Properties.Resources.Vegitable_and_Fruit;
            this.pictureBox_drink.Location = new System.Drawing.Point(807, 51);
            this.pictureBox_drink.Name = "pictureBox_drink";
            this.pictureBox_drink.Size = new System.Drawing.Size(168, 146);
            this.pictureBox_drink.TabIndex = 5;
            this.pictureBox_drink.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox2.Controls.Add(this.radioButton_big);
            this.groupBox2.Controls.Add(this.radioButton_medium);
            this.groupBox2.Controls.Add(this.radioButton_small);
            this.groupBox2.Location = new System.Drawing.Point(651, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // radioButton_big
            // 
            this.radioButton_big.AutoSize = true;
            this.radioButton_big.Location = new System.Drawing.Point(307, 26);
            this.radioButton_big.Name = "radioButton_big";
            this.radioButton_big.Size = new System.Drawing.Size(74, 20);
            this.radioButton_big.TabIndex = 0;
            this.radioButton_big.TabStop = true;
            this.radioButton_big.Text = "big $30";
            this.radioButton_big.UseVisualStyleBackColor = true;
            // 
            // radioButton_medium
            // 
            this.radioButton_medium.AutoSize = true;
            this.radioButton_medium.Location = new System.Drawing.Point(166, 26);
            this.radioButton_medium.Name = "radioButton_medium";
            this.radioButton_medium.Size = new System.Drawing.Size(105, 20);
            this.radioButton_medium.TabIndex = 0;
            this.radioButton_medium.TabStop = true;
            this.radioButton_medium.Text = "medium $20";
            this.radioButton_medium.UseVisualStyleBackColor = true;
            // 
            // radioButton_small
            // 
            this.radioButton_small.AutoSize = true;
            this.radioButton_small.Location = new System.Drawing.Point(17, 26);
            this.radioButton_small.Name = "radioButton_small";
            this.radioButton_small.Size = new System.Drawing.Size(87, 20);
            this.radioButton_small.TabIndex = 0;
            this.radioButton_small.TabStop = true;
            this.radioButton_small.Text = "small $15";
            this.radioButton_small.UseVisualStyleBackColor = true;
            // 
            // checkBox_french
            // 
            this.checkBox_french.AutoSize = true;
            this.checkBox_french.Location = new System.Drawing.Point(651, 337);
            this.checkBox_french.Name = "checkBox_french";
            this.checkBox_french.Size = new System.Drawing.Size(98, 20);
            this.checkBox_french.TabIndex = 7;
            this.checkBox_french.Text = "french fries";
            this.checkBox_french.UseVisualStyleBackColor = true;
            // 
            // label_datetime
            // 
            this.label_datetime.AutoSize = true;
            this.label_datetime.Location = new System.Drawing.Point(807, 21);
            this.label_datetime.Name = "label_datetime";
            this.label_datetime.Size = new System.Drawing.Size(61, 16);
            this.label_datetime.TabIndex = 8;
            this.label_datetime.Text = "datetime";
            // 
            // timer_datetime
            // 
            this.timer_datetime.Tick += new System.EventHandler(this.timer_datetime_Tick);
            // 
            // label_runninglight
            // 
            this.label_runninglight.AutoSize = true;
            this.label_runninglight.Location = new System.Drawing.Point(236, 341);
            this.label_runninglight.Name = "label_runninglight";
            this.label_runninglight.Size = new System.Drawing.Size(170, 16);
            this.label_runninglight.TabIndex = 9;
            this.label_runninglight.Text = "welcome to our restaurant";
            // 
            // timer_runninglight
            // 
            this.timer_runninglight.Tick += new System.EventHandler(this.timer_runninglight_Tick);
            // 
            // listBox_discount
            // 
            this.listBox_discount.BackColor = System.Drawing.Color.Cornsilk;
            this.listBox_discount.FormattingEnabled = true;
            this.listBox_discount.ItemHeight = 16;
            this.listBox_discount.Items.AddRange(new object[] {
            "no discount",
            "10%",
            "50%",
            "80%",
            "100%"});
            this.listBox_discount.Location = new System.Drawing.Point(18, 341);
            this.listBox_discount.Name = "listBox_discount";
            this.listBox_discount.Size = new System.Drawing.Size(82, 84);
            this.listBox_discount.TabIndex = 10;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::yehchungyenpossystem.Properties.Resources.form1background;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.listBox_discount);
            this.Controls.Add(this.label_runninglight);
            this.Controls.Add(this.label_datetime);
            this.Controls.Add(this.checkBox_french);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox_drink);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox_drink);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.textBox_detail);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.button_預覽);
            this.Controls.Add(this.button_送單);
            this.Controls.Add(this.groupBox_主菜區);
            this.Font = new System.Drawing.Font("新細明體", 12F);
            this.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "POS System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_主菜區.ResumeLayout(false);
            this.groupBox_主菜區.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_fishburger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bigmac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_chickenburger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_beefburger)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_drink)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_主菜區;
        private System.Windows.Forms.CheckBox checkBox_fishburger;
        private System.Windows.Forms.CheckBox checkBox_Bigmac;
        private System.Windows.Forms.CheckBox checkBox_chickenburger;
        private System.Windows.Forms.CheckBox checkBox_beefburger;
        private System.Windows.Forms.ComboBox comboBoxfish_hotlevel;
        private System.Windows.Forms.ComboBox comboBoxbigmac_hotlevel;
        private System.Windows.Forms.ComboBox comboBoxchicken_hotlevel;
        private System.Windows.Forms.ComboBox comboBoxbeef_hotlevel;
        private System.Windows.Forms.NumericUpDown numericUpDown_fishburger;
        private System.Windows.Forms.NumericUpDown numericUpDown_bigmac;
        private System.Windows.Forms.NumericUpDown numericUpDown_chickenburger;
        private System.Windows.Forms.NumericUpDown numericUpDown_beefburger;
        private System.Windows.Forms.Button button_送單;
        private System.Windows.Forms.Button button_預覽;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.TextBox textBox_detail;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_redtea;
        private System.Windows.Forms.RadioButton radioButton_coffee;
        private System.Windows.Forms.RadioButton radioButton_coke;
        private System.Windows.Forms.CheckBox checkBox_drink;
        private System.Windows.Forms.PictureBox pictureBox_drink;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_big;
        private System.Windows.Forms.RadioButton radioButton_medium;
        private System.Windows.Forms.RadioButton radioButton_small;
        private System.Windows.Forms.CheckBox checkBox_french;
        private System.Windows.Forms.Label label_datetime;
        private System.Windows.Forms.Timer timer_datetime;
        private System.Windows.Forms.Label label_runninglight;
        private System.Windows.Forms.Timer timer_runninglight;
        private System.Windows.Forms.ListBox listBox_discount;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

