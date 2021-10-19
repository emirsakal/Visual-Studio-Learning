using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Three
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize = 0, final = 0, quiz = 0, ort, kontrol = 0;
            string cinsiyet, ad, soyad, sinif;

            vize = Convert.ToInt16(textBox3.Text);
            final = Convert.ToInt16(textBox4.Text);
            quiz = Convert.ToInt16(textBox5.Text);

            if (vize > 100 || vize < 0 || final > 100 || final < 0 || quiz < 0 || quiz > 100)
            {
                kontrol = 1;
                vize = 0;
                final = 0;
                quiz = 0;
            }

            ort = (vize + final + quiz) / 3;
            cinsiyet = "Unknown";

            label10.Text = ort.ToString();
            if (kontrol == 1)
            {
                label11.Text = "GEÇERSİZ PUAN GİRİŞİ";
            }
            else if (ort >= 50 && ort <= 100)
            {
                label11.Text = "GEÇTİ";
            }
            else if (ort < 50 && ort >= 0)
            {
                label11.Text = "GEÇEMEDİ";
            }

            if(radioButton1.Checked == true)
            {
                cinsiyet = "Erkek";
            }
            else if(radioButton2.Checked == true)
            {
                cinsiyet = "Kadın";
            }

            ad = textBox1.Text;
            soyad = textBox2.Text;

            if (comboBox1.Text == "1. Sınıf" || comboBox1.Text == "2. Sınıf" || comboBox1.Text == "3. Sınıf" || comboBox1.Text == "4.Sınıf")
            {
                sinif = comboBox1.Text;
            }
            else
            {
                sinif = "GEÇERSİZ SINIF.";
            }

            listBox1.Items.Add(ad + " , " + soyad + " , " + cinsiyet + " , " + sinif + " , " + ort.ToString() + " , " + label11.Text);
        }
    }
}
