
namespace YurtKayitSistemi
{
    partial class FrmOdemeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdemeler));
            this.TxtOdenen = new System.Windows.Forms.TextBox();
            this.LblOdenen = new System.Windows.Forms.Label();
            this.Lblid = new System.Windows.Forms.Label();
            this.LblKalanBorc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgrSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrKalanBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonDataSet2 = new YurtKayitSistemi.YurtOtomasyonDataSet2();
            this.borclarTableAdapter = new YurtKayitSistemi.YurtOtomasyonDataSet2TableAdapters.BorclarTableAdapter();
            this.TxtKalan = new System.Windows.Forms.TextBox();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.LlblSoyad = new System.Windows.Forms.Label();
            this.LblAd = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtOdenen
            // 
            this.TxtOdenen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOdenen.Location = new System.Drawing.Point(141, 120);
            this.TxtOdenen.Name = "TxtOdenen";
            this.TxtOdenen.Size = new System.Drawing.Size(230, 26);
            this.TxtOdenen.TabIndex = 3;
            this.TxtOdenen.TextChanged += new System.EventHandler(this.TxtBolumAd_TextChanged);
            // 
            // LblOdenen
            // 
            this.LblOdenen.AutoSize = true;
            this.LblOdenen.BackColor = System.Drawing.Color.Transparent;
            this.LblOdenen.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOdenen.Location = new System.Drawing.Point(63, 123);
            this.LblOdenen.Name = "LblOdenen";
            this.LblOdenen.Size = new System.Drawing.Size(72, 18);
            this.LblOdenen.TabIndex = 7;
            this.LblOdenen.Text = "Ödenen:";
            this.LblOdenen.Click += new System.EventHandler(this.label2_Click);
            // 
            // Lblid
            // 
            this.Lblid.AutoSize = true;
            this.Lblid.BackColor = System.Drawing.Color.Transparent;
            this.Lblid.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lblid.Location = new System.Drawing.Point(43, 10);
            this.Lblid.Name = "Lblid";
            this.Lblid.Size = new System.Drawing.Size(92, 18);
            this.Lblid.TabIndex = 5;
            this.Lblid.Text = "Öğrenci id:";
            this.Lblid.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblKalanBorc
            // 
            this.LblKalanBorc.AutoSize = true;
            this.LblKalanBorc.BackColor = System.Drawing.Color.Transparent;
            this.LblKalanBorc.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKalanBorc.Location = new System.Drawing.Point(36, 157);
            this.LblKalanBorc.Name = "LblKalanBorc";
            this.LblKalanBorc.Size = new System.Drawing.Size(99, 18);
            this.LblKalanBorc.TabIndex = 9;
            this.LblKalanBorc.Text = "Kalan Borç:";
            this.LblKalanBorc.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(219, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Öde");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogridDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.OgrSoyad,
            this.ogrKalanBorcDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.borclarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(427, 341);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ogridDataGridViewTextBoxColumn
            // 
            this.ogridDataGridViewTextBoxColumn.DataPropertyName = "Ogrid";
            this.ogridDataGridViewTextBoxColumn.HeaderText = "Ogrid";
            this.ogridDataGridViewTextBoxColumn.Name = "ogridDataGridViewTextBoxColumn";
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            // 
            // OgrSoyad
            // 
            this.OgrSoyad.DataPropertyName = "OgrSoyad";
            this.OgrSoyad.HeaderText = "OgrSoyad";
            this.OgrSoyad.Name = "OgrSoyad";
            // 
            // ogrKalanBorcDataGridViewTextBoxColumn
            // 
            this.ogrKalanBorcDataGridViewTextBoxColumn.DataPropertyName = "OgrKalanBorc";
            this.ogrKalanBorcDataGridViewTextBoxColumn.HeaderText = "OgrKalanBorc";
            this.ogrKalanBorcDataGridViewTextBoxColumn.Name = "ogrKalanBorcDataGridViewTextBoxColumn";
            // 
            // borclarBindingSource
            // 
            this.borclarBindingSource.DataMember = "Borclar";
            this.borclarBindingSource.DataSource = this.yurtOtomasyonDataSet2;
            // 
            // yurtOtomasyonDataSet2
            // 
            this.yurtOtomasyonDataSet2.DataSetName = "YurtOtomasyonDataSet2";
            this.yurtOtomasyonDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borclarTableAdapter
            // 
            this.borclarTableAdapter.ClearBeforeFill = true;
            // 
            // TxtKalan
            // 
            this.TxtKalan.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKalan.Location = new System.Drawing.Point(141, 157);
            this.TxtKalan.Name = "TxtKalan";
            this.TxtKalan.Size = new System.Drawing.Size(230, 26);
            this.TxtKalan.TabIndex = 4;
            // 
            // Txtid
            // 
            this.Txtid.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtid.Location = new System.Drawing.Point(141, 7);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(230, 26);
            this.Txtid.TabIndex = 47;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyad.Location = new System.Drawing.Point(141, 81);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(230, 26);
            this.TxtSoyad.TabIndex = 2;
            // 
            // TxtAd
            // 
            this.TxtAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Location = new System.Drawing.Point(141, 44);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(230, 26);
            this.TxtAd.TabIndex = 1;
            // 
            // LlblSoyad
            // 
            this.LlblSoyad.AutoSize = true;
            this.LlblSoyad.BackColor = System.Drawing.Color.Transparent;
            this.LlblSoyad.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LlblSoyad.Location = new System.Drawing.Point(63, 84);
            this.LlblSoyad.Name = "LlblSoyad";
            this.LlblSoyad.Size = new System.Drawing.Size(61, 18);
            this.LlblSoyad.TabIndex = 17;
            this.LlblSoyad.Text = "Soyad:";
            // 
            // LblAd
            // 
            this.LblAd.AutoSize = true;
            this.LblAd.BackColor = System.Drawing.Color.Transparent;
            this.LblAd.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAd.Location = new System.Drawing.Point(100, 44);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(35, 18);
            this.LblAd.TabIndex = 18;
            this.LblAd.Text = "Ad:";
            // 
            // FrmOdemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YurtKayitSistemi.Properties.Resources.ödemeler;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(430, 586);
            this.Controls.Add(this.LblAd);
            this.Controls.Add(this.LlblSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.Txtid);
            this.Controls.Add(this.TxtKalan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblKalanBorc);
            this.Controls.Add(this.TxtOdenen);
            this.Controls.Add(this.LblOdenen);
            this.Controls.Add(this.Lblid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOdemeler";
            this.Text = "Ödemeler";
            this.Load += new System.EventHandler(this.FrmOdemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtOdenen;
        private System.Windows.Forms.Label LblOdenen;
        private System.Windows.Forms.Label Lblid;
        private System.Windows.Forms.Label LblKalanBorc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonDataSet2 yurtOtomasyonDataSet2;
        private System.Windows.Forms.BindingSource borclarBindingSource;
        private YurtOtomasyonDataSet2TableAdapters.BorclarTableAdapter borclarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgrSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrKalanBorcDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TxtKalan;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label LlblSoyad;
        private System.Windows.Forms.Label LblAd;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}