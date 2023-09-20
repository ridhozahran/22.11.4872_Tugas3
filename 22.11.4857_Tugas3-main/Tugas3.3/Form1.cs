using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var nama = txtname.Text;
            var pendidikan = cmbPendidikan.Text;
            var pekerjaan = lbPekerjaan.Text;

            txt1.Text = string.Format("Halo {0}", nama);
            txt2.Text = string.Format("Pendidikan Anda {0}  ya? ", pendidikan);
            txt3.Text = string.Format("Anda seorang {0} , hebat !!!", pekerjaan);

        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
