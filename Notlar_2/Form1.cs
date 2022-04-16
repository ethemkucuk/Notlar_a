using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notlar_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox2.Text); // Kullanıcıdan Sayı Alıyoruz, alınan sayı sayi değişkeni diyoruz
            double kök = Math.Sqrt(sayi); // Burada double tanımlıyoruz çünkü çoğu sayının kökü virgüllü
            // math.sqrt bir yapı sayının karesi alınıyor.
            textBox3.Text = kök.ToString(); // textbox a yazdırıyoruz
            
        }
    }
}
