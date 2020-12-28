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

namespace YurtKayitSistemi
{
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet2.Borclar' table. You can move, or remove it, as needed.
            this.borclarTableAdapter.Fill(this.yurtOtomasyonDataSet2.Borclar);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtBolumAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            Txtid.Text = id;
            TxtAd.Text = ad;
            TxtSoyad.Text = soyad;
            TxtKalan.Text = kalan;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //ödenen tutarı kalan tutardan düşme
            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt16(TxtOdenen.Text);
            kalan = Convert.ToInt16(TxtKalan.Text);
            yeniborc = kalan - odenen;
            TxtKalan.Text = yeniborc.ToString();

            //ödenen tutarı veri tabanına kaydetme
            SqlCommand komut = new SqlCommand("update Borclar set ogrkalanborc=@p1 where Ogrid = @p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", Txtid.Text);
            komut.Parameters.AddWithValue("@p1", TxtKalan.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Borç Ödendi");
            this.borclarTableAdapter.Fill(this.yurtOtomasyonDataSet2.Borclar);
        }
    }
}
