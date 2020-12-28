
namespace YurtKayitSistemi
{
    partial class FrmGiderler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiderler));
            this.LblOgrAd = new System.Windows.Forms.Label();
            this.TxtElektirik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDogalGaz = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtInternet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtGıda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDiger = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPersonel = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.odemeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elektirikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogalgazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gıdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.digerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giderlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonDataSet3 = new YurtKayitSistemi.YurtOtomasyonDataSet3();
            this.giderlerTableAdapter = new YurtKayitSistemi.YurtOtomasyonDataSet3TableAdapters.GiderlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.btnKaydet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // LblOgrAd
            // 
            this.LblOgrAd.AutoSize = true;
            this.LblOgrAd.BackColor = System.Drawing.Color.Transparent;
            this.LblOgrAd.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOgrAd.Location = new System.Drawing.Point(24, 36);
            this.LblOgrAd.Name = "LblOgrAd";
            this.LblOgrAd.Size = new System.Drawing.Size(80, 18);
            this.LblOgrAd.TabIndex = 3;
            this.LblOgrAd.Text = "Elektirik:";
            // 
            // TxtElektirik
            // 
            this.TxtElektirik.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtElektirik.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtElektirik.Location = new System.Drawing.Point(110, 33);
            this.TxtElektirik.Name = "TxtElektirik";
            this.TxtElektirik.Size = new System.Drawing.Size(200, 25);
            this.TxtElektirik.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Su:";
            // 
            // TxtSu
            // 
            this.TxtSu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtSu.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSu.Location = new System.Drawing.Point(110, 77);
            this.TxtSu.Name = "TxtSu";
            this.TxtSu.Size = new System.Drawing.Size(200, 25);
            this.TxtSu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Doğal Gaz:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtDogalGaz
            // 
            this.TxtDogalGaz.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtDogalGaz.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDogalGaz.Location = new System.Drawing.Point(110, 126);
            this.TxtDogalGaz.Name = "TxtDogalGaz";
            this.TxtDogalGaz.Size = new System.Drawing.Size(200, 25);
            this.TxtDogalGaz.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "İnternet:";
            // 
            // TxtInternet
            // 
            this.TxtInternet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtInternet.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtInternet.Location = new System.Drawing.Point(110, 169);
            this.TxtInternet.Name = "TxtInternet";
            this.TxtInternet.Size = new System.Drawing.Size(200, 25);
            this.TxtInternet.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(54, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gıda:";
            // 
            // TxtGıda
            // 
            this.TxtGıda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtGıda.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtGıda.Location = new System.Drawing.Point(110, 218);
            this.TxtGıda.Name = "TxtGıda";
            this.TxtGıda.Size = new System.Drawing.Size(200, 25);
            this.TxtGıda.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(49, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Diğer:";
            // 
            // TxtDiger
            // 
            this.TxtDiger.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtDiger.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDiger.Location = new System.Drawing.Point(110, 318);
            this.TxtDiger.Name = "TxtDiger";
            this.TxtDiger.Size = new System.Drawing.Size(200, 25);
            this.TxtDiger.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(24, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Personel:";
            // 
            // TxtPersonel
            // 
            this.TxtPersonel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtPersonel.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonel.Location = new System.Drawing.Point(110, 267);
            this.TxtPersonel.Name = "TxtPersonel";
            this.TxtPersonel.Size = new System.Drawing.Size(200, 25);
            this.TxtPersonel.TabIndex = 6;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(161, 359);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(69, 70);
            this.btnKaydet.TabIndex = 18;
            this.btnKaydet.TabStop = false;
            this.toolTip1.SetToolTip(this.btnKaydet, "Kaydet");
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odemeidDataGridViewTextBoxColumn,
            this.elektirikDataGridViewTextBoxColumn,
            this.suDataGridViewTextBoxColumn,
            this.dogalgazDataGridViewTextBoxColumn,
            this.internetDataGridViewTextBoxColumn,
            this.gıdaDataGridViewTextBoxColumn,
            this.personelDataGridViewTextBoxColumn,
            this.digerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.giderlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(324, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 426);
            this.dataGridView1.TabIndex = 19;
            // 
            // odemeidDataGridViewTextBoxColumn
            // 
            this.odemeidDataGridViewTextBoxColumn.DataPropertyName = "Odemeid";
            this.odemeidDataGridViewTextBoxColumn.HeaderText = "Odemeid";
            this.odemeidDataGridViewTextBoxColumn.Name = "odemeidDataGridViewTextBoxColumn";
            this.odemeidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // elektirikDataGridViewTextBoxColumn
            // 
            this.elektirikDataGridViewTextBoxColumn.DataPropertyName = "Elektirik";
            this.elektirikDataGridViewTextBoxColumn.HeaderText = "Elektirik";
            this.elektirikDataGridViewTextBoxColumn.Name = "elektirikDataGridViewTextBoxColumn";
            // 
            // suDataGridViewTextBoxColumn
            // 
            this.suDataGridViewTextBoxColumn.DataPropertyName = "Su";
            this.suDataGridViewTextBoxColumn.HeaderText = "Su";
            this.suDataGridViewTextBoxColumn.Name = "suDataGridViewTextBoxColumn";
            // 
            // dogalgazDataGridViewTextBoxColumn
            // 
            this.dogalgazDataGridViewTextBoxColumn.DataPropertyName = "Dogalgaz";
            this.dogalgazDataGridViewTextBoxColumn.HeaderText = "Dogalgaz";
            this.dogalgazDataGridViewTextBoxColumn.Name = "dogalgazDataGridViewTextBoxColumn";
            // 
            // internetDataGridViewTextBoxColumn
            // 
            this.internetDataGridViewTextBoxColumn.DataPropertyName = "internet";
            this.internetDataGridViewTextBoxColumn.HeaderText = "internet";
            this.internetDataGridViewTextBoxColumn.Name = "internetDataGridViewTextBoxColumn";
            // 
            // gıdaDataGridViewTextBoxColumn
            // 
            this.gıdaDataGridViewTextBoxColumn.DataPropertyName = "Gıda";
            this.gıdaDataGridViewTextBoxColumn.HeaderText = "Gıda";
            this.gıdaDataGridViewTextBoxColumn.Name = "gıdaDataGridViewTextBoxColumn";
            // 
            // personelDataGridViewTextBoxColumn
            // 
            this.personelDataGridViewTextBoxColumn.DataPropertyName = "Personel";
            this.personelDataGridViewTextBoxColumn.HeaderText = "Personel";
            this.personelDataGridViewTextBoxColumn.Name = "personelDataGridViewTextBoxColumn";
            // 
            // digerDataGridViewTextBoxColumn
            // 
            this.digerDataGridViewTextBoxColumn.DataPropertyName = "Diger";
            this.digerDataGridViewTextBoxColumn.HeaderText = "Diger";
            this.digerDataGridViewTextBoxColumn.Name = "digerDataGridViewTextBoxColumn";
            // 
            // giderlerBindingSource
            // 
            this.giderlerBindingSource.DataMember = "Giderler";
            this.giderlerBindingSource.DataSource = this.yurtOtomasyonDataSet3;
            // 
            // yurtOtomasyonDataSet3
            // 
            this.yurtOtomasyonDataSet3.DataSetName = "YurtOtomasyonDataSet3";
            this.yurtOtomasyonDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giderlerTableAdapter
            // 
            this.giderlerTableAdapter.ClearBeforeFill = true;
            // 
            // FrmGiderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::YurtKayitSistemi.Properties.Resources.Giderler;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1170, 431);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtPersonel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtDiger);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtGıda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtInternet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDogalGaz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSu);
            this.Controls.Add(this.LblOgrAd);
            this.Controls.Add(this.TxtElektirik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGiderler";
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.FrmGiderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnKaydet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblOgrAd;
        private System.Windows.Forms.TextBox TxtElektirik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDogalGaz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtInternet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtGıda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDiger;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtPersonel;
        private System.Windows.Forms.PictureBox btnKaydet;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonDataSet3 yurtOtomasyonDataSet3;
        private System.Windows.Forms.BindingSource giderlerBindingSource;
        private YurtOtomasyonDataSet3TableAdapters.GiderlerTableAdapter giderlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elektirikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogalgazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gıdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn digerDataGridViewTextBoxColumn;
    }
}