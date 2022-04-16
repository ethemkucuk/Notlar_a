using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notlar_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] ögrenciler = new string[] { "Ahmet", "Mehmet", "Ayşegül", "Polat", "Elif", "Ramazan", "Rıdvan", "Büşra", "Orçun", "Buse" };

        private void button1_Click(object sender, EventArgs e)
        {

            
            for (int i = 0; i < ögrenciler.Length; i++)
            {
                listBox1.Items.Add(ögrenciler[i]);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int secim = listBox1.SelectedIndex;

            if(secim != -1)
            {
                listBox1.Items.RemoveAt(secim);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int[] sayilar = new int[30];

            for (int i = 0; i < 10; i++)
            {
                sayilar[i] = random.Next(0, 100);
                listBox2.Items.Add(sayilar[i]);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int[] sayilar2 = new int[30];
            for (int i = 0; i < 30; i++)
            {
                sayilar2[i] = rand.Next(0, 100);
            }
            Array.Sort(sayilar2); // Küçükten Büyüğe sıralar Sort

            foreach (int eleman in sayilar2)
            {
                listBox3.Items.Add(eleman);
            }
        }
        int[] ortalamalar = new int[40];
        Random rand = new Random();

        private void button6_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < ortalamalar.Length; i++)
            {
                ortalamalar[i] = rand.Next(0, 100);
                listBox4.Items.Add(ortalamalar[i]);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            for (int i = 0; i < ortalamalar.Length; i++)
            {
                if(ortalamalar[i] <= 50)
                {
                    listBox4.Items.Add(ortalamalar[i]);
                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            for(int i = 0; i < ortalamalar.Length; i++)
            {
                if(ortalamalar[i] >= 70 && ortalamalar[i] <= 85)
                {
                    listBox4.Items.Add(ortalamalar[i]);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for(int i = 0; i < ortalamalar.Length; i++)
            {
                toplam += ortalamalar[i];

            }

            int ortalama = toplam / ortalamalar.Length;
            label5.Text = "Ortalama = " + ortalama.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int yuksek = ortalamalar[0];

            for(int i = 0; i < ortalamalar.Length; i++)
            {
                if(yuksek < ortalamalar[i]) {
                    {
                        ortalamalar[i] = yuksek;
                        label5.Text = "En yüksek Değer = " + yuksek.ToString();
                    } }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int gecensayi = 0;
            for(int i = 0; i < ortalamalar.Length; i++)
            {
                if(ortalamalar[i] >= 50)
                {
                    gecensayi++;
                }
            }
            label5.Text = "Geçen Sayısı ; " + gecensayi.ToString(); 
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int kalansayi = 0;
            for(int i = 0; i < ortalamalar.Length; i++)
            {
                if(ortalamalar[i] <= 50)
                {
                    kalansayi++;
                }
                label5.Text = "Kalan Sayisi : " + kalansayi.ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int gecenler = 0;
            
            for(int i = 0; i < ortalamalar.Length; i++)
            {
                if(ortalamalar[i] >= 50)
                {
                    gecenler++;
                }
                int yüzde = (100 * gecenler) / ortalamalar.Length;
                label5.Text = "Geçenler  %" + yüzde.ToString();

            }
        }
    }
}
