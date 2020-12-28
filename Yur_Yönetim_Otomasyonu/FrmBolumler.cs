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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet.Bolumler' table. You can move, or remove it, as needed.
            this.bolumlerTableAdapter.Fill(this.yurtOtomasyonDataSet.Bolumler);

        }

        private void PcbBolumEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut1 = new SqlCommand("insert into Bolumler (BolumAd) values (@p1)", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm Eklendi");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonDataSet.Bolumler);
            }
            catch
            {
                MessageBox.Show("HATA!! Oluştu Yeniden Deneyin.");
            }
        }

        private void PcbBolumSil_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut2 = new SqlCommand("delete from Bolumler where Bolumid=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", TxtBolumid.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonDataSet.Bolumler);
            }
            catch
            {
                MessageBox.Show("HATA!!! İŞLEM GERÇEKLEŞMEDİ");
            }
        }

        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolumad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            TxtBolumid.Text = id;
            TxtBolumAd.Text = bolumad;
        }

        private void PcbBolumDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut3 = new SqlCommand("update Bolumler Set Bolumad=@p1 where Bolumid=@p2", bgl.baglanti());
                komut3.Parameters.AddWithValue("@p2", TxtBolumid.Text);
                komut3.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm Başarı ile Güncellenmiştir.");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonDataSet.Bolumler);
            }
            catch (Exception)
            {
                MessageBox.Show("HATA!! Bölüm güncellenemedi Yeniden Deneyiniz.");
            }
        }

        private void pcbGeriDon_Click(object sender, EventArgs e)
        {
            FrmAnaForm ac = new FrmAnaForm();
            ac.ShowDialog();
        }
    }
}
