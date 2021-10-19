using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Four
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(textBox1.Text);
            label3.Text = "";

            if( sayi == 0 || sayi == 1 )
            {
                label3.Text = "Asal Sayı Değildir.";
            }
            else
            {
                for (int i = 2; i <= sayi / 2; i++)
                {
                    if (sayi % i == 0)
                    {
                        label3.Text = "Asal Sayı Değildir.";
                        return;
                    }
                }
                AsalSayılar.Items.Add(sayi.ToString());
                label3.Text = "Asal Sayıdır.";
            }
        }
    }
}
