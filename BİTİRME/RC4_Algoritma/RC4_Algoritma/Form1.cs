using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RC4_Algoritma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            openFileDialog1.Filter = "Image ,Text and Bitmap (jpg,txt,bmp)|*.jpg;*.txt;*.bmp;";
            DialogResult dr = openFileDialog1.ShowDialog();
            
                if (dr == DialogResult.Cancel)
                    return;
                string dosya_adı = openFileDialog1.FileName;
                try
                {

                    pictureBox1.Image = Image.FromFile(dosya_adı);
                    textBox2.Text = ImageToBase64(Image.FromFile(dosya_adı), ImageFormat.Jpeg).ToString();
                }
                catch (Exception ex)
                {
                    System.IO.StreamReader metin = new System.IO.StreamReader(dosya_adı);

                    textBox2.Text = metin.ReadToEnd();

                    metin.Close();
                }
               
        }

        public string ImageToBase64(Image image, ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
               

                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                MessageBox.Show("ŞİFRELEME ANAHTARI BOŞ GEÇİLEMEZ", "DİKKAT HATA VAR !");
            }
            else
            {
                RC4 rc4 = new RC4(textBox1.Text, textBox2.Text);
                textBox3.Text = RC4.StrToHexStr(rc4.Sifrele());
            }
        }

        public Image Base64ToImage(string base64String)
        {
            
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);

            
            ms.Write(imageBytes, 0, imageBytes.Length);

            Image image = Image.FromStream(ms);
            return image;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("ŞİFRELEME ANAHTARI BOŞ GEÇİLEMEZ", "DİKKAT HATA VAR !");
            }

            else
            {
                try
                {

                    RC4 rc4 = new RC4(textBox1.Text, textBox3.Text);
                    rc4.Text = RC4.HexStrToStr(textBox3.Text);
                    textBox2.Text = rc4.Sifrele();
                    pictureBox1.Image = Base64ToImage(textBox2.Text);
                }

                catch{

                    RC4 rc4 = new RC4(textBox1.Text, textBox3.Text);
                    rc4.Text = RC4.HexStrToStr(textBox3.Text);
                    textBox2.Text = rc4.Sifrele();
                
                
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            pictureBox1.Image = null;
        }

        public void TextToFile(string String)
        {
            saveFileDialog1.Filter = "Text (txt)|*.txt";
            DialogResult dr = saveFileDialog1.ShowDialog();

            if (dr == DialogResult.Cancel)
                return;
            string ad = saveFileDialog1.FileName;


            string icerik = String;


            
            System.IO.StreamWriter file = new System.IO.StreamWriter(ad);
            file.WriteLine(icerik);

            file.Close();
        }



        private void button5_Click(object sender, EventArgs e)
        {
            
            
            TextToFile(textBox3.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text (txt)|*.txt;";
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.Cancel)
                return;
            string ad = openFileDialog1.FileName;
                
            System.IO.StreamReader file = new System.IO.StreamReader(ad);

                textBox3.Text = file.ReadToEnd();

                file.Close();
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Text = null;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Text (txt)|*.txt;";
            DialogResult dr = openFileDialog2.ShowDialog();

            if (dr == DialogResult.Cancel)
                return;
                
                string dosya_adı = openFileDialog2.FileName;
            
                System.IO.StreamReader metin = new System.IO.StreamReader(dosya_adı);

                textBox3.Text = metin.ReadLine();

                metin.Close();

             }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("KAYDEDİLECEK BİR GÖRÜNTÜ YOK ! ", "DİKKAT HATA VAR !");
            }
            else
            {

                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";



                DialogResult sonuç = sfd.ShowDialog();

                if (sonuç == DialogResult.OK)
                {
                    pictureBox1.Image.Save(sfd.FileName);
                }
            }

        }
        }
 }

