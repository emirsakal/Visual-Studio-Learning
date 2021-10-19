using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Two
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Dönüşümlerden önce Convert komutu kullanılır. Örneğin: sayi = Convert.ToInt16(textBox1.Text);
            string x = "Selam";
            int y = 24;
            double z = 8.9;
            int sayi = Convert.ToInt16(textBox1.Text); // ToInt16-32-64 arasında aralık farkı var çok büyük sayılarda 32 ve 64 kullanılıyor.
            // Double bir sayıyı klavyeden almak için Convert komutunu kullandıktan sonra toDouble() komutunu kullanıyoruz.
            char harf = 'A'; // Klavyeden alınırken toChar() kullanılır.
            byte sayicik = 124; // 0-255 arası tüm sayılar verilebilir.
            sbyte sayi1 = -128, sayi2 = 127; // -128 ile 127 arasında tutabilen byte'ın bir türü.
            short shortsayi = -32768; // Short -32768 ile +32767 arasındaki sayıları alabilir. O sayılar da dahil.
            ushort ushortsayi = 65535; // 0 ila 63535 arasındaki sayıları alır.
            float floatsayi = 2.5f; // Double ve int'in birleşimi gibidir. Double'dan daha küçük bir sayı aralığı vardır. Sonuna 'f' koymak gereklidir.
            decimal ondaliklisayi = 19.1923m; // Ondalıklı sayıların babasıdır. Double ve Float'tan çok daha yüksek (29 basamak) bir sayı aralığına sahiptir. SONUNA 'm' KOYULMALIDIR.
            bool durum = false; // bool kontrol = sayi > 20 gibi if ifadelerinde kullanılabilir. True - False olarak çıkar.

            label1.Text = x;
            label2.Text = y.ToString();
            label3.Text = z.ToString();
            label4.Text = sayi.ToString();
            label5.Text = harf.ToString();
            label6.Text = sayicik.ToString();
            label7.Text = (sayi1.ToString() + " " + sayi2.ToString());
            label8.Text = shortsayi.ToString();
            label9.Text = ushortsayi.ToString();
            label10.Text = floatsayi.ToString();
            label11.Text = ondaliklisayi.ToString();
            label12.Text = durum.ToString();
        }
    }
}
