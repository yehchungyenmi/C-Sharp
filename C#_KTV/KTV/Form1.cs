using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTV
{
    public partial class Form_KTV : Form
    {
        public Form_KTV()
        {
            InitializeComponent();
        }

        DateTime T_start;
        DateTime T_End;

        private void button_從歌本刪歌_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("No Song Selected");
            }
        }

        private void button_從歌本叫出_Click(object sender, EventArgs e)
        {
            StreamReader sr;
            string Read_File_Name = "";
            try
            {
                //if(listBox1.items.count = 0)
                //MessageBoxButtons.YesNo.ToString("清單上還有歌");
                if (listBox1.Items.Count != 0)
                    listBox1.Items.Clear();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    Read_File_Name = openFileDialog1.FileName;
                else
                    Read_File_Name = "My Music";
                sr = new StreamReader(Read_File_Name);
                while (!sr.EndOfStream)
                {
                    listBox1.Items.Add(sr.ReadLine());
                }
                sr.Close();
                listBox1.SelectedIndex = 0;
            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }

        private void button_播放影片_Click(object sender, EventArgs e)
        {
            try
            {
                WindowsMediaPlayer_meadia_screen.settings.playCount = 1;
                WindowsMediaPlayer_meadia_screen.settings.volume = 50;
                WindowsMediaPlayer_meadia_screen.Visible = true;
                WindowsMediaPlayer_meadia_screen.uiMode = "full";

                WindowsMediaPlayer_meadia_screen.URL = @"郭忠祐『求婚』官方完整版MV.mp4";

                WindowsMediaPlayer_meadia_screen.Ctlcontrols.stop();
                WindowsMediaPlayer_meadia_screen.Ctlcontrols.play();
                timer_全部撥放.Enabled = false;
            }
            catch
            {
                MessageBox.Show("no movie available");
            }
        }

        private void Form_KTV_Load(object sender, EventArgs e)
        {
            
        }

        private void Stop_all_process()
        {
            timer_現在時間.Stop();
            timer_全部撥放.Stop();
            timer_現在時間.Enabled = false;
            timer_全部撥放.Enabled = false;
            button_播放音樂.Enabled = false;
            button_插播.Enabled = false;
            button_全部播放.Enabled = false;
            button_停止播放.Enabled = false;
            button_播放影片.Enabled = false;
            button_加歌到歌本.Enabled = false;
            button_從歌本刪歌.Enabled = false;
            button_從歌本叫出.Enabled = false;
            button_储存歌本.Enabled = false;
            button_點餐.Enabled = false;
        }

        private void timer_現在時間_Tick(object sender, EventArgs e)
        {
            label_現在時間.Text = DateTime.Now.ToString();
            if (DateTime.Compare(T_End, DateTime.Now) < 0) 
            {
                label_消費時數.BackColor = Color.Red;
                label_消費時數.Text = "your time is up, thank for coming !";
                //MessageBox.Show("time's up !");
                WindowsMediaPlayer_meadia_screen.Ctlcontrols.stop();
                Stop_all_process();
                button_加買時數.Enabled = true;
            }
        }

        private void button_點餐_Click(object sender, EventArgs e)
        {
            yehchungyenpossystem.Form1 My_form = new yehchungyenpossystem.Form1();
            My_form.Show();
        }

        private void restart_all_process()
        {
            timer_現在時間.Enabled = true;
            timer_現在時間.Interval = 1000;
            timer_現在時間.Start();
            timer_全部撥放.Enabled = true;
            timer_全部撥放.Interval = 5000;
            button_加買時數.Enabled = false;
            T_start = DateTime.Now;
            T_End = T_start.AddMinutes(180);
            label_消費時數.Text = "開始消費時間 " + T_start.ToString() + " 消費結束時間 =  " + T_End.ToString();
            label_現在時間.Text = DateTime.Now.ToString();
            button_播放音樂.Enabled = true;
            button_插播.Enabled = true;
            button_全部播放.Enabled = true;
            button_停止播放.Enabled = true;
            button_播放影片.Enabled = true;
            button_加歌到歌本.Enabled = true;
            button_從歌本刪歌.Enabled = true;
            button_從歌本叫出.Enabled = true;
            button_储存歌本.Enabled = true;
            button_點餐.Enabled = true;
            button_加買時數.Enabled = false;
        }

        private void button_加買時數_Click(object sender, EventArgs e)
        {
            restart_all_process();
            label_消費時數.BackColor = Color.Green;
            listBox2.Text = "start" + T_start + "end" + T_End + "time left";
        }

        private void button_插播_Click(object sender, EventArgs e)
        {
            timer_全部撥放.Enabled = false;
            string File_My_music = "";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File_My_music = openFileDialog1.FileName;
            }
            WindowsMediaPlayer_meadia_screen.settings.playCount = 1;
            WindowsMediaPlayer_meadia_screen.settings.volume = 50;
            WindowsMediaPlayer_meadia_screen.Visible = true;
            WindowsMediaPlayer_meadia_screen.uiMode = "full";

            WindowsMediaPlayer_meadia_screen.URL = @File_My_music;

            WindowsMediaPlayer_meadia_screen.Ctlcontrols.stop();
            WindowsMediaPlayer_meadia_screen.Ctlcontrols.play();
        }

        private void button_储存歌本_Click(object sender, EventArgs e)
        {
            StreamWriter sw;
            listBox1.SelectedIndex = 0;
            string Save_File_Name = "";
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Save_File_Name = saveFileDialog1.FileName;
                }
                sw = new StreamWriter(Save_File_Name, false);


                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    sw.WriteLine(listBox1.Text);
                    //sw.WriteLine(ListBox_class_C.GetItemIndex(i)); only get index number
                    try
                    {
                        listBox1.SelectedIndex++;
                    }
                    catch
                    { }
                }
                sw.Close();
            }
            catch
            {
                MessageBox.Show("song book not save yet !");
            }
            
           
        }

        private void button_加歌到歌本_Click(object sender, EventArgs e)
        {
            string File_My_Music = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File_My_Music = openFileDialog1.FileName;
                listBox1.Items.Add(File_My_Music);
            }
        }

        private void button_播放音樂_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
                MessageBox.Show("there's no song to play");
            else               
            timer_全部撥放.Enabled = false;
            WindowsMediaPlayer_meadia_screen.settings.playCount = 1;
            WindowsMediaPlayer_meadia_screen.settings.volume = 50;
            WindowsMediaPlayer_meadia_screen.Visible = true;
            WindowsMediaPlayer_meadia_screen.uiMode = "full";

            WindowsMediaPlayer_meadia_screen.URL = listBox1.Text;

            WindowsMediaPlayer_meadia_screen.Ctlcontrols.stop();
            WindowsMediaPlayer_meadia_screen.Ctlcontrols.play();
            timer_全部撥放.Enabled = false;
        }

        private void button_全部播放_Click(object sender, EventArgs e)
        {
            timer_全部撥放.Interval = 5000;
            timer_全部撥放.Enabled = true;
            timer_全部撥放.Start();

            WindowsMediaPlayer_meadia_screen.settings.playCount = 1;
            WindowsMediaPlayer_meadia_screen.settings.volume = 50;
           

            WindowsMediaPlayer_meadia_screen.URL = listBox1.Text;

            WindowsMediaPlayer_meadia_screen.Ctlcontrols.stop();
            WindowsMediaPlayer_meadia_screen.Ctlcontrols.play();
            
        }

        private void timer_全部撥放_Tick(object sender, EventArgs e)
        {
            if (WindowsMediaPlayer_meadia_screen.status == "已停止")
            {
                if (listBox1.SelectedIndex < (listBox1.Items.Count - 1))
                    listBox1.SelectedIndex++;
                else listBox1.SelectedIndex = 0;
                if (DateTime.Compare(T_End, DateTime.Now) < 0)
                {
                    WindowsMediaPlayer_meadia_screen.Ctlcontrols.stop();
                    Stop_all_process();
                }
                else
                    button_全部播放_Click(sender, e);
            }
        }

        private void button_停止播放_Click(object sender, EventArgs e)
        {
            timer_全部撥放.Enabled = false;
            WindowsMediaPlayer_meadia_screen.Ctlcontrols.stop();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            timer_現在時間.Enabled = true;
            timer_現在時間.Interval = 1000;
            timer_現在時間.Start();
            timer_全部撥放.Enabled = true;
            timer_全部撥放.Interval = 5000;
            button_加買時數.Enabled = false;
            T_start = DateTime.Now;
            label_消費時數.BackColor = Color.Green;
            T_End = T_start.AddMinutes(180);
            label_消費時數.Text = "開始消費時間 " + T_start.ToString() + " 消費結束時間 =  " + T_End.ToString();
            label_現在時間.Text = DateTime.Now.ToString();
            listBox2.Text = "start" + T_start + "end" + T_End + "time left";
        }
    }
}
