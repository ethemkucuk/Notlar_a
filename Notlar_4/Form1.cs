using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notlar_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            // Increment özlliği her saniye 1 ilerle demek
            label1.Text ="%"+progressBar1.Value.ToString();
            //progressBar1.Value.ToString() prgressbarın ilerleyişini yazı olarak yazdırır
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                MessageBox.Show("Yüklenme Tamamlandı"); // bu sınavda olmayabilir ama kullanışlı ve kolay bir yapıdır.
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
