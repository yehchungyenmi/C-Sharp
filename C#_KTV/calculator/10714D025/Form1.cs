using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10714D025
{
    public partial class Form_my_calculator : Form
    {
        double V_運算元1;
        string V_運算子;
        public Form_my_calculator()
        {
            InitializeComponent();
        }

        private void Form_my_calculator_Load(object sender, EventArgs e)
        {

        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if (label_機算機螢幕.Text == "0")
            {
                label_機算機螢幕.Text = "";
            }
            label_機算機螢幕.Text += ((Button)sender).Text;
        }

        private void button_加_Click(object sender, EventArgs e)
        {
            V_運算元1 = double.Parse(label_機算機螢幕.Text);
            label_機算機螢幕.Text = "0";
            V_運算子 = ((Button)sender).Tag.ToString();
        }
        public double M_累加函數()
        {
            double V_累加值 = 0;
            double V_運算元2 = double.Parse(label_機算機螢幕.Text);
            for (double i = V_運算元1; i <= V_運算元2; i++)
            {
                V_累加值 = V_累加值 + i;
            }
            return V_累加值;
        }
        private double M_階乘函數()
        {
            double V_階乘數 = 0;
            V_階乘數 = double.Parse(label_機算機螢幕.Text);
            // or V_階乘數 = V_運算元1;
            double V_階乘直 = (int)V_階乘數;

            while (V_階乘數 > 1)
            {
                V_階乘數 = V_階乘數 - 1;
                V_階乘直 = V_階乘直 * (V_階乘數);

            }
            return V_階乘直;
        }
        private void button_等於_Click(object sender, EventArgs e)
        {
            double V_院算元2 = double.Parse(label_機算機螢幕.Text);
            double V_答案 = 0;
            switch (V_運算子)
            {
                case "+":
                    V_答案 = V_運算元1 + V_院算元2;
                    break;
                case "-":
                    V_答案 = V_運算元1 - V_院算元2;
                    break;
                case "*":
                    V_答案 = V_運算元1 * V_院算元2;
                    break;
                case "/":
                    V_答案 = V_運算元1 / V_院算元2;
                    break;
                case "累加":
                    V_答案 = M_累加函數();
                    break;
                case "階乘":
                    V_答案 = M_階乘函數();
                    break;
                case "開根號":
                    V_答案 = Math.Sqrt(V_運算元1);
                    break;
                case "乘冪數":
                    V_答案 = Math.Pow(V_運算元1, V_院算元2);
                    break;
                case "%":
                    V_答案 = V_運算元1 / 100;
                    break;
                default:
                    break;
            }
            label_機算機螢幕.Text = V_答案.ToString();
            V_運算元1 = V_答案;   
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            label_機算機螢幕.Text = "0";
            V_運算元1 = 0;
            V_運算子 = "";
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            if (label_機算機螢幕.Text.IndexOf(".") < 0);
            {
                label_機算機螢幕.Text = label_機算機螢幕.Text + ".";
            }

        }

        private void button_正負建_Click(object sender, EventArgs e)
        {
            if (double.Parse(label_機算機螢幕.Text) != 0)
            {
                if (label_機算機螢幕.Text.IndexOf("-") >= 0)
                {
                    label_機算機螢幕.Text = label_機算機螢幕.Text.Replace("-", "");
                }
                else
                {
                    label_機算機螢幕.Text = "-" + label_機算機螢幕.Text;
                }
            }
        }

        private void button_退回_Click(object sender, EventArgs e)
        {
            string V_計算機螢幕數字 = label_機算機螢幕.Text;
            if ((Convert.ToDouble(label_機算機螢幕.Text)) < 0.0 && (V_計算機螢幕數字.Length == 2))
                label_機算機螢幕.Text = "0";
            else if(V_計算機螢幕數字.Length > 1)
            {
                label_機算機螢幕.Text = V_計算機螢幕數字.Substring(0, V_計算機螢幕數字.Length - 1);
            }
            else
            {
                label_機算機螢幕.Text = "0";
            }
        }

        private void button_階乘_Click(object sender, EventArgs e)
        {
            V_運算元1 = double.Parse(label_機算機螢幕.Text);

            V_運算子 = ((Button)sender).Tag.ToString();
        }

        private void button_開根號_Click(object sender, EventArgs e)
        {
            V_運算元1 = double.Parse(label_機算機螢幕.Text);

            V_運算子 = ((Button)sender).Tag.ToString();

        }

        private void button_乘冪數_Click(object sender, EventArgs e)
        {
            V_運算元1 = double.Parse(label_機算機螢幕.Text);
            label_機算機螢幕.Text = "0";
            V_運算子 = ((Button)sender).Tag.ToString();
        }

 

        private void button1_Click(object sender, EventArgs e)
        {
            V_運算元1 = double.Parse(label_機算機螢幕.Text);

            V_運算子 = ((Button)sender).Tag.ToString();
            
        }
    }
}
