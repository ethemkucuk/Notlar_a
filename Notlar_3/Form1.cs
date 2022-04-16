using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notlar_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saga_ileri(object sender, EventArgs e)
            // timer ın özeklliklerine gelip entervali 100 den 1 yapıyoruz
        {
            timer1.Enabled = true; // bunu yapmamızın amacı çalıştıracağımız timer i belirlemek ve sadece onu true yapmak.
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // left saga - left sola -top yukarı +top aşağı
            label1.Left++; // sürekli tekrarlayan bir döngü oluşturuyoruz.
            if (label1.Left == 700) // 700e geldiğinde demektir.
            {
                label1.Left = -70; // 700 e geldiğinde buraya döndür demek
            }
            // bu yapı sürekli tekrarlıyor
        }

        private void sola_ileri(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer1.Enabled=false;
            timer3.Enabled=false;
            timer4.Enabled=false;
            timer5.Enabled  =false;
            timer6.Enabled=false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Left--;
            if (label1.Left == -70)
            {
                label1.Left = 700;
            }
        }

        private void yukarı_ileri(object sender, EventArgs e)
        {
            timer3.Enabled = true;
            timer1.Enabled = false;
            timer2.Enabled =false;
            timer4.Enabled =false;
            timer5.Enabled=false;
            timer6.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label1.Top--;
            if (label1.Top == -30)
            {
                label1.Top = 350;
            }
        }

        private void asagi_ileri(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled=false;
            timer3.Enabled = false;
            timer4.Enabled = true;
            timer5.Enabled = false;
            timer6.Enabled=false ;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label1.Top++;
            if (label1.Top == 350)
            {
                label1.Top = -30;
            }
        }

        private void saga_random(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = true;
            timer6.Enabled = false;
        }
        Random random = new Random(); // random u dışarıda oluşturup tüm gruplarda kullanıyoruz
        private void timer5_Tick(object sender, EventArgs e)
        {
            label1.Left++;
            if (label1.Left == 700)
            {
                label1.Left = -70;
                label1.Top = random.Next(-30,350); // -70 e geldiğinde yukarıdan aşağıya bir random bir yerden döngüye devam et diyoruz.
            }
        }

        private void yukaridan_random(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = true;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            label1.Top++;
            if (label1.Top == 350)
            {
                label1.Top = -30;
                label1.Left = random.Next(-70, 700);
            }
        }
    }
}
