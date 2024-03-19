using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yehchungyenprogram
{
    public partial class Form1 : Form
    {
        
        public Image My_Picture = Image.FromFile("donald trump.jpg");
        public cust 葉宗宴;
        public Form1()
        {
            InitializeComponent();
        }
        Color Save_color;
        public DIM Dim_Student;
        const int Number_Student_Class = 50;
        public static DIM[] 資管班 = new DIM[Number_Student_Class];
        public void Add_To_List()
        {
            string space = " ";
            listBox_資管班.Items.Add
                (
                Dim_Student.ID 
                + space + Dim_Student.Name 
                + space + Dim_Student.Department
                + space + Dim_Student.Gender
                + space + Dim_Student.My_Year_Status
                + space + Dim_Student.Status
                + space + Dim_Student.Student_Score.Chinese
                + space + Dim_Student.Student_Score.English
                + space + Dim_Student.Student_Score.Mathmatic
                );
            pictureBox1.Image = Dim_Student.Obj_picture;
        }
        public void Show_DIM_Student_Information(DIM Student)
        {
            textBox1.Text = "DIM Student Information" + "\r\n" + "\r\n";
            textBox1.Text += "ID : " + Student.ID + "\r\n";
            textBox1.Text += "Name : " + Student.Name + "\r\n";
            textBox1.Text += "Department : " + Student.Department + "\r\n";
            textBox1.Text += "Gender : " + Student.Gender + "\r\n";
            textBox1.Text += "Year Status : " + Student.My_Year_Status + "\r\n";
            textBox1.Text += "Status : " + Student.Status + "\r\n" +"\r\n" ;
            textBox1.Text += "Score" + "\r\n" + "\r\n";
            textBox1.Text += "English : " + Student.Student_Score.English + "\r\n";
            textBox1.Text += "Chinese : " + Student.Student_Score.Chinese + "\r\n";
            textBox1.Text += "Mathmatic : " + Student.Student_Score.Mathmatic + "\r\n";
            textBox1.Text += "Average : " + Student.Student_Score.Get_averge().ToString() + "\r\n";
            textBox_平均成績.Text = Student.Student_Score.Get_averge().ToString();
            pictureBox1.Image = Student.Obj_picture;

        }
        public class Score
        {
            public uint Chinese = 0;
            public uint English = 0;
            public uint Mathmatic = 0;
            public uint Get_averge()
            {
                return (Chinese + English + Mathmatic) / 3;
            }
            public void Set_Score(uint C,uint E,uint M)
            {
                Chinese = C;
                English = E;
                Mathmatic = M;
            }
        }
        public class DIM : cust
        {
            public Score Student_Score = new Score();
            public static int Student_Count = 0;

            public DIM(string ID,string Name,string Department,string Gender,uint Year_Status, CUST_Status My_Status, Image New_Picture,uint Chinese, uint English,uint Mathmatic):
                base(ID, Name, Department, Gender, Year_Status, My_Status, New_Picture)
            {
                this.Student_Score.Chinese = Chinese;
                this.Student_Score.English = English;
                this.Student_Score.Mathmatic = Mathmatic;
            }
            public DIM(string ID, string Name, string Department, string Gender, uint Year_Status, CUST_Status My_Status, Image New_Picture) :
                base(ID, Name, Department, Gender, Year_Status, My_Status, New_Picture)
            {

            }
            public override void Public_Announcement()
            {
                MessageBox.Show("message from DIM");
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Save_color = textBox_中文成積.BackColor;
            葉宗宴 = new cust("10714025", "葉宗宴", "資管系", "male",1, CUST_Status.Student, My_Picture);
            cust.Add_people();
            textBox_中華人數.Text = cust.count.ToString();
            timer1.Interval = 200;
            timer1.Enabled = true;
            timer1.Start();

        }
        public bool Score_Check()
        {
            int 中文成績 = 0;
            int 英文成績 = 0;
            int 數學成績 = 0;
            try
            {
                數學成績 = Convert.ToInt32(textBox_數學成績.Text);
                if ((數學成績 > 100) || (數學成績 < 0))
                {
                    textBox_數學成績.BackColor = Color.Red;
                    MessageBox.Show("請重新輸入數學成績");
                    return false;
                }
                中文成績 = Convert.ToInt32(textBox_中文成積.Text);
                if ((中文成績 > 100) || (中文成績 < 0))
                {
                    textBox_中文成積.BackColor = Color.Red;
                    MessageBox.Show("請重新輸入中文成績");
                    return false;
                }
                英文成績 = Convert.ToInt32(textBox_英文成績.Text);
                if ((英文成績 > 100) || (英文成績 < 0))
                {
                    textBox_數學成績.BackColor = Color.Red;
                    MessageBox.Show("請重新輸入英文成績");
                    return false;
                }
                return true;
            }
            catch
            {
                MessageBox.Show("請重新輸入成績!");
                return false;
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button_輸入資管人_Click(object sender, EventArgs e)
        {
            textBox_中文成積.BackColor = Save_color;
            textBox_英文成績.BackColor = Save_color;
            textBox_數學成績.BackColor = Save_color;
            try
            {
                string ID = textBox_編號.Text;
                string Name = textBox_姓名.Text;
                string Department = textBox_部門.Text;
                CUST_Status Status = cust.Get_Status(textBox_狀況.Text);
                uint Year_Status = Convert.ToUInt32(textBox_年資.Text);
                string File_My_Picture = ("donald trump.jpg");
                Image New_Student_Picture;
                string Gender = comboBox_性別.Text;
                int i =0;
                if (Score_Check())
                {
                    if ((Status == CUST_Status.Student) && ((Department == "DIM") || (Department == "資管系")))
                    {
                        MessageBox.Show("請學生輸入照片");
                        if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            File_My_Picture = openFileDialog1.FileName;
                        }
                        New_Student_Picture = Image.FromFile(File_My_Picture);
                        Dim_Student = new DIM(ID, Name, Department, Gender, Year_Status, Status, New_Student_Picture,
                            Convert.ToUInt32(textBox_中文成積.Text), Convert.ToUInt32(textBox_英文成績.Text), Convert.ToUInt32(textBox_數學成績.Text));
                        資管班[DIM.Student_Count] = Dim_Student;
                        Add_To_List();
                        Show_DIM_Student_Information(Dim_Student);

                        DIM.Student_Count++;
                        textBox_資管人數.Text = DIM.Student_Count.ToString();
                        cust.Add_people();
                        textBox_中華人數.Text = cust.count.ToString();
                    }
                    else MessageBox.Show("非資管學生!");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Something Is Wrong !" + EX.ToString());
            }
        }

        private void textBox_狀況_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox_資管班_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button_顯示資訊_Click(object sender, EventArgs e)
        {
            string Student_Info = listBox_資管班.Text;
            try
            {
                String[] data = Student_Info.Split();
                for(int i = 0; i < DIM.Student_Count;i++)
                {
                    if(資管班[i].ID == data[0])
                    {
                        Show_DIM_Student_Information(資管班[i]);
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("please select student !");
            }
        }

        private void button_刪除_Click(object sender, EventArgs e)
        {

            string Student_Info = listBox_資管班.Text;
            listBox_資管班.Items.RemoveAt(listBox_資管班.SelectedIndex);
            try
            {
                String[] data = Student_Info.Split();
                for (int i = 0; i < DIM.Student_Count; i++)
                {
                    if (資管班[i].ID == data[0])
                    {
                        for(int J = i+1;J<DIM.Student_Count;J++)
                        {
                            資管班[i] = 資管班[J];
                            i++; 
                        }
                        
                        DIM.Student_Count--;
                        textBox_資管人數.Text = DIM.Student_Count.ToString();
                        cust.count--;
                        textBox_中華人數.Text = cust.count.ToString();
                        
                        
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("please select student !");
            }
        }

        private void button_顯示資管人畫面_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label_runninglight.Left <= 1024)
                label_runninglight.Left += 10;
            else
                label_runninglight.Left = 6;
        }

        private void button_showdetail_Click(object sender, EventArgs e)
        {
            textBox1.Text = "PERSONAL DETAIL" + "\r\n" + "\r\n";
            textBox1.Text += "ID:" + 葉宗宴.ID + "\r\n" + "\r\n";
            textBox1.Text += "Name:" + 葉宗宴.Name + "\r\n" + "\r\n";
            textBox1.Text += "Gender:" + 葉宗宴.Gender + "\r\n" + "\r\n";
            textBox1.Text += "Department:" + 葉宗宴.Department + "\r\n" + "\r\n";
            textBox1.Text += "Year_Status:" + 葉宗宴.My_Year_Status + "\r\n" + "\r\n";
            textBox1.Text += "Status:" + 葉宗宴.Status.ToString() + "\r\n" + "\r\n";

            pictureBox1.Image = 葉宗宴.Obj_picture;
        }

        private void button_增加_Click(object sender, EventArgs e)
        {

        }

        private void button_website_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.cust.edu.tw/www/index.htm");
        }

        private void textBox_編號_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_virtual_test_Click(object sender, EventArgs e)
        {
            葉宗宴.Public_Announcement();
            Dim_Student.Public_Announcement();
        }

        private void button_showname_Click(object sender, EventArgs e)
        {
            葉宗宴.Show_Personal_Name(葉宗宴.Name);
        }
    }
}
