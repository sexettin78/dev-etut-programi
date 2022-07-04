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
    public partial class OGRENCİ : Form
    {
        public OGRENCİ()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-LAP7TNM;Initial Catalog=EtutTest;Integrated Security=True");

        void ogrencilist()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("Select * from tblogrenci", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;

        }

        private void OGRENCİ_Load(object sender, EventArgs e)
        {
            ogrencilist();
        }

        private void btnogrenciekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into TBLOGRENCİ (ad,soyad,sınıf,telefon,maıl) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut2.Parameters.AddWithValue("@p1", ograd.Text);
            komut2.Parameters.AddWithValue("@p2", ogrsoyad.Text);
            komut2.Parameters.AddWithValue("@p3", ogrsinif.Text);
            komut2.Parameters.AddWithValue("@p4", ogrtelefon.Text);
            komut2.Parameters.AddWithValue("@p5", ogrmail.Text);  
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme Kayıt Edildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
