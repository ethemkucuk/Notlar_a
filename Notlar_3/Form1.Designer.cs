namespace Notlar_3
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sağaDoğruİleriDöngüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solaDoğruİleriDöngüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yukarıDoğruİleriDöngüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aşağıDoğruİleriDöngüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sağaDoğruRandomBelirmesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yukarıdanRandomBelirmesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(819, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sağaDoğruİleriDöngüToolStripMenuItem,
            this.solaDoğruİleriDöngüToolStripMenuItem,
            this.yukarıDoğruİleriDöngüToolStripMenuItem,
            this.aşağıDoğruİleriDöngüToolStripMenuItem,
            this.sağaDoğruRandomBelirmesiToolStripMenuItem,
            this.yukarıdanRandomBelirmesiToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // sağaDoğruİleriDöngüToolStripMenuItem
            // 
            this.sağaDoğruİleriDöngüToolStripMenuItem.Name = "sağaDoğruİleriDöngüToolStripMenuItem";
            this.sağaDoğruİleriDöngüToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.sağaDoğruİleriDöngüToolStripMenuItem.Text = "Sağa Doğru İleri döngü";
            this.sağaDoğruİleriDöngüToolStripMenuItem.Click += new System.EventHandler(this.saga_ileri);
            // 
            // solaDoğruİleriDöngüToolStripMenuItem
            // 
            this.solaDoğruİleriDöngüToolStripMenuItem.Name = "solaDoğruİleriDöngüToolStripMenuItem";
            this.solaDoğruİleriDöngüToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.solaDoğruİleriDöngüToolStripMenuItem.Text = "Sola Doğru ileri Döngü";
            this.solaDoğruİleriDöngüToolStripMenuItem.Click += new System.EventHandler(this.sola_ileri);
            // 
            // yukarıDoğruİleriDöngüToolStripMenuItem
            // 
            this.yukarıDoğruİleriDöngüToolStripMenuItem.Name = "yukarıDoğruİleriDöngüToolStripMenuItem";
            this.yukarıDoğruİleriDöngüToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.yukarıDoğruİleriDöngüToolStripMenuItem.Text = "Yukarı doğru ileri Döngü";
            this.yukarıDoğruİleriDöngüToolStripMenuItem.Click += new System.EventHandler(this.yukarı_ileri);
            // 
            // aşağıDoğruİleriDöngüToolStripMenuItem
            // 
            this.aşağıDoğruİleriDöngüToolStripMenuItem.Name = "aşağıDoğruİleriDöngüToolStripMenuItem";
            this.aşağıDoğruİleriDöngüToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.aşağıDoğruİleriDöngüToolStripMenuItem.Text = "Aşağı Doğru ileri Döngü";
            this.aşağıDoğruİleriDöngüToolStripMenuItem.Click += new System.EventHandler(this.asagi_ileri);
            // 
            // sağaDoğruRandomBelirmesiToolStripMenuItem
            // 
            this.sağaDoğruRandomBelirmesiToolStripMenuItem.Name = "sağaDoğruRandomBelirmesiToolStripMenuItem";
            this.sağaDoğruRandomBelirmesiToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.sağaDoğruRandomBelirmesiToolStripMenuItem.Text = "Sağa doğru random belirmesi";
            this.sağaDoğruRandomBelirmesiToolStripMenuItem.Click += new System.EventHandler(this.saga_random);
            // 
            // yukarıdanRandomBelirmesiToolStripMenuItem
            // 
            this.yukarıdanRandomBelirmesiToolStripMenuItem.Name = "yukarıdanRandomBelirmesiToolStripMenuItem";
            this.yukarıdanRandomBelirmesiToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.yukarıdanRandomBelirmesiToolStripMenuItem.Text = "Yukarıdan random belirmesi";
            this.yukarıdanRandomBelirmesiToolStripMenuItem.Click += new System.EventHandler(this.yukaridan_random);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 400);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(329, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 100);
            this.label1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 1;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Interval = 1;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(819, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sağaDoğruİleriDöngüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solaDoğruİleriDöngüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yukarıDoğruİleriDöngüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aşağıDoğruİleriDöngüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sağaDoğruRandomBelirmesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yukarıdanRandomBelirmesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
    }
}

