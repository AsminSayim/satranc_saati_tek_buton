using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace satranc_saati_1
{
    public partial class Form1 : Form
    {
        int sureBeyaz = 10, sureSiyah = 10;
        bool beyazMi = true;

        private void btnBasla_Click(object sender, EventArgs e)
        {
            if(sureBeyaz>0|| sureSiyah > 0)
            {
                timer1.Start();
            }
            if (beyazMi)
            {
                beyazMi = false;
            }
            else
            {
                beyazMi = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sureBeyaz <= 0 && timer1.Enabled)
            {
                MessageBox.Show("Siyah Kazandı");
                timer1.Stop();
            }
            if(sureSiyah <= 0)
            {
                MessageBox.Show("Beyaz Kazandı");
                timer1.Stop();
            }
            if (beyazMi == false)
            {
                sureBeyaz--;
                btnBasla.Text=$"Beyaz için Kalan sure:{sureBeyaz}";
                this.BackColor = Color.White;
            }
            else
            {
                sureSiyah--;
                btnBasla.Text=$"Siyah için Kalan sure:{sureSiyah}";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        

    }
}
