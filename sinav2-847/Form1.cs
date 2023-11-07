using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinav2_847
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTaksitSayisi.Text = tbTaksitSayi.Text;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblTaksitSayisi.Text = tbTaksitSayi.Value .ToString(); // yan taraftaki değer

            double toplam = Convert.ToDouble(txtAdet.Text) * Convert.ToDouble(txtBirimFiyat.Text);
            double taksit = toplam / tbTaksitSayi.Value;
            lblTutar.Text = taksit.ToString();
        }
    }
}
