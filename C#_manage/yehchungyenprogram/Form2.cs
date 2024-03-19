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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_顯示資管資料_Click(object sender, EventArgs e)
        {
            int x = 20; int y = 20;
            PictureBox[] Dep_Dim = new PictureBox[60];
            string Space = " ";
            for(int i=0; i<Form1.DIM.Student_Count; i++)
            {
                listBox_DIM_Student.Items.Add(
                    Form1.資管班[i].ID + Space + 
                    Form1.資管班[i].Name + Space + 
                    Form1.資管班[i].Department + Space + 
                    Form1.資管班[i].Gender + Space + 
                    Form1.資管班[i].My_Year_Status + Space + 
                    Form1.資管班[i].Status + Space + 
                    Form1.資管班[i].Student_Score.Chinese + Space + 
                    Form1.資管班[i].Student_Score.English + Space + 
                    Form1.資管班[i].Student_Score.Mathmatic);
                Dep_Dim[i] = new PictureBox();
                this.Controls.Add(Dep_Dim[i]);
                Dep_Dim[i].BorderStyle = BorderStyle.Fixed3D;
                Dep_Dim[i].Location = new Point(x, y);
                Dep_Dim[i].Size = new System.Drawing.Size(140, 140);
                Dep_Dim[i].SizeMode = PictureBoxSizeMode.StretchImage;
                Dep_Dim[i].Image = Form1.資管班[i].Obj_picture;
                Dep_Dim[i].Visible = true;
                Dep_Dim[i].Focus();
                x += 180;
                if(x>=(Form2.ActiveForm.Bounds.Width -500))
                {
                    y += 180;
                    x = 20;
                }
            }
        }
    }
}
