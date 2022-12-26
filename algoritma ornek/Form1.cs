using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algoritma_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplam = 0;
        int bolunensayı = 0;
        private void button1_Click(object sender, EventArgs e)
        {
          for(int i = 1; i <= 25; i++)
            {
                if (i % 7 == 0)
                {
                    bolunensayı++;
                    label4.Text = bolunensayı.ToString();
                    toplam = toplam + i;
                    label3.Text = toplam.ToString();
                }
            }
        }
    }
}
