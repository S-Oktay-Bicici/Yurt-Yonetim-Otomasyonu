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
    public partial class FrmYonetici : Form
    {
        public FrmYonetici()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmYonetici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet4.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.yurtOtomasyonDataSet4.Admin);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Admin (YöneticiAd,YöneticiSifre) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yönetici Eklendi");
            this.adminTableAdapter.Fill(this.yurtOtomasyonDataSet4.Admin);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, sifrei, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifrei = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            TxtYoneticiid.Text = id;
            TxtKullaniciAd.Text = ad;
            TxtSifre.Text = sifrei;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Admin where Yöneticiid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtYoneticiid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme işlemi gerçekleşti");
            this.adminTableAdapter.Fill(this.yurtOtomasyonDataSet4.Admin);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update admin set YöneticiAd=@p1,YöneticiSifre=@p2 where Yöneticiid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p3", TxtYoneticiid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme işlemi gerçekleşti");
            this.adminTableAdapter.Fill(this.yurtOtomasyonDataSet4.Admin);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
