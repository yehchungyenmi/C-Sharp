using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using ZXing;
using System.IO;

namespace QRcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap bitmap = null;
            string content = textBox1.Text;
            try
            {
                ZXing.BarcodeWriter writer = new ZXing.BarcodeWriter
                {
                    Format = ZXing.BarcodeFormat.QR_CODE,
                    Options = new ZXing.QrCode.QrCodeEncodingOptions
                    {
                        Height = 180,
                        Width = 180,
                        CharacterSet = "UTF-8",
                        ErrorCorrection = ZXing.QrCode.Internal.ErrorCorrectionLevel.H
                    }
                };
                bitmap = writer.Write(content);
                bitmap.Save("D:\\Test\\temp.png", System.Drawing.Imaging.ImageFormat.Png);
                pictureBox1.Image = bitmap;
            }
            catch (Exception EX)
            {
                MessageBox.Show("Something Is Wrong !" + EX.ToString());
            }


        }

        private void button_decode_Click(object sender, EventArgs e)
        {
            
            System.Drawing.Bitmap bitmap = null;
   
            ZXing.IBarcodeReader reader = new ZXing.BarcodeReader();


            FileStream fs = new FileStream("D:\\Test\\temp.png", FileMode.Open);
            Byte[] data = new Byte[fs.Length];       
            fs.Read(data, 0, data.Length);
            fs.Close();
            MemoryStream ms = new MemoryStream(data);
            bitmap = (Bitmap)Image.FromStream(ms);
            pictureBox2.Image = bitmap;
            ZXing.Result result = reader.Decode(bitmap);
            if (result != null)
           
                textBox2.Text = result.Text;
            }
        }


    }


