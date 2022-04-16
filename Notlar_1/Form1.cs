using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notlar_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int sayi1 = Convert.ToInt32(textBox1.Text); //textbox a yazılan değeri sayi1 olarak alıyoruz.
            int sayi2 = Convert.ToInt32(textBox2.Text); //textbox a yazılan değeri sayi2 olarak alıyoruz.
            int max = sayi1 * sayi2; // Ebob ve ekok hesaplanırken yardımcı olacak bir deger yazıyoruz.
            int ekok = 0; // Olası bir hata çıkmaması için başlangıç değerlerini 0 alıyoruz.
            int ebob = 0;

            for(int i = max; i>0; i--) // maximum değer ile başlatıyoruz ve döngüyü 1 er 1 er azaltıyoruz
            {
                if(i % sayi1 == 0 && i % sayi2 == 0) // iki sayıyı da max değere bölüyoruz ve tam bölen değerleri ekok olarak alıyoruz.
                { //not: max değerden 1 er 1 er azaltarak tüm sayıları bölüyoruz ve bu şekilde en küçük ortak katı tespit ediyoruz. 
                    ekok = i; 
                }// no2: && işareti(ve) 1. ve 2. sayı bölündüğü an yani her iki sayıyı da bölen sayıları alan bir operatördür.
            }

            for(int i = 1; i < max; i++) //iki sayının en küçük ortak katı 1 olmak zorundadır.Döngü 1 den başlar, iki sayının çarpımına gelene kadar sayıyı bir bir arttırır.
            {
                if(sayi1 % i == 0 && sayi2 % i == 0) // burada da sayıları en küçükten bölerek ilerler ve en büyük ortak bölen tespit edilir.
                {
                    ebob = i;
                }
            }

            label3.Text = "Ekok : " + ekok.ToString() + "\n" + "Ebob : " + ebob.ToString(); // not3: ToString() ifadesi label a yazı olarak yazdır değerleri demektir.
        }
    }
}
