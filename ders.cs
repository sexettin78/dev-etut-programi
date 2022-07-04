using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ogrencietutkayitsistemi
{
    public partial class ders : Form
    {
        public ders()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-LAP7TNM;Initial Catalog=EtutTest;Integrated Security=True");


        void dersz()
        {     
            SqlDataAdapter da3 = new SqlDataAdapter("Select * from tbldersler", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        
        }

        private void ders_Load(object sender, EventArgs e)
        {
            dersz();
        }

        private void txtders_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("insert into tbldersler (dersad) values (@p1)", baglanti);
            komut3.Parameters.AddWithValue("@p1", txtdersad.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ders Sisteme Kayıt Edildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
