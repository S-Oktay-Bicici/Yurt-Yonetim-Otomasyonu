using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void btnOgr_Click(object sender, EventArgs e)
        {
            FrmOgrKayit ac = new FrmOgrKayit();
            ac.ShowDialog();
        }

        private void btnBolum_Click(object sender, EventArgs e)
        {
            FrmBolumler ac = new FrmBolumler();
            ac.ShowDialog();
        }

        private void btnOdemeler_Click(object sender, EventArgs e)
        {
            FrmOdemeler ac = new FrmOdemeler();
            ac.ShowDialog();
        }

        private void btnGiderler_Click(object sender, EventArgs e)
        {
            FrmGiderler ac = new FrmGiderler();
            ac.ShowDialog();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            FrmPersonel ac = new FrmPersonel();
            ac.ShowDialog();
        }

        private void btnYonetim_Click(object sender, EventArgs e)
        {
            FrmYonetici ac = new FrmYonetici();
            ac.ShowDialog();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
