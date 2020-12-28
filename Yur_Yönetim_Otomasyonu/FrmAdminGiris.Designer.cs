
namespace YurtKayitSistemi
{
    partial class FrmAdminGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminGiris));
            this.LblKullaniciAd = new System.Windows.Forms.Label();
            this.TxtKullaniciAd = new System.Windows.Forms.TextBox();
            this.LblKullaniciSifre = new System.Windows.Forms.Label();
            this.TxtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pctLogin = new System.Windows.Forms.PictureBox();
            this.LblGiris = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // LblKullaniciAd
            // 
            this.LblKullaniciAd.AutoSize = true;
            this.LblKullaniciAd.BackColor = System.Drawing.Color.Transparent;
            this.LblKullaniciAd.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKullaniciAd.Location = new System.Drawing.Point(27, 103);
            this.LblKullaniciAd.Name = "LblKullaniciAd";
            this.LblKullaniciAd.Size = new System.Drawing.Size(113, 18);
            this.LblKullaniciAd.TabIndex = 3;
            this.LblKullaniciAd.Text = "Kullanıcı Adı:";
            // 
            // TxtKullaniciAd
            // 
            this.TxtKullaniciAd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtKullaniciAd.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullaniciAd.Location = new System.Drawing.Point(157, 103);
            this.TxtKullaniciAd.Name = "TxtKullaniciAd";
            this.TxtKullaniciAd.Size = new System.Drawing.Size(200, 25);
            this.TxtKullaniciAd.TabIndex = 1;
            // 
            // LblKullaniciSifre
            // 
            this.LblKullaniciSifre.AutoSize = true;
            this.LblKullaniciSifre.BackColor = System.Drawing.Color.Transparent;
            this.LblKullaniciSifre.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKullaniciSifre.Location = new System.Drawing.Point(27, 161);
            this.LblKullaniciSifre.Name = "LblKullaniciSifre";
            this.LblKullaniciSifre.Size = new System.Drawing.Size(124, 18);
            this.LblKullaniciSifre.TabIndex = 5;
            this.LblKullaniciSifre.Text = "Kullanıcı Şifre:";
            // 
            // TxtKullaniciSifre
            // 
            this.TxtKullaniciSifre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtKullaniciSifre.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullaniciSifre.Location = new System.Drawing.Point(157, 158);
            this.TxtKullaniciSifre.Name = "TxtKullaniciSifre";
            this.TxtKullaniciSifre.Size = new System.Drawing.Size(200, 25);
            this.TxtKullaniciSifre.TabIndex = 2;
            this.TxtKullaniciSifre.Text = "    ";
            this.TxtKullaniciSifre.UseSystemPasswordChar = true;
            // 
            // pctLogin
            // 
            this.pctLogin.BackColor = System.Drawing.Color.Transparent;
            this.pctLogin.Image = ((System.Drawing.Image)(resources.GetObject("pctLogin.Image")));
            this.pctLogin.Location = new System.Drawing.Point(222, 198);
            this.pctLogin.Name = "pctLogin";
            this.pctLogin.Size = new System.Drawing.Size(63, 69);
            this.pctLogin.TabIndex = 6;
            this.pctLogin.TabStop = false;
            this.toolTip1.SetToolTip(this.pctLogin, "Giriş");
            this.pctLogin.Click += new System.EventHandler(this.pctLogin_Click);
            // 
            // LblGiris
            // 
            this.LblGiris.AutoSize = true;
            this.LblGiris.BackColor = System.Drawing.Color.Transparent;
            this.LblGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblGiris.Location = new System.Drawing.Point(38, 35);
            this.LblGiris.Name = "LblGiris";
            this.LblGiris.Size = new System.Drawing.Size(287, 25);
            this.LblGiris.TabIndex = 7;
            this.LblGiris.Text = "Yurt Yönetim Otomasyonu";
            this.LblGiris.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmAdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::YurtKayitSistemi.Properties.Resources.OgrKayitPaneli;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(369, 330);
            this.Controls.Add(this.LblGiris);
            this.Controls.Add(this.pctLogin);
            this.Controls.Add(this.LblKullaniciSifre);
            this.Controls.Add(this.TxtKullaniciSifre);
            this.Controls.Add(this.LblKullaniciAd);
            this.Controls.Add(this.TxtKullaniciAd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yurt Yönetim Otomasyonu Giriş";
            this.Load += new System.EventHandler(this.FrmAdminGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblKullaniciAd;
        private System.Windows.Forms.TextBox TxtKullaniciAd;
        private System.Windows.Forms.Label LblKullaniciSifre;
        private System.Windows.Forms.TextBox TxtKullaniciSifre;
        private System.Windows.Forms.PictureBox pctLogin;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label LblGiris;
    }
}