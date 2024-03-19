using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Mygame
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }
        const int six = 6;
        int V_亂樹種子 = (int)DateTime.Now.Ticks;
        Random V_亂數;
        PictureBox[] pic_圖片盒子陣列 = new PictureBox[six];
        Timer[] timer_控制何時顯示地鼠陣列 = new Timer[six];   // 還有精靈
        Timer[] timer_控制何時隱藏地鼠陣列 = new Timer[six];
        int V_分數;
        bool[] A_紀錄地鼠是否出洞陣列 = new bool[six];
        bool[] A_紀錄是否是精靈陣列 = new bool[six];
        int V_遊戲時間;

        private void Form_main_Load(object sender, EventArgs e)
        {
            V_亂數 = new Random(V_亂樹種子);
            axWindowsMediaPlayer_backgroundmusic.settings.playCount = 99;
            axWindowsMediaPlayer_backgroundmusic.settings.volume = 50;
            //URL = "music.mp3";
            axWindowsMediaPlayer_backgroundmusic.URL = "Test.mp3";
            axWindowsMediaPlayer_backgroundmusic.Ctlcontrols.stop();
            axWindowsMediaPlayer_backgroundmusic.Visible = false;

            axWindowsMediaPlayer_hammersound.settings.playCount = 99;
            axWindowsMediaPlayer_hammersound.settings.volume = 50;
            axWindowsMediaPlayer_hammersound.URL = "hammer.mp3";
            axWindowsMediaPlayer_hammersound.Ctlcontrols.stop();
            axWindowsMediaPlayer_hammersound.Visible = false;

            axWindowsMediaPlayer_mousecrush.settings.playCount = 99;
            axWindowsMediaPlayer_mousecrush.settings.volume = 50;
            axWindowsMediaPlayer_mousecrush.URL = "hit.mp3";
            axWindowsMediaPlayer_mousecrush.Ctlcontrols.stop();
            axWindowsMediaPlayer_mousecrush.Visible = false;

            axWindowsMediaPlayer_jingling.settings.playCount = 99;
            axWindowsMediaPlayer_jingling.settings.volume = 50;
            axWindowsMediaPlayer_jingling.URL = "lose.mp3";
            axWindowsMediaPlayer_jingling.Ctlcontrols.stop();
            axWindowsMediaPlayer_jingling.Visible = false;

            pic_圖片盒子陣列[0] = pictureBox1;
            pic_圖片盒子陣列[1] = pictureBox2;
            pic_圖片盒子陣列[2] = pictureBox3;
            pic_圖片盒子陣列[3] = pictureBox4;
            pic_圖片盒子陣列[4] = pictureBox5;
            pic_圖片盒子陣列[5] = pictureBox6;

            for(int i =0; i <= six - 1; i++)
            {
                int p = V_亂數.Next(0, six);
                if (p == six - 1)
                    A_紀錄是否是精靈陣列[i] = true;
                else
                    A_紀錄是否是精靈陣列[i] = false;
                pic_圖片盒子陣列[i].Image = Image.FromFile("地鼠洞.png");
                A_紀錄地鼠是否出洞陣列[i] = false;
                pic_圖片盒子陣列[i].Tag = i;
                pic_圖片盒子陣列[i].BackColor = Color.Transparent;
            }
            for(int i=0; i<= six - 1;i++)
            {
                timer_控制何時顯示地鼠陣列[i] = new Timer();
                timer_控制何時隱藏地鼠陣列[i] = new Timer();
                int n = V_亂數.Next(1000, 5000);
                timer_控制何時顯示地鼠陣列[i].Interval = n;
                timer_控制何時顯示地鼠陣列[i].Tag = i;
                timer_控制何時隱藏地鼠陣列[i].Tag = i;

                this.timer_控制何時顯示地鼠陣列[i].Tick += new EventHandler(timer_控制何時顯示地鼠陣列_Tick);
                this.timer_控制何時隱藏地鼠陣列[i].Tick += new EventHandler(timer_控制何時隱藏地鼠陣列_Tick);
            }
        }
        private void timer_控制何時隱藏地鼠陣列_Tick(object sender, EventArgs e)
        {
            Timer t = (Timer)sender;
            int i = (int)t.Tag;
            A_紀錄地鼠是否出洞陣列[i] = false;
            pic_圖片盒子陣列[i].Image = Image.FromFile("地鼠洞.png");
            int n = V_亂數.Next(200, 2000);
            timer_控制何時顯示地鼠陣列[i].Interval = n;
            timer_控制何時顯示地鼠陣列[i].Start();
            timer_控制何時隱藏地鼠陣列[i].Stop();
            int p = V_亂數.Next(0, 6);
            if (p == 5)
                A_紀錄是否是精靈陣列[i] = true;
            else
                A_紀錄是否是精靈陣列[i] = false;
        }
        private void timer_控制何時顯示地鼠陣列_Tick(object sender, EventArgs e)
        {
            Timer t = (Timer)sender;
            int i = (int)t.Tag;
            if (A_紀錄是否是精靈陣列[i] == true)
                pic_圖片盒子陣列[i].Image = Image.FromFile("精靈.png");
            else
                pic_圖片盒子陣列[i].Image = Image.FromFile("地鼠.png");
            A_紀錄地鼠是否出洞陣列[i] = true;
            timer_控制何時顯示地鼠陣列[i].Stop();
            int n = V_亂數.Next(200, 2000);
            timer_控制何時隱藏地鼠陣列[i].Interval = n;
            timer_控制何時隱藏地鼠陣列[i].Start();
        }
        private void timer_gametime_Tick(object sender, EventArgs e)
        {
            V_遊戲時間--;
            label_time.Text = V_遊戲時間.ToString();
                if ( V_遊戲時間 == 0)
            {
                for (int i = 0 ; i <= six - 1; i++)
                {
                    timer_控制何時顯示地鼠陣列[i].Stop();
                    timer_控制何時隱藏地鼠陣列[i].Stop();
                    pic_圖片盒子陣列[i].MouseDown -= new MouseEventHandler(pic_MouseDown_放開敲下);
                    pic_圖片盒子陣列[i].MouseDown -= new MouseEventHandler(pic_MouseUp_放開鐵鎚);
                    pic_圖片盒子陣列[i].Image = Image.FromFile("地鼠洞.png");
                    A_紀錄地鼠是否出洞陣列[i] = false;
                }
                axWindowsMediaPlayer_backgroundmusic.Ctlcontrols.stop();
                timer_gametime.Stop();
                this.Cursor = Cursors.Default;
                button_Start.Text = "Play Again ?";
                button_Start.Enabled = true;
            }
        }
        private void pic_MouseUp_放開鐵鎚(object sender, MouseEventArgs e)
        {
            this.Cursor = new Cursor("鎚子1.ico");
        }
        private void pic_MouseDown_放開敲下(object sender, MouseEventArgs e)
        {
            this.Cursor = new Cursor("鎚子2.ico");
            PictureBox V_圖片盒子 = (PictureBox)sender;
            int i = (int)V_圖片盒子.Tag;
            axWindowsMediaPlayer_hammersound.Ctlcontrols.play();

            if(A_紀錄地鼠是否出洞陣列[i] == true)
            {
                if(A_紀錄是否是精靈陣列[i] == true)
                {
                    axWindowsMediaPlayer_mousecrush.Ctlcontrols.play();
                    V_分數 -= 50;
                    if (V_分數 < 0)
                        V_分數 = 0; 
                }
                else
                {
                    axWindowsMediaPlayer_mousecrush.Ctlcontrols.play();
                    V_分數 += 10;
                }
                V_圖片盒子.Image = Image.FromFile("地鼠洞.png");
                label_score.Text = V_分數.ToString();
                timer_控制何時顯示地鼠陣列[i].Start();
                timer_控制何時隱藏地鼠陣列[i].Start();
                int p = V_亂數.Next(0, six);
                if (p == six - 1)
                    A_紀錄是否是精靈陣列[i] = true;
                else
                    A_紀錄是否是精靈陣列[i] = false;
            }
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            for(int i=0; i <= six -1 ; i++)
            {
                pic_圖片盒子陣列[i].MouseDown += new MouseEventHandler(pic_MouseDown_放開敲下);
                pic_圖片盒子陣列[i].MouseUp += new MouseEventHandler(pic_MouseUp_放開鐵鎚);
                timer_控制何時顯示地鼠陣列[i].Start();
                
            }
            axWindowsMediaPlayer_backgroundmusic.Ctlcontrols.play();
            timer_gametime.Start();
            V_遊戲時間 = 60;
            V_分數 = 0;
            label_time.Text = V_遊戲時間.ToString();
            label_score.Text = V_分數.ToString();
            button_Start.Text = "Game Started...";
            button_Start.Enabled = false;
            this.Cursor = new Cursor("鎚子1.ico");
        }
    }
}
