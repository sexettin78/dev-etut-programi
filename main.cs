using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrencietutkayitsistemi
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OGRETMEN ogrt = new OGRETMEN();
            ogrt.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OGRENCİ ogrnci = new OGRENCİ();
            ogrnci.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ders drs = new ders();
            drs.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 etut = new Form1();
            etut.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
