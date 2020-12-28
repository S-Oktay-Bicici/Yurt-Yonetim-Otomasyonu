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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pctLogin_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Admin where YöneticiAd=@p1 and YöneticiSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtKullaniciSifre.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");
                TxtKullaniciAd.Clear();
                TxtKullaniciSifre.Clear();
                TxtKullaniciAd.Focus();
            }
            bgl.baglanti().Close();
        }

        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
