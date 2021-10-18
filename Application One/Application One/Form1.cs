using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_One
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Text = (textBox4.Text + " " + textBox3.Text + " , " + maskedTextBox4.Text + " , " + maskedTextBox3.Text + " , Yolculuk Bilgileri: " + comboBox1.Text + " - " + comboBox2.Text + " , " + maskedTextBox2.Text + " , " + maskedTextBox1.Text);
        }
    }
}
