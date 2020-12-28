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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Giderler (Elektirik,Su,DogalGaz,internet,Gıda,Personel,Diger) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtElektirik.Text);
                komut.Parameters.AddWithValue("@p2", TxtSu.Text);
                komut.Parameters.AddWithValue("@p3", TxtDogalGaz.Text);
                komut.Parameters.AddWithValue("@p4", TxtInternet.Text);
                komut.Parameters.AddWithValue("@p5", TxtGıda.Text);
                komut.Parameters.AddWithValue("@p6", TxtPersonel.Text);
                komut.Parameters.AddWithValue("@p7", TxtDiger.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıtlar Eklendi");
                this.giderlerTableAdapter.Fill(this.yurtOtomasyonDataSet3.Giderler);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu yeniden deneyiniz.");
            }
        }

        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet3.Giderler' table. You can move, or remove it, as needed.
            this.giderlerTableAdapter.Fill(this.yurtOtomasyonDataSet3.Giderler);

        }
    }
}
