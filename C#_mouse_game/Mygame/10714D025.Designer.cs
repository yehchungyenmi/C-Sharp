namespace Mygame
{
    partial class Form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.label_time = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer_backgroundmusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer_hammersound = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer_mousecrush = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer_jingling = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.timer_gametime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer_backgroundmusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer_hammersound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer_mousecrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer_jingling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label_time
            // 
            this.label_time.BackColor = System.Drawing.Color.Transparent;
            this.label_time.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_time.Location = new System.Drawing.Point(302, 34);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(141, 27);
            this.label_time.TabIndex = 0;
            this.label_time.Text = "label1";
            this.label_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_score
            // 
            this.label_score.BackColor = System.Drawing.Color.Transparent;
            this.label_score.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_score.Location = new System.Drawing.Point(1018, 34);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(141, 27);
            this.label_score.TabIndex = 0;
            this.label_score.Text = "label1";
            this.label_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.Color.DarkOrchid;
            this.button_Start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Start.Location = new System.Drawing.Point(603, 14);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(127, 47);
            this.button_Start.TabIndex = 1;
            this.button_Start.Text = "START";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // axWindowsMediaPlayer_backgroundmusic
            // 
            this.axWindowsMediaPlayer_backgroundmusic.Enabled = true;
            this.axWindowsMediaPlayer_backgroundmusic.Location = new System.Drawing.Point(23, 85);
            this.axWindowsMediaPlayer_backgroundmusic.Name = "axWindowsMediaPlayer_backgroundmusic";
            this.axWindowsMediaPlayer_backgroundmusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer_backgroundmusic.OcxState")));
            this.axWindowsMediaPlayer_backgroundmusic.Size = new System.Drawing.Size(56, 33);
            this.axWindowsMediaPlayer_backgroundmusic.TabIndex = 2;
            // 
            // axWindowsMediaPlayer_hammersound
            // 
            this.axWindowsMediaPlayer_hammersound.Enabled = true;
            this.axWindowsMediaPlayer_hammersound.Location = new System.Drawing.Point(23, 124);
            this.axWindowsMediaPlayer_hammersound.Name = "axWindowsMediaPlayer_hammersound";
            this.axWindowsMediaPlayer_hammersound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer_hammersound.OcxState")));
            this.axWindowsMediaPlayer_hammersound.Size = new System.Drawing.Size(56, 33);
            this.axWindowsMediaPlayer_hammersound.TabIndex = 2;
            // 
            // axWindowsMediaPlayer_mousecrush
            // 
            this.axWindowsMediaPlayer_mousecrush.Enabled = true;
            this.axWindowsMediaPlayer_mousecrush.Location = new System.Drawing.Point(23, 163);
            this.axWindowsMediaPlayer_mousecrush.Name = "axWindowsMediaPlayer_mousecrush";
            this.axWindowsMediaPlayer_mousecrush.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer_mousecrush.OcxState")));
            this.axWindowsMediaPlayer_mousecrush.Size = new System.Drawing.Size(56, 33);
            this.axWindowsMediaPlayer_mousecrush.TabIndex = 2;
            // 
            // axWindowsMediaPlayer_jingling
            // 
            this.axWindowsMediaPlayer_jingling.Enabled = true;
            this.axWindowsMediaPlayer_jingling.Location = new System.Drawing.Point(23, 202);
            this.axWindowsMediaPlayer_jingling.Name = "axWindowsMediaPlayer_jingling";
            this.axWindowsMediaPlayer_jingling.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer_jingling.OcxState")));
            this.axWindowsMediaPlayer_jingling.Size = new System.Drawing.Size(56, 33);
            this.axWindowsMediaPlayer_jingling.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Mygame.Properties.Resources.地鼠洞;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(319, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Mygame.Properties.Resources.地鼠洞;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(583, 257);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "2";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Mygame.Properties.Resources.地鼠洞;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(850, 257);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(147, 134);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "3";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Mygame.Properties.Resources.地鼠洞;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(319, 420);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(147, 134);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "4";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Mygame.Properties.Resources.地鼠洞;
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(583, 420);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(147, 134);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "5";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::Mygame.Properties.Resources.地鼠洞;
            this.pictureBox6.InitialImage = null;
            this.pictureBox6.Location = new System.Drawing.Point(850, 420);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(147, 134);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "6";
            // 
            // timer_gametime
            // 
            this.timer_gametime.Interval = 1000;
            this.timer_gametime.Tick += new System.EventHandler(this.timer_gametime_Tick);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mygame.Properties.Resources.場景;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1296, 632);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.axWindowsMediaPlayer_jingling);
            this.Controls.Add(this.axWindowsMediaPlayer_mousecrush);
            this.Controls.Add(this.axWindowsMediaPlayer_hammersound);
            this.Controls.Add(this.axWindowsMediaPlayer_backgroundmusic);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_time);
            this.DoubleBuffered = true;
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "10714D025葉宗宴";
            this.Load += new System.EventHandler(this.Form_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer_backgroundmusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer_hammersound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer_mousecrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer_jingling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Button button_Start;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer_backgroundmusic;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer_hammersound;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer_mousecrush;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer_jingling;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer_gametime;
    }
}

