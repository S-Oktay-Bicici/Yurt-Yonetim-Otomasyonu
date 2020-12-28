
namespace YurtKayitSistemi
{
    partial class FrmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPersonelGorev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPersonelAd = new System.Windows.Forms.TextBox();
            this.LblKullaniciAd = new System.Windows.Forms.Label();
            this.TxtPersonelid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pesonelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDepertmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonDataSet5 = new YurtKayitSistemi.YurtOtomasyonDataSet5();
            this.pctGuncelle = new System.Windows.Forms.PictureBox();
            this.pctKaydet = new System.Windows.Forms.PictureBox();
            this.pctKaldır = new System.Windows.Forms.PictureBox();
            this.personelTableAdapter = new YurtKayitSistemi.YurtOtomasyonDataSet5TableAdapters.PersonelTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKaydet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKaldır)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Personel GÖrev:";
            // 
            // TxtPersonelGorev
            // 
            this.TxtPersonelGorev.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtPersonelGorev.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonelGorev.Location = new System.Drawing.Point(142, 122);
            this.TxtPersonelGorev.Name = "TxtPersonelGorev";
            this.TxtPersonelGorev.Size = new System.Drawing.Size(200, 25);
            this.TxtPersonelGorev.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Personel Adı:";
            // 
            // TxtPersonelAd
            // 
            this.TxtPersonelAd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtPersonelAd.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonelAd.Location = new System.Drawing.Point(142, 68);
            this.TxtPersonelAd.Name = "TxtPersonelAd";
            this.TxtPersonelAd.Size = new System.Drawing.Size(200, 25);
            this.TxtPersonelAd.TabIndex = 1;
            // 
            // LblKullaniciAd
            // 
            this.LblKullaniciAd.AutoSize = true;
            this.LblKullaniciAd.BackColor = System.Drawing.Color.Transparent;
            this.LblKullaniciAd.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKullaniciAd.Location = new System.Drawing.Point(31, 23);
            this.LblKullaniciAd.Name = "LblKullaniciAd";
            this.LblKullaniciAd.Size = new System.Drawing.Size(102, 18);
            this.LblKullaniciAd.TabIndex = 16;
            this.LblKullaniciAd.Text = "Personel Id:";
            // 
            // TxtPersonelid
            // 
            this.TxtPersonelid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtPersonelid.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonelid.Location = new System.Drawing.Point(142, 16);
            this.TxtPersonelid.Name = "TxtPersonelid";
            this.TxtPersonelid.Size = new System.Drawing.Size(200, 25);
            this.TxtPersonelid.TabIndex = 45;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pesonelidDataGridViewTextBoxColumn,
            this.personelAdSoyadDataGridViewTextBoxColumn,
            this.personelDepertmanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(347, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 269);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pesonelidDataGridViewTextBoxColumn
            // 
            this.pesonelidDataGridViewTextBoxColumn.DataPropertyName = "Pesonelid";
            this.pesonelidDataGridViewTextBoxColumn.HeaderText = "Pesonelid";
            this.pesonelidDataGridViewTextBoxColumn.Name = "pesonelidDataGridViewTextBoxColumn";
            this.pesonelidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelAdSoyadDataGridViewTextBoxColumn
            // 
            this.personelAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "PersonelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.HeaderText = "PersonelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.Name = "personelAdSoyadDataGridViewTextBoxColumn";
            // 
            // personelDepertmanDataGridViewTextBoxColumn
            // 
            this.personelDepertmanDataGridViewTextBoxColumn.DataPropertyName = "PersonelDepertman";
            this.personelDepertmanDataGridViewTextBoxColumn.HeaderText = "PersonelDepertman";
            this.personelDepertmanDataGridViewTextBoxColumn.Name = "personelDepertmanDataGridViewTextBoxColumn";
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.yurtOtomasyonDataSet5;
            // 
            // yurtOtomasyonDataSet5
            // 
            this.yurtOtomasyonDataSet5.DataSetName = "YurtOtomasyonDataSet5";
            this.yurtOtomasyonDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pctGuncelle
            // 
            this.pctGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.pctGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("pctGuncelle.Image")));
            this.pctGuncelle.Location = new System.Drawing.Point(226, 168);
            this.pctGuncelle.Name = "pctGuncelle";
            this.pctGuncelle.Size = new System.Drawing.Size(40, 39);
            this.pctGuncelle.TabIndex = 14;
            this.pctGuncelle.TabStop = false;
            this.toolTip1.SetToolTip(this.pctGuncelle, "Güncelle");
            this.pctGuncelle.Click += new System.EventHandler(this.pctGuncelle_Click);
            // 
            // pctKaydet
            // 
            this.pctKaydet.BackColor = System.Drawing.Color.Transparent;
            this.pctKaydet.Image = ((System.Drawing.Image)(resources.GetObject("pctKaydet.Image")));
            this.pctKaydet.Location = new System.Drawing.Point(167, 168);
            this.pctKaydet.Name = "pctKaydet";
            this.pctKaydet.Size = new System.Drawing.Size(35, 41);
            this.pctKaydet.TabIndex = 13;
            this.pctKaydet.TabStop = false;
            this.toolTip1.SetToolTip(this.pctKaydet, "Ekle");
            this.pctKaydet.Click += new System.EventHandler(this.pctKaydet_Click);
            // 
            // pctKaldır
            // 
            this.pctKaldır.BackColor = System.Drawing.Color.Transparent;
            this.pctKaldır.Image = ((System.Drawing.Image)(resources.GetObject("pctKaldır.Image")));
            this.pctKaldır.Location = new System.Drawing.Point(290, 171);
            this.pctKaldır.Name = "pctKaldır";
            this.pctKaldır.Size = new System.Drawing.Size(35, 38);
            this.pctKaldır.TabIndex = 12;
            this.pctKaldır.TabStop = false;
            this.toolTip1.SetToolTip(this.pctKaldır, "Kaldır");
            this.pctKaldır.Click += new System.EventHandler(this.pctKaldır_Click);
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::YurtKayitSistemi.Properties.Resources.personel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 275);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPersonelGorev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPersonelAd);
            this.Controls.Add(this.LblKullaniciAd);
            this.Controls.Add(this.TxtPersonelid);
            this.Controls.Add(this.pctGuncelle);
            this.Controls.Add(this.pctKaydet);
            this.Controls.Add(this.pctKaldır);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPersonel";
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKaydet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKaldır)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPersonelGorev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPersonelAd;
        private System.Windows.Forms.Label LblKullaniciAd;
        private System.Windows.Forms.TextBox TxtPersonelid;
        private System.Windows.Forms.PictureBox pctGuncelle;
        private System.Windows.Forms.PictureBox pctKaydet;
        private System.Windows.Forms.PictureBox pctKaldır;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonDataSet5 yurtOtomasyonDataSet5;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private YurtOtomasyonDataSet5TableAdapters.PersonelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesonelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDepertmanDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}