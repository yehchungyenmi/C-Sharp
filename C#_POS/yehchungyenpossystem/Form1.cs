using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yehchungyenpossystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_送單_Click(object sender, EventArgs e)
        {
            int V_detail = 1;
            int V_total = 0;
            textBox_detail.Text = " detail ";
            textBox_detail.Text += "\r\n\r\n";

            if ((checkBox_beefburger.Checked) && (numericUpDown_beefburger.Value != 0))
            {
                V_detail = Convert.ToInt32(numericUpDown_beefburger.Value);
                V_total += V_detail * 65;
                textBox_detail.Text += "\r\n Beef Burger " + V_detail + "份" + "\r\n";
                textBox_detail.Text += "\r\n hot level = " + comboBoxbeef_hotlevel.Text + "\r\n";
            }
            if ((checkBox_chickenburger.Checked) && (numericUpDown_chickenburger.Value != 0))
            {
                V_detail = Convert.ToInt32(numericUpDown_chickenburger.Value);
                V_total += V_detail * 55;
                textBox_detail.Text += "\r\n chicken Burger " + V_detail + "份" + "\r\n";
                textBox_detail.Text += "\r\n hot level = " + comboBoxchicken_hotlevel.Text + "\r\n";
            }
            if ((checkBox_Bigmac.Checked) && (numericUpDown_bigmac.Value != 0))
            {
                V_detail = Convert.ToInt32(numericUpDown_bigmac.Value);
                V_total += V_detail * 75;
                textBox_detail.Text += "\r\n Big Mac " + V_detail + "份" + "\r\n";
                textBox_detail.Text += "\r\n hot level = " + comboBoxbigmac_hotlevel.Text + "\r\n";
            }
            if ((checkBox_fishburger.Checked) && (numericUpDown_fishburger.Value != 0))
            {
                V_detail = Convert.ToInt32(numericUpDown_fishburger.Value);
                V_total += V_detail * 45;
                textBox_detail.Text += "\r\n fish Burger " + V_detail + "份" + "\r\n";
                textBox_detail.Text += "\r\n hot level = " + comboBoxfish_hotlevel.Text + "\r\n";
            }

            //drink

            if (checkBox_drink.Checked)
            {
                if (radioButton_coke.Checked)
                {
                    textBox_detail.Text += "\r\n coke" + " 1 cup" + "\r\n";
                    V_total += 30;
                }
                else if (radioButton_coffee.Checked)
                {
                    textBox_detail.Text += "\r\n coffee" + " 1 cup" + "\r\n";
                    V_total += 35;
                }
                else if (radioButton_redtea.Checked)
                {
                    textBox_detail.Text += "\r\n red tea" + " 1 cup" + "\r\n";
                    V_total += 30;
                }
            }

            //french fries

            if(checkBox_french.Checked)
            {
                if(radioButton_small.Checked)
                {
                    textBox_detail.Text += "\r\n small french fries" + " 1" + "\r\n";
                    V_total += 15;
                }
                else if (radioButton_medium.Checked)
                {
                    textBox_detail.Text += "\r\n medium french fries" + " 1" + "\r\n";
                    V_total += 20;
                }
                else if (radioButton_big.Checked)
                {
                    textBox_detail.Text += "\r\n big french fries" + " 1" + "\r\n";
                    V_total += 30;
                }
            }

            //discount

            switch(listBox_discount.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    V_total = (int)(V_total * 0.9);
                    textBox_detail.Text += "\r\n discount 10% \r\n";
                    break;
                case 2:
                    V_total = (int)(V_total * 0.5);
                    textBox_detail.Text += "\r\n discount 50% \r\n";
                    break;
                case 3:
                    V_total = (int)(V_total * 0.2);
                    textBox_detail.Text += "\r\n discount 80% \r\n";
                    break;
                case 4:
                    V_total = (int)(V_total * 0);
                    textBox_detail.Text += "\r\n free \r\n";
                    break;
                default:
                    V_total = (int)(V_total * 1);
                    break;
            
            }
            label_total.Text = " total: NT $ " + V_total;
        }





        private void radioButton_coke_MouseHover(object sender, EventArgs e)
        {
            pictureBox_drink.Image = global::yehchungyenpossystem.Properties.Resources.Cola;
        }

        private void radioButton_coke_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_drink.Image = global::yehchungyenpossystem.Properties.Resources.Vegitable_and_Fruit;
        }

        private void radioButton_coffee_MouseHover(object sender, EventArgs e)
        {
            pictureBox_drink.Image = global::yehchungyenpossystem.Properties.Resources.Coffee;
        }

        private void radioButton_coffee_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_drink.Image = global::yehchungyenpossystem.Properties.Resources.Vegitable_and_Fruit;
        }

        private void radioButton_redtea_MouseHover(object sender, EventArgs e)
        {
            pictureBox_drink.Image = global::yehchungyenpossystem.Properties.Resources.Read_Tea;
        }

        private void radioButton_redtea_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_drink.Image = global::yehchungyenpossystem.Properties.Resources.Vegitable_and_Fruit;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer_datetime.Interval = 1000;
            timer_datetime.Enabled = true;
            timer_datetime.Start();

            timer_runninglight.Interval = 200;
            timer_runninglight.Enabled = true;
            timer_runninglight.Start();
        }

        private void timer_datetime_Tick(object sender, EventArgs e)
        {
            label_datetime.Text = DateTime.Now.ToString();
        }

        private void timer_runninglight_Tick(object sender, EventArgs e)
        {
            if (label_runninglight.Left <= 450)
                label_runninglight.Left += 10;
            else
                label_runninglight.Left = 250;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //topic
            Graphics prngraph = e.Graphics;
            prngraph.DrawImage(global::yehchungyenpossystem.Properties.Resources.hamburger, 0, 0, 850, 1200);
            Font V_topicfont = new Font(textBox_detail.Font.Name, textBox_detail.Font.Size * 2, textBox_detail.Font.Style);
            SolidBrush V_topicbrush = new SolidBrush(textBox_detail.ForeColor);
            Single V_left = printDocument1.DefaultPageSettings.Margins.Left + 150;
            Single V_top = printDocument1.DefaultPageSettings.Margins.Top;
            prngraph.DrawString("yehchungyen restaurant", V_topicfont, V_topicbrush, V_left, V_top);
            //detail
            Font V_detailfont = new Font(textBox_detail.Font.Name, textBox_detail.Font.Size, textBox_detail.Font.Style);
            SolidBrush V_detailbrush = new SolidBrush(Color.LightGreen);
            Single V_leftdetail = printDocument1.DefaultPageSettings.Margins.Left + 250;
            Single V_topdetail = printDocument1.DefaultPageSettings.Margins.Top + 50;
            prngraph.DrawString(textBox_detail.Text, V_detailfont, V_detailbrush, V_leftdetail, V_topdetail);
            prngraph.DrawString("total = " + label_total.Text, V_detailfont, V_detailbrush, 100, 1000);
            prngraph.DrawString(label_datetime.Text.ToString(), V_detailfont, V_detailbrush, 600, 1000);
            prngraph.DrawImage(global::yehchungyenpossystem.Properties.Resources.Read_Tea, 600, 800);
          
            


        }

        private void button_列印收據_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void button_print_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }
    }
}
