
namespace YurtKayitSistemi
{
    partial class FrmAnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnYonetim = new System.Windows.Forms.Button();
            this.btnGiderler = new System.Windows.Forms.Button();
            this.btnOdemeler = new System.Windows.Forms.Button();
            this.btnBolum = new System.Windows.Forms.Button();
            this.btnOgr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersonel
            // 
            this.btnPersonel.BackgroundImage = global::YurtKayitSistemi.Properties.Resources.personel;
            this.btnPersonel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonel.Location = new System.Drawing.Point(296, 295);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(300, 200);
            this.btnPersonel.TabIndex = 5;
            this.btnPersonel.Text = "Personel";
            this.btnPersonel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPersonel.UseVisualStyleBackColor = true;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // btnYonetim
            // 
            this.btnYonetim.BackgroundImage = global::YurtKayitSistemi.Properties.Resources.yönetici;
            this.btnYonetim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYonetim.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYonetim.Location = new System.Drawing.Point(296, -1);
            this.btnYonetim.Name = "btnYonetim";
            this.btnYonetim.Size = new System.Drawing.Size(300, 300);
            this.btnYonetim.TabIndex = 1;
            this.btnYonetim.Text = "Yönetim";
            this.btnYonetim.UseVisualStyleBackColor = true;
            this.btnYonetim.Click += new System.EventHandler(this.btnYonetim_Click);
            // 
            // btnGiderler
            // 
            this.btnGiderler.BackgroundImage = global::YurtKayitSistemi.Properties.Resources.Giderler;
            this.btnGiderler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiderler.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiderler.ForeColor = System.Drawing.Color.Black;
            this.btnGiderler.Location = new System.Drawing.Point(592, 195);
            this.btnGiderler.Name = "btnGiderler";
            this.btnGiderler.Size = new System.Drawing.Size(300, 300);
            this.btnGiderler.TabIndex = 6;
            this.btnGiderler.Text = "Giderler";
            this.btnGiderler.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGiderler.UseVisualStyleBackColor = true;
            this.btnGiderler.Click += new System.EventHandler(this.btnGiderler_Click);
            // 
            // btnOdemeler
            // 
            this.btnOdemeler.BackgroundImage = global::YurtKayitSistemi.Properties.Resources.ödemeler;
            this.btnOdemeler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOdemeler.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeler.Location = new System.Drawing.Point(592, -1);
            this.btnOdemeler.Name = "btnOdemeler";
            this.btnOdemeler.Size = new System.Drawing.Size(300, 200);
            this.btnOdemeler.TabIndex = 3;
            this.btnOdemeler.Text = "Ödemeler";
            this.btnOdemeler.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOdemeler.UseVisualStyleBackColor = true;
            this.btnOdemeler.Click += new System.EventHandler(this.btnOdemeler_Click);
            // 
            // btnBolum
            // 
            this.btnBolum.BackgroundImage = global::YurtKayitSistemi.Properties.Resources.bolumlerPaneli;
            this.btnBolum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBolum.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolum.Location = new System.Drawing.Point(0, 195);
            this.btnBolum.Name = "btnBolum";
            this.btnBolum.Size = new System.Drawing.Size(300, 300);
            this.btnBolum.TabIndex = 4;
            this.btnBolum.Text = "Bölümler";
            this.btnBolum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBolum.UseVisualStyleBackColor = true;
            this.btnBolum.Click += new System.EventHandler(this.btnBolum_Click);
            // 
            // btnOgr
            // 
            this.btnOgr.BackgroundImage = global::YurtKayitSistemi.Properties.Resources.ogrenci;
            this.btnOgr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOgr.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgr.Location = new System.Drawing.Point(0, -1);
            this.btnOgr.Name = "btnOgr";
            this.btnOgr.Size = new System.Drawing.Size(300, 200);
            this.btnOgr.TabIndex = 2;
            this.btnOgr.Text = "Öğrenciler";
            this.btnOgr.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnOgr.UseVisualStyleBackColor = true;
            this.btnOgr.Click += new System.EventHandler(this.btnOgr_Click);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 491);
            this.Controls.Add(this.btnPersonel);
            this.Controls.Add(this.btnYonetim);
            this.Controls.Add(this.btnGiderler);
            this.Controls.Add(this.btnOdemeler);
            this.Controls.Add(this.btnBolum);
            this.Controls.Add(this.btnOgr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaForm";
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.FrmAnaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOgr;
        private System.Windows.Forms.Button btnBolum;
        private System.Windows.Forms.Button btnOdemeler;
        private System.Windows.Forms.Button btnGiderler;
        private System.Windows.Forms.Button btnYonetim;
        private System.Windows.Forms.Button btnPersonel;
    }
}