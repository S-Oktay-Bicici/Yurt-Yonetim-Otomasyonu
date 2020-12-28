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
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblOgrTelefon_Click(object sender, EventArgs e)
        {

        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmOgrKayit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet1.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonDataSet1.Ogrenci);
            //bölümleri listeleme komutları
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler",bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                CmbBolum.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();

            //boş odaları listeleme komutları
            SqlCommand komut2 = new SqlCommand("Select Odano From Odalar where OdaKapasite != OdaAktif", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                CmbOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAnaForm ac = new FrmAnaForm();
            ac.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id ,ad, soyad, Tc, telefon, dogum, bolum;
            string mail,odano, veliadSoyad, velitelefon, veliadres;
            
            secilen = dataGridView1.SelectedCells[0].RowIndex;

            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            Tc = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            telefon = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            dogum = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            bolum = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            mail = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            odano = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            veliadSoyad = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            velitelefon = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            veliadres = dataGridView1.Rows[secilen].Cells[11].Value.ToString();

            TxtOgrid.Text = id;
            TxtOgrAd.Text = ad;
            TxtOgrSoyad.Text = soyad;
            MskTC.Text = Tc;
            MskOgrTelefon.Text = telefon;
            MskDogum.Text = dogum;
            CmbBolum.Text = bolum;
            TxtMail.Text = mail;
            CmbOdaNo.Text = odano;
            TxtVeliAdSoyad.Text = veliadSoyad;
            MskVeliTelefon.Text = velitelefon;
            RchAdres.Text = veliadres;
        }

        private void PcbOgrGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut3 = new SqlCommand("update Ogrenci Set OgrAd=@d2,OgrSoyad=@d3,OgrTc=@d4,OgrTelefon=@d5,OgrDogum=@d6,OgrBolum=@d7,OgrMail=@d8,OgrOdaNo=@d9,OgrVeliAdSoyad=@d10,OgrVeliTelefon=@d11,OgrVeliAdres=@d12 where Ogrid=@d1", bgl.baglanti());
                komut3.Parameters.AddWithValue("@d1", TxtOgrid.Text);
                komut3.Parameters.AddWithValue("@d2", TxtOgrAd.Text);
                komut3.Parameters.AddWithValue("@d3", TxtOgrSoyad.Text);
                komut3.Parameters.AddWithValue("@d4", MskTC.Text);
                komut3.Parameters.AddWithValue("@d5", MskOgrTelefon.Text);
                komut3.Parameters.AddWithValue("@d6", MskDogum.Text);
                komut3.Parameters.AddWithValue("@d7", CmbBolum.Text);
                komut3.Parameters.AddWithValue("@d8", TxtMail.Text);
                komut3.Parameters.AddWithValue("@d9", CmbOdaNo.Text);
                komut3.Parameters.AddWithValue("@d10", TxtVeliAdSoyad.Text);
                komut3.Parameters.AddWithValue("@d11", MskVeliTelefon.Text);
                komut3.Parameters.AddWithValue("@d12", RchAdres.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm Başarı ile Güncellenmiştir.");
                this.ogrenciTableAdapter.Fill(this.yurtOtomasyonDataSet1.Ogrenci);

            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu Lütfen Tekrar Deneyiniz");
            }

        }

        private void PcbOgrSil_Click(object sender, EventArgs e)
        {
            //öğrenci silme
            try
            {
                SqlCommand komut2 = new SqlCommand("delete from Ogrenci where Ogrid=@b1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@b1", TxtOgrid.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti");
                this.ogrenciTableAdapter.Fill(this.yurtOtomasyonDataSet1.Ogrenci);
            }
            catch
            {
                MessageBox.Show("HATA!!! İŞLEM GERÇEKLEŞMEDİ");
            }

            //öğrenci borç alanı kaldırma
            SqlCommand komutsil = new SqlCommand("delete from Borclar where Ogrid=@k1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@k1", TxtOgrid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();


            // odanın aktif öğrenci sayısını azaltma
            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif-1 where OdaNo=@oda", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda", CmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonDataSet1.Ogrenci);
        }

        private void PcbOgrAdd_Click(object sender, EventArgs e)
        {
            //öğrenci bilgilerinin kayıt edilme komutları
            try
            {
                SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci (OgrAd,OgrSoyad,OgrTc,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@p1", TxtOgrAd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", TxtOgrSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p3", MskTC.Text);
                komutkaydet.Parameters.AddWithValue("@p4", MskOgrTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p5", MskDogum.Text);
                komutkaydet.Parameters.AddWithValue("@p6", CmbBolum.Text);
                komutkaydet.Parameters.AddWithValue("@p7", TxtMail.Text);
                komutkaydet.Parameters.AddWithValue("@p8", CmbOdaNo.Text);
                komutkaydet.Parameters.AddWithValue("@p9", TxtVeliAdSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p10", MskVeliTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p11", RchAdres.Text);
                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Gerçekleşti");

                //öğrenci id label a çekme
                SqlCommand komut = new SqlCommand("select Ogrid from Ogrenci", bgl.baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    label1.Text = oku[0].ToString();
                }
                bgl.baglanti().Close();

                //öğrenci borç alanı oluşturma 
                SqlCommand komutkaydet2 = new SqlCommand("insert into Borclar (Ogrid,OgrAd,OgrSoyad) values(@b1,@b2,@b3) ", bgl.baglanti());
                komutkaydet2.Parameters.AddWithValue("@b1", label1.Text);
                komutkaydet2.Parameters.AddWithValue("@b2", TxtOgrAd.Text);
                komutkaydet2.Parameters.AddWithValue("@b3", TxtOgrSoyad.Text);
                komutkaydet2.ExecuteNonQuery();
                bgl.baglanti().Close();
                this.ogrenciTableAdapter.Fill(this.yurtOtomasyonDataSet1.Ogrenci);
            }
            catch
            {
                MessageBox.Show("HATA!!! Yeniden Deneyiniz.");
            }

            //odanın aktif öğrenci sayısını arttırma

            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif+1 where OdaNo=@oda1", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda1", CmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonDataSet1.Ogrenci);
        }

    }
}
//Data Source=S-OKTAY;Initial Catalog=YurtOtomasyon;Integrated Security=True