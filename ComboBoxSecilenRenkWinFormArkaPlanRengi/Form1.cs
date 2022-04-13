using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxSecilenRenkWinFormArkaPlanRengi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            //int deger = rnd.Next(0, 256);
            //this.BackColor = Color.FromArgb(deger,deger,deger);

            int deger1 = rnd.Next(0, 256);
            int deger2 = rnd.Next(0, 256);
            int deger3 = rnd.Next(0, 256);
            this.BackColor = Color.FromArgb(deger1, deger2, deger3);
        }
    }
}
