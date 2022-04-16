using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notlar_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Add(textBox1.Text + "\t" + textBox2.Text); // Textboxlara yazılan bilgileri alıyoruz
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int secim = listBox1.SelectedIndex; // listboxdan eleman seç
            if(secim != -1) // != Esit degilse anlaminda. Eger secim yapilmazsa -1 degeri döner. Oradaki satir seçim yapılmış ise anlamındadır.
            {
                listBox1.Items.RemoveAt(secim); // silme komutu
            }
            else 
            {
                MessageBox.Show("Seçim Yapın ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // listbox ı temizle
        }
    }
}
