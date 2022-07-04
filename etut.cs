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
    public partial class etut : Form
    {
        public etut()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-LAP7TNM;Initial Catalog=EtutTest;Integrated Security=True");

        void derslistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbldersler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDers.ValueMember = "DERSID";
            cmbDers.DisplayMember = "DERSAD";
            cmbDers.DataSource = dt;
        }

        //Etüt listesi
        void etutlistesi()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("execute etut", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }


        private void etut_Load(object sender, EventArgs e)
        {
            derslistesi();
            etutlistesi();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEtut_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbletut (dersıd,ogrtmenıd,tarıh,saat) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbDers.SelectedValue);
            komut.Parameters.AddWithValue("@p2", cmbOgrtmen.SelectedValue);
            komut.Parameters.AddWithValue("@p3", mskTarih.Text);
            komut.Parameters.AddWithValue("@p4", mskSaat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close(); 

            MessageBox.Show("Etüt Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter("select ogrtıd,(ad+' '+soyad) as 'AD' from tblogretmen where bransıd=" + cmbDers.SelectedValue, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbOgrtmen.ValueMember = "OGRTID";
            cmbOgrtmen.DisplayMember = "AD";
            cmbOgrtmen.DataSource = dt;

        }

        private void btnetutver_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update tbletut set ogrencııd=@p1,durum=@p2 where ıd=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1", txtogrenciid.Text);
            komut.Parameters.AddWithValue("@p2", "True");
            komut.Parameters.AddWithValue("@p3", txtetutid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt öğrenciye verildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtetutid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }
    }
}
