using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notlar_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;

            

            

            

            progressBar1.Increment(1);
            
            
            

            label5.Text = "%" + progressBar1.Value.ToString();
            
            
            

            if(progressBar1.Value == 90)
            {
                timer1.Enabled = false;
            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Maximum = 100;
            progressBar2.Minimum = 0;
            progressBar2.Increment(1);
            label6.Text = "%" + progressBar2.Value.ToString();
            if (progressBar2.Value == 70)
            {
                timer2.Enabled = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Minimum = 0;
            progressBar3.Maximum = 100;
            progressBar3.Increment(1);
            label7.Text = "%" + progressBar3.Value.ToString();
            if (progressBar3.Value == 50)
            {
                timer3.Enabled = false;
            }

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.Maximum = 100;
            progressBar4.Minimum = 0;
            label8.Text = "%" + progressBar4.Value.ToString();
            progressBar4.Increment(1);
            if (progressBar4.Value == 20)
            {
                timer4.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            progressBar4.Value = 0;
            label5.Text ="%"+progressBar4.Value.ToString();
            label6.Text = "%" + progressBar4.Value.ToString();
            label7.Text= "%" + progressBar4.Value.ToString();
            label8.Text = "%" + progressBar4.Value.ToString();
            
        }
    }
}
