namespace KTV
{
    partial class Form_KTV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_KTV));
            this.button_播放影片 = new System.Windows.Forms.Button();
            this.button_播放音樂 = new System.Windows.Forms.Button();
            this.button_全部播放 = new System.Windows.Forms.Button();
            this.button_停止播放 = new System.Windows.Forms.Button();
            this.button_插播 = new System.Windows.Forms.Button();
            this.button_加買時數 = new System.Windows.Forms.Button();
            this.button_點餐 = new System.Windows.Forms.Button();
            this.button_加歌到歌本 = new System.Windows.Forms.Button();
            this.button_從歌本刪歌 = new System.Windows.Forms.Button();
            this.button_储存歌本 = new System.Windows.Forms.Button();
            this.button_從歌本叫出 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label_現在時間 = new System.Windows.Forms.Label();
            this.label_消費時數 = new System.Windows.Forms.Label();
            this.timer_現在時間 = new System.Windows.Forms.Timer(this.components);
            this.timer_全部撥放 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WindowsMediaPlayer_meadia_screen = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button_start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer_meadia_screen)).BeginInit();
            this.SuspendLayout();
            // 
            // button_播放影片
            // 
            this.button_播放影片.BackColor = System.Drawing.Color.Salmon;
            this.button_播放影片.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_播放影片.Location = new System.Drawing.Point(340, 15);
            this.button_播放影片.Name = "button_播放影片";
            this.button_播放影片.Size = new System.Drawing.Size(96, 45);
            this.button_播放影片.TabIndex = 1;
            this.button_播放影片.Text = "播放影片";
            this.button_播放影片.UseVisualStyleBackColor = false;
            this.button_播放影片.Click += new System.EventHandler(this.button_播放影片_Click);
            // 
            // button_播放音樂
            // 
            this.button_播放音樂.BackColor = System.Drawing.Color.Salmon;
            this.button_播放音樂.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_播放音樂.Location = new System.Drawing.Point(340, 66);
            this.button_播放音樂.Name = "button_播放音樂";
            this.button_播放音樂.Size = new System.Drawing.Size(96, 45);
            this.button_播放音樂.TabIndex = 1;
            this.button_播放音樂.Text = "播放音樂";
            this.button_播放音樂.UseVisualStyleBackColor = false;
            this.button_播放音樂.Click += new System.EventHandler(this.button_播放音樂_Click);
            // 
            // button_全部播放
            // 
            this.button_全部播放.BackColor = System.Drawing.Color.Salmon;
            this.button_全部播放.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_全部播放.Location = new System.Drawing.Point(442, 15);
            this.button_全部播放.Name = "button_全部播放";
            this.button_全部播放.Size = new System.Drawing.Size(96, 45);
            this.button_全部播放.TabIndex = 1;
            this.button_全部播放.Text = "全部播放";
            this.button_全部播放.UseVisualStyleBackColor = false;
            this.button_全部播放.Click += new System.EventHandler(this.button_全部播放_Click);
            // 
            // button_停止播放
            // 
            this.button_停止播放.BackColor = System.Drawing.Color.Salmon;
            this.button_停止播放.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold);
            this.button_停止播放.Location = new System.Drawing.Point(442, 66);
            this.button_停止播放.Name = "button_停止播放";
            this.button_停止播放.Size = new System.Drawing.Size(96, 45);
            this.button_停止播放.TabIndex = 1;
            this.button_停止播放.Text = "停止播放";
            this.button_停止播放.UseVisualStyleBackColor = false;
            this.button_停止播放.Click += new System.EventHandler(this.button_停止播放_Click);
            // 
            // button_插播
            // 
            this.button_插播.BackColor = System.Drawing.Color.Salmon;
            this.button_插播.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold);
            this.button_插播.Location = new System.Drawing.Point(340, 117);
            this.button_插播.Name = "button_插播";
            this.button_插播.Size = new System.Drawing.Size(96, 45);
            this.button_插播.TabIndex = 1;
            this.button_插播.Text = "插播";
            this.button_插播.UseVisualStyleBackColor = false;
            this.button_插播.Click += new System.EventHandler(this.button_插播_Click);
            // 
            // button_加買時數
            // 
            this.button_加買時數.BackColor = System.Drawing.Color.Salmon;
            this.button_加買時數.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold);
            this.button_加買時數.Location = new System.Drawing.Point(442, 117);
            this.button_加買時數.Name = "button_加買時數";
            this.button_加買時數.Size = new System.Drawing.Size(96, 45);
            this.button_加買時數.TabIndex = 1;
            this.button_加買時數.Text = "加買時數";
            this.button_加買時數.UseVisualStyleBackColor = false;
            this.button_加買時數.Click += new System.EventHandler(this.button_加買時數_Click);
            // 
            // button_點餐
            // 
            this.button_點餐.BackColor = System.Drawing.Color.Green;
            this.button_點餐.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold);
            this.button_點餐.Location = new System.Drawing.Point(544, 66);
            this.button_點餐.Name = "button_點餐";
            this.button_點餐.Size = new System.Drawing.Size(96, 45);
            this.button_點餐.TabIndex = 1;
            this.button_點餐.Text = "點餐";
            this.button_點餐.UseVisualStyleBackColor = false;
            this.button_點餐.Click += new System.EventHandler(this.button_點餐_Click);
            // 
            // button_加歌到歌本
            // 
            this.button_加歌到歌本.BackColor = System.Drawing.Color.Khaki;
            this.button_加歌到歌本.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold);
            this.button_加歌到歌本.Location = new System.Drawing.Point(340, 168);
            this.button_加歌到歌本.Name = "button_加歌到歌本";
            this.button_加歌到歌本.Size = new System.Drawing.Size(198, 45);
            this.button_加歌到歌本.TabIndex = 1;
            this.button_加歌到歌本.Text = "加歌到歌本";
            this.button_加歌到歌本.UseVisualStyleBackColor = false;
            this.button_加歌到歌本.Click += new System.EventHandler(this.button_加歌到歌本_Click);
            // 
            // button_從歌本刪歌
            // 
            this.button_從歌本刪歌.BackColor = System.Drawing.Color.Khaki;
            this.button_從歌本刪歌.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold);
            this.button_從歌本刪歌.Location = new System.Drawing.Point(340, 219);
            this.button_從歌本刪歌.Name = "button_從歌本刪歌";
            this.button_從歌本刪歌.Size = new System.Drawing.Size(198, 45);
            this.button_從歌本刪歌.TabIndex = 1;
            this.button_從歌本刪歌.Text = "從歌本刪歌";
            this.button_從歌本刪歌.UseVisualStyleBackColor = false;
            this.button_從歌本刪歌.Click += new System.EventHandler(this.button_從歌本刪歌_Click);
            // 
            // button_储存歌本
            // 
            this.button_储存歌本.BackColor = System.Drawing.Color.Khaki;
            this.button_储存歌本.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold);
            this.button_储存歌本.Location = new System.Drawing.Point(340, 270);
            this.button_储存歌本.Name = "button_储存歌本";
            this.button_储存歌本.Size = new System.Drawing.Size(198, 45);
            this.button_储存歌本.TabIndex = 1;
            this.button_储存歌本.Text = "储存歌本";
            this.button_储存歌本.UseVisualStyleBackColor = false;
            this.button_储存歌本.Click += new System.EventHandler(this.button_储存歌本_Click);
            // 
            // button_從歌本叫出
            // 
            this.button_從歌本叫出.BackColor = System.Drawing.Color.Khaki;
            this.button_從歌本叫出.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold);
            this.button_從歌本叫出.Location = new System.Drawing.Point(340, 321);
            this.button_從歌本叫出.Name = "button_從歌本叫出";
            this.button_從歌本叫出.Size = new System.Drawing.Size(198, 45);
            this.button_從歌本叫出.TabIndex = 1;
            this.button_從歌本叫出.Text = "從歌本叫出";
            this.button_從歌本叫出.UseVisualStyleBackColor = false;
            this.button_從歌本叫出.Click += new System.EventHandler(this.button_從歌本叫出_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Info;
            this.listBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(322, 356);
            this.listBox1.TabIndex = 2;
            // 
            // label_現在時間
            // 
            this.label_現在時間.BackColor = System.Drawing.SystemColors.Info;
            this.label_現在時間.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold);
            this.label_現在時間.Location = new System.Drawing.Point(646, 15);
            this.label_現在時間.Name = "label_現在時間";
            this.label_現在時間.Size = new System.Drawing.Size(465, 45);
            this.label_現在時間.TabIndex = 3;
            // 
            // label_消費時數
            // 
            this.label_消費時數.BackColor = System.Drawing.SystemColors.Info;
            this.label_消費時數.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold);
            this.label_消費時數.Location = new System.Drawing.Point(649, 66);
            this.label_消費時數.Name = "label_消費時數";
            this.label_消費時數.Size = new System.Drawing.Size(463, 45);
            this.label_消費時數.TabIndex = 3;
            // 
            // timer_現在時間
            // 
            this.timer_現在時間.Tick += new System.EventHandler(this.timer_現在時間_Tick);
            // 
            // timer_全部撥放
            // 
            this.timer_全部撥放.Tick += new System.EventHandler(this.timer_全部撥放_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KTV.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(340, 374);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // WindowsMediaPlayer_meadia_screen
            // 
            this.WindowsMediaPlayer_meadia_screen.Enabled = true;
            this.WindowsMediaPlayer_meadia_screen.Location = new System.Drawing.Point(544, 117);
            this.WindowsMediaPlayer_meadia_screen.Name = "WindowsMediaPlayer_meadia_screen";
            this.WindowsMediaPlayer_meadia_screen.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer_meadia_screen.OcxState")));
            this.WindowsMediaPlayer_meadia_screen.Size = new System.Drawing.Size(569, 446);
            this.WindowsMediaPlayer_meadia_screen.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(12, 382);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(322, 180);
            this.listBox2.TabIndex = 5;
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.Green;
            this.button_start.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold);
            this.button_start.Location = new System.Drawing.Point(544, 15);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(96, 45);
            this.button_start.TabIndex = 6;
            this.button_start.Text = "開始計時";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // Form_KTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KTV.Properties.Resources.karaoke_singapore;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1125, 600);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_消費時數);
            this.Controls.Add(this.label_現在時間);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_點餐);
            this.Controls.Add(this.button_從歌本叫出);
            this.Controls.Add(this.button_储存歌本);
            this.Controls.Add(this.button_從歌本刪歌);
            this.Controls.Add(this.button_加歌到歌本);
            this.Controls.Add(this.button_加買時數);
            this.Controls.Add(this.button_插播);
            this.Controls.Add(this.button_停止播放);
            this.Controls.Add(this.button_全部播放);
            this.Controls.Add(this.button_播放音樂);
            this.Controls.Add(this.button_播放影片);
            this.Controls.Add(this.WindowsMediaPlayer_meadia_screen);
            this.Name = "Form_KTV";
            this.ShowIcon = false;
            this.Text = "KTV";
            this.Load += new System.EventHandler(this.Form_KTV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer_meadia_screen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer_meadia_screen;
        private System.Windows.Forms.Button button_播放影片;
        private System.Windows.Forms.Button button_播放音樂;
        private System.Windows.Forms.Button button_全部播放;
        private System.Windows.Forms.Button button_停止播放;
        private System.Windows.Forms.Button button_插播;
        private System.Windows.Forms.Button button_加買時數;
        private System.Windows.Forms.Button button_點餐;
        private System.Windows.Forms.Button button_加歌到歌本;
        private System.Windows.Forms.Button button_從歌本刪歌;
        private System.Windows.Forms.Button button_储存歌本;
        private System.Windows.Forms.Button button_從歌本叫出;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label_現在時間;
        private System.Windows.Forms.Label label_消費時數;
        private System.Windows.Forms.Timer timer_現在時間;
        private System.Windows.Forms.Timer timer_全部撥放;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button_start;
    }
}

