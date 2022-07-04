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
    public partial class OGRETMEN : Form
    {
        public OGRETMEN()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-LAP7TNM;Initial Catalog=EtutTest;Integrated Security=True");
        
        void ogretmenlist()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbldersler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbders.ValueMember = "DERSID";
            cmbders.DisplayMember = "DERSAD";
            cmbders.DataSource = dt;
        }


        void etutlistesi()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("Select * from tblogretmen", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }

        private void OGRETMEN_Load(object sender, EventArgs e)
        {
            ogretmenlist();
            etutlistesi();
        }

        private void btnogretmenkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("insert into tblogretmen (ad,soyad,bransıd) values (@p1,@p2,@p3)", baglanti);
            komut3.Parameters.AddWithValue("@p1", txtogretmenad.Text);
            komut3.Parameters.AddWithValue("@p2", txtogretmensoyad.Text);
            komut3.Parameters.AddWithValue("@p3", cmbders.SelectedValue);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğretmen Sisteme Kayıt Edildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
