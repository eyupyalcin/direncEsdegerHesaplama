using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirencEsdegerHesabi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nudDirenc2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbBaglanti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if(cmbBaglanti.Text=="Seri Bağlantı")
            {
                String sonuc = Convert.ToString(nudDirenc1.Value + nudDirenc2.Value);
                lblSonuc.Text = sonuc + " " + cmbBirim.Text;
               

            }
            else if(cmbBaglanti.Text == "Paralel Bağlantı")
            {
                String snc = Convert.ToString((nudDirenc1.Value * nudDirenc2.Value) / (nudDirenc1.Value + nudDirenc2.Value));
                lblSonuc.Text = snc + " " + cmbBirim.Text;
               
            }
            else
            {
                MessageBox.Show("Lütfen Bağlantı Tipini Seçin");
            }




        }

        private void lblSonuc_Click(object sender, EventArgs e)
        {

        }
    }
}
