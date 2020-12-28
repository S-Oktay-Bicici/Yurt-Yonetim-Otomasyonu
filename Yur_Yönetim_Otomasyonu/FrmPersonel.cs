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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet5.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.yurtOtomasyonDataSet5.Personel);

        }

        private void pctKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Personel (PersonelAdSoyad,PersonelDepertman) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtPersonelAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtPersonelGorev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Eklendi");
            this.personelTableAdapter.Fill(this.yurtOtomasyonDataSet5.Personel);
        }

        private void pctGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Personel set PersonelAdSoyad=@p1,PersonelDepertman=@p2 where Pesonelid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtPersonelAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtPersonelGorev.Text);
            komut.Parameters.AddWithValue("@p3", TxtPersonelid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme işlemi gerçekleşti");
            this.personelTableAdapter.Fill(this.yurtOtomasyonDataSet5.Personel);
        }

        private void pctKaldır_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Personel where Pesonelid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtPersonelid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme işlemi gerçekleşti");
            this.personelTableAdapter.Fill(this.yurtOtomasyonDataSet5.Personel);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string adSoyad, departman, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            adSoyad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            departman = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            TxtPersonelid.Text = id;
            TxtPersonelAd.Text = adSoyad;
            TxtPersonelGorev.Text = departman;
        }
    }
}
