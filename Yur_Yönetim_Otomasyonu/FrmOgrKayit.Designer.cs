
namespace YurtKayitSistemi
{
    partial class FrmOgrKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrKayit));
            this.TxtOgrAd = new System.Windows.Forms.TextBox();
            this.LblOgrAd = new System.Windows.Forms.Label();
            this.LblOgrSoyad = new System.Windows.Forms.Label();
            this.TxtOgrSoyad = new System.Windows.Forms.TextBox();
            this.LblOgrTc = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.MskOgrTelefon = new System.Windows.Forms.MaskedTextBox();
            this.LblOgrTelefon = new System.Windows.Forms.Label();
            this.MskDogum = new System.Windows.Forms.MaskedTextBox();
            this.LblOgrDogum = new System.Windows.Forms.Label();
            this.LblOgrBolum = new System.Windows.Forms.Label();
            this.CmbBolum = new System.Windows.Forms.ComboBox();
            this.LblOgrMail = new System.Windows.Forms.Label();
            this.CmbOdaNo = new System.Windows.Forms.ComboBox();
            this.LblOgrOdaNo = new System.Windows.Forms.Label();
            this.LblVeliAdSoyad = new System.Windows.Forms.Label();
            this.TxtVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.LblVeliTelefon = new System.Windows.Forms.Label();
            this.MskVeliTelefon = new System.Windows.Forms.MaskedTextBox();
            this.LblAdres = new System.Windows.Forms.Label();
            this.RchAdres = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrDogumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrBolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrOdaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrVeliTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrVeliAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonDataSet1 = new YurtKayitSistemi.YurtOtomasyonDataSet1();
            this.ogrenciTableAdapter = new YurtKayitSistemi.YurtOtomasyonDataSet1TableAdapters.OgrenciTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOgrid = new System.Windows.Forms.TextBox();
            this.PcbOgrSil = new System.Windows.Forms.PictureBox();
            this.PcbOgrAdd = new System.Windows.Forms.PictureBox();
            this.PcbOgrGuncelle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbOgrSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbOgrAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbOgrGuncelle)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtOgrAd
            // 
            this.TxtOgrAd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtOgrAd.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrAd.Location = new System.Drawing.Point(128, 98);
            this.TxtOgrAd.Name = "TxtOgrAd";
            this.TxtOgrAd.Size = new System.Drawing.Size(200, 25);
            this.TxtOgrAd.TabIndex = 1;
            // 
            // LblOgrAd
            // 
            this.LblOgrAd.AutoSize = true;
            this.LblOgrAd.BackColor = System.Drawing.Color.Transparent;
            this.LblOgrAd.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOgrAd.Location = new System.Drawing.Point(34, 101);
            this.LblOgrAd.Name = "LblOgrAd";
            this.LblOgrAd.Size = new System.Drawing.Size(88, 18);
            this.LblOgrAd.TabIndex = 1;
            this.LblOgrAd.Text = "Öğrenci Ad:";
            this.LblOgrAd.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblOgrSoyad
            // 
            this.LblOgrSoyad.AutoSize = true;
            this.LblOgrSoyad.BackColor = System.Drawing.Color.Transparent;
            this.LblOgrSoyad.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOgrSoyad.Location = new System.Drawing.Point(11, 139);
            this.LblOgrSoyad.Name = "LblOgrSoyad";
            this.LblOgrSoyad.Size = new System.Drawing.Size(110, 18);
            this.LblOgrSoyad.TabIndex = 3;
            this.LblOgrSoyad.Text = "Öğrenci Soyad:";
            // 
            // TxtOgrSoyad
            // 
            this.TxtOgrSoyad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtOgrSoyad.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrSoyad.Location = new System.Drawing.Point(128, 139);
            this.TxtOgrSoyad.Name = "TxtOgrSoyad";
            this.TxtOgrSoyad.Size = new System.Drawing.Size(200, 25);
            this.TxtOgrSoyad.TabIndex = 2;
            // 
            // LblOgrTc
            // 
            this.LblOgrTc.AutoSize = true;
            this.LblOgrTc.BackColor = System.Drawing.Color.Transparent;
            this.LblOgrTc.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOgrTc.Location = new System.Drawing.Point(86, 170);
            this.LblOgrTc.Name = "LblOgrTc";
            this.LblOgrTc.Size = new System.Drawing.Size(36, 18);
            this.LblOgrTc.TabIndex = 5;
            this.LblOgrTc.Text = "T.C:";
            this.LblOgrTc.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TxtMail
            // 
            this.TxtMail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtMail.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.Location = new System.Drawing.Point(127, 328);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(200, 25);
            this.TxtMail.TabIndex = 7;
            this.TxtMail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MskTC
            // 
            this.MskTC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MskTC.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTC.Location = new System.Drawing.Point(128, 170);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(199, 26);
            this.MskTC.TabIndex = 3;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // MskOgrTelefon
            // 
            this.MskOgrTelefon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MskOgrTelefon.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskOgrTelefon.Location = new System.Drawing.Point(128, 202);
            this.MskOgrTelefon.Mask = "(999) 000-0000";
            this.MskOgrTelefon.Name = "MskOgrTelefon";
            this.MskOgrTelefon.Size = new System.Drawing.Size(199, 26);
            this.MskOgrTelefon.TabIndex = 4;
            // 
            // LblOgrTelefon
            // 
            this.LblOgrTelefon.AutoSize = true;
            this.LblOgrTelefon.BackColor = System.Drawing.Color.Transparent;
            this.LblOgrTelefon.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOgrTelefon.Location = new System.Drawing.Point(59, 205);
            this.LblOgrTelefon.Name = "LblOgrTelefon";
            this.LblOgrTelefon.Size = new System.Drawing.Size(62, 18);
            this.LblOgrTelefon.TabIndex = 7;
            this.LblOgrTelefon.Text = "Telefon:";
            this.LblOgrTelefon.Click += new System.EventHandler(this.LblOgrTelefon_Click);
            // 
            // MskDogum
            // 
            this.MskDogum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MskDogum.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskDogum.Location = new System.Drawing.Point(128, 244);
            this.MskDogum.Mask = "00/00/0000";
            this.MskDogum.Name = "MskDogum";
            this.MskDogum.Size = new System.Drawing.Size(199, 26);
            this.MskDogum.TabIndex = 5;
            this.MskDogum.ValidatingType = typeof(System.DateTime);
            // 
            // LblOgrDogum
            // 
            this.LblOgrDogum.AutoSize = true;
            this.LblOgrDogum.BackColor = System.Drawing.Color.Transparent;
            this.LblOgrDogum.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOgrDogum.Location = new System.Drawing.Point(15, 247);
            this.LblOgrDogum.Name = "LblOgrDogum";
            this.LblOgrDogum.Size = new System.Drawing.Size(107, 18);
            this.LblOgrDogum.TabIndex = 9;
            this.LblOgrDogum.Text = "Doğum Tarihi:";
            // 
            // LblOgrBolum
            // 
            this.LblOgrBolum.AutoSize = true;
            this.LblOgrBolum.BackColor = System.Drawing.Color.Transparent;
            this.LblOgrBolum.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOgrBolum.Location = new System.Drawing.Point(7, 289);
            this.LblOgrBolum.Name = "LblOgrBolum";
            this.LblOgrBolum.Size = new System.Drawing.Size(115, 18);
            this.LblOgrBolum.TabIndex = 11;
            this.LblOgrBolum.Text = "Öğrenci Bölüm:";
            // 
            // CmbBolum
            // 
            this.CmbBolum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CmbBolum.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbBolum.FormattingEnabled = true;
            this.CmbBolum.Location = new System.Drawing.Point(128, 286);
            this.CmbBolum.Name = "CmbBolum";
            this.CmbBolum.Size = new System.Drawing.Size(199, 26);
            this.CmbBolum.TabIndex = 6;
            // 
            // LblOgrMail
            // 
            this.LblOgrMail.AutoSize = true;
            this.LblOgrMail.BackColor = System.Drawing.Color.Transparent;
            this.LblOgrMail.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOgrMail.Location = new System.Drawing.Point(78, 328);
            this.LblOgrMail.Name = "LblOgrMail";
            this.LblOgrMail.Size = new System.Drawing.Size(43, 18);
            this.LblOgrMail.TabIndex = 13;
            this.LblOgrMail.Text = "Mail:";
            // 
            // CmbOdaNo
            // 
            this.CmbOdaNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CmbOdaNo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbOdaNo.FormattingEnabled = true;
            this.CmbOdaNo.Location = new System.Drawing.Point(127, 370);
            this.CmbOdaNo.Name = "CmbOdaNo";
            this.CmbOdaNo.Size = new System.Drawing.Size(199, 26);
            this.CmbOdaNo.TabIndex = 8;
            // 
            // LblOgrOdaNo
            // 
            this.LblOgrOdaNo.AutoSize = true;
            this.LblOgrOdaNo.BackColor = System.Drawing.Color.Transparent;
            this.LblOgrOdaNo.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOgrOdaNo.Location = new System.Drawing.Point(54, 373);
            this.LblOgrOdaNo.Name = "LblOgrOdaNo";
            this.LblOgrOdaNo.Size = new System.Drawing.Size(65, 18);
            this.LblOgrOdaNo.TabIndex = 14;
            this.LblOgrOdaNo.Text = "Oda No:";
            // 
            // LblVeliAdSoyad
            // 
            this.LblVeliAdSoyad.AutoSize = true;
            this.LblVeliAdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.LblVeliAdSoyad.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblVeliAdSoyad.Location = new System.Drawing.Point(15, 405);
            this.LblVeliAdSoyad.Name = "LblVeliAdSoyad";
            this.LblVeliAdSoyad.Size = new System.Drawing.Size(104, 18);
            this.LblVeliAdSoyad.TabIndex = 17;
            this.LblVeliAdSoyad.Text = "Veli Ad Soyad:";
            // 
            // TxtVeliAdSoyad
            // 
            this.TxtVeliAdSoyad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtVeliAdSoyad.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtVeliAdSoyad.Location = new System.Drawing.Point(124, 402);
            this.TxtVeliAdSoyad.Name = "TxtVeliAdSoyad";
            this.TxtVeliAdSoyad.Size = new System.Drawing.Size(200, 25);
            this.TxtVeliAdSoyad.TabIndex = 9;
            // 
            // LblVeliTelefon
            // 
            this.LblVeliTelefon.AutoSize = true;
            this.LblVeliTelefon.BackColor = System.Drawing.Color.Transparent;
            this.LblVeliTelefon.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblVeliTelefon.Location = new System.Drawing.Point(28, 441);
            this.LblVeliTelefon.Name = "LblVeliTelefon";
            this.LblVeliTelefon.Size = new System.Drawing.Size(91, 18);
            this.LblVeliTelefon.TabIndex = 19;
            this.LblVeliTelefon.Text = "Veli Telefon:";
            // 
            // MskVeliTelefon
            // 
            this.MskVeliTelefon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MskVeliTelefon.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskVeliTelefon.Location = new System.Drawing.Point(124, 438);
            this.MskVeliTelefon.Mask = "(999) 000-0000";
            this.MskVeliTelefon.Name = "MskVeliTelefon";
            this.MskVeliTelefon.Size = new System.Drawing.Size(199, 26);
            this.MskVeliTelefon.TabIndex = 10;
            // 
            // LblAdres
            // 
            this.LblAdres.AutoSize = true;
            this.LblAdres.BackColor = System.Drawing.Color.Transparent;
            this.LblAdres.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAdres.Location = new System.Drawing.Point(68, 477);
            this.LblAdres.Name = "LblAdres";
            this.LblAdres.Size = new System.Drawing.Size(50, 18);
            this.LblAdres.TabIndex = 21;
            this.LblAdres.Text = "Adres:";
            // 
            // RchAdres
            // 
            this.RchAdres.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RchAdres.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RchAdres.Location = new System.Drawing.Point(124, 478);
            this.RchAdres.Name = "RchAdres";
            this.RchAdres.Size = new System.Drawing.Size(199, 96);
            this.RchAdres.TabIndex = 11;
            this.RchAdres.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogridDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrTcDataGridViewTextBoxColumn,
            this.ogrTelefonDataGridViewTextBoxColumn,
            this.ogrDogumDataGridViewTextBoxColumn,
            this.ogrBolumDataGridViewTextBoxColumn,
            this.ogrMailDataGridViewTextBoxColumn,
            this.ogrOdaNoDataGridViewTextBoxColumn,
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn,
            this.ogrVeliTelefonDataGridViewTextBoxColumn,
            this.ogrVeliAdresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(329, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(915, 565);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ogridDataGridViewTextBoxColumn
            // 
            this.ogridDataGridViewTextBoxColumn.DataPropertyName = "Ogrid";
            this.ogridDataGridViewTextBoxColumn.HeaderText = "Ogrid";
            this.ogridDataGridViewTextBoxColumn.Name = "ogridDataGridViewTextBoxColumn";
            this.ogridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            // 
            // ogrTcDataGridViewTextBoxColumn
            // 
            this.ogrTcDataGridViewTextBoxColumn.DataPropertyName = "OgrTc";
            this.ogrTcDataGridViewTextBoxColumn.HeaderText = "OgrTc";
            this.ogrTcDataGridViewTextBoxColumn.Name = "ogrTcDataGridViewTextBoxColumn";
            // 
            // ogrTelefonDataGridViewTextBoxColumn
            // 
            this.ogrTelefonDataGridViewTextBoxColumn.DataPropertyName = "OgrTelefon";
            this.ogrTelefonDataGridViewTextBoxColumn.HeaderText = "OgrTelefon";
            this.ogrTelefonDataGridViewTextBoxColumn.Name = "ogrTelefonDataGridViewTextBoxColumn";
            // 
            // ogrDogumDataGridViewTextBoxColumn
            // 
            this.ogrDogumDataGridViewTextBoxColumn.DataPropertyName = "OgrDogum";
            this.ogrDogumDataGridViewTextBoxColumn.HeaderText = "OgrDogum";
            this.ogrDogumDataGridViewTextBoxColumn.Name = "ogrDogumDataGridViewTextBoxColumn";
            // 
            // ogrBolumDataGridViewTextBoxColumn
            // 
            this.ogrBolumDataGridViewTextBoxColumn.DataPropertyName = "OgrBolum";
            this.ogrBolumDataGridViewTextBoxColumn.HeaderText = "OgrBolum";
            this.ogrBolumDataGridViewTextBoxColumn.Name = "ogrBolumDataGridViewTextBoxColumn";
            // 
            // ogrMailDataGridViewTextBoxColumn
            // 
            this.ogrMailDataGridViewTextBoxColumn.DataPropertyName = "OgrMail";
            this.ogrMailDataGridViewTextBoxColumn.HeaderText = "OgrMail";
            this.ogrMailDataGridViewTextBoxColumn.Name = "ogrMailDataGridViewTextBoxColumn";
            // 
            // ogrOdaNoDataGridViewTextBoxColumn
            // 
            this.ogrOdaNoDataGridViewTextBoxColumn.DataPropertyName = "OgrOdaNo";
            this.ogrOdaNoDataGridViewTextBoxColumn.HeaderText = "OgrOdaNo";
            this.ogrOdaNoDataGridViewTextBoxColumn.Name = "ogrOdaNoDataGridViewTextBoxColumn";
            // 
            // ogrVeliAdSoyadDataGridViewTextBoxColumn
            // 
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrVeliAdSoyad";
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn.HeaderText = "OgrVeliAdSoyad";
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn.Name = "ogrVeliAdSoyadDataGridViewTextBoxColumn";
            // 
            // ogrVeliTelefonDataGridViewTextBoxColumn
            // 
            this.ogrVeliTelefonDataGridViewTextBoxColumn.DataPropertyName = "OgrVeliTelefon";
            this.ogrVeliTelefonDataGridViewTextBoxColumn.HeaderText = "OgrVeliTelefon";
            this.ogrVeliTelefonDataGridViewTextBoxColumn.Name = "ogrVeliTelefonDataGridViewTextBoxColumn";
            // 
            // ogrVeliAdresDataGridViewTextBoxColumn
            // 
            this.ogrVeliAdresDataGridViewTextBoxColumn.DataPropertyName = "OgrVeliAdres";
            this.ogrVeliAdresDataGridViewTextBoxColumn.HeaderText = "OgrVeliAdres";
            this.ogrVeliAdresDataGridViewTextBoxColumn.Name = "ogrVeliAdresDataGridViewTextBoxColumn";
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            this.ogrenciBindingSource.DataSource = this.yurtOtomasyonDataSet1;
            // 
            // yurtOtomasyonDataSet1
            // 
            this.yurtOtomasyonDataSet1.DataSetName = "YurtOtomasyonDataSet1";
            this.yurtOtomasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 570);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = ".";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Öğrenci Id:";
            // 
            // TxtOgrid
            // 
            this.TxtOgrid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtOgrid.Enabled = false;
            this.TxtOgrid.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrid.Location = new System.Drawing.Point(128, 67);
            this.TxtOgrid.Name = "TxtOgrid";
            this.TxtOgrid.Size = new System.Drawing.Size(200, 25);
            this.TxtOgrid.TabIndex = 46;
            // 
            // PcbOgrSil
            // 
            this.PcbOgrSil.BackColor = System.Drawing.Color.Transparent;
            this.PcbOgrSil.Image = ((System.Drawing.Image)(resources.GetObject("PcbOgrSil.Image")));
            this.PcbOgrSil.Location = new System.Drawing.Point(274, 12);
            this.PcbOgrSil.Name = "PcbOgrSil";
            this.PcbOgrSil.Size = new System.Drawing.Size(36, 36);
            this.PcbOgrSil.TabIndex = 28;
            this.PcbOgrSil.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbOgrSil, "Kaldır");
            this.PcbOgrSil.Click += new System.EventHandler(this.PcbOgrSil_Click);
            // 
            // PcbOgrAdd
            // 
            this.PcbOgrAdd.BackColor = System.Drawing.Color.Transparent;
            this.PcbOgrAdd.Image = ((System.Drawing.Image)(resources.GetObject("PcbOgrAdd.Image")));
            this.PcbOgrAdd.Location = new System.Drawing.Point(126, 12);
            this.PcbOgrAdd.Name = "PcbOgrAdd";
            this.PcbOgrAdd.Size = new System.Drawing.Size(36, 42);
            this.PcbOgrAdd.TabIndex = 27;
            this.PcbOgrAdd.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbOgrAdd, "Ekle");
            this.PcbOgrAdd.Click += new System.EventHandler(this.PcbOgrAdd_Click);
            // 
            // PcbOgrGuncelle
            // 
            this.PcbOgrGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.PcbOgrGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("PcbOgrGuncelle.Image")));
            this.PcbOgrGuncelle.Location = new System.Drawing.Point(205, 12);
            this.PcbOgrGuncelle.Name = "PcbOgrGuncelle";
            this.PcbOgrGuncelle.Size = new System.Drawing.Size(38, 36);
            this.PcbOgrGuncelle.TabIndex = 26;
            this.PcbOgrGuncelle.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbOgrGuncelle, "Güncelle");
            this.PcbOgrGuncelle.Click += new System.EventHandler(this.PcbOgrGuncelle_Click);
            // 
            // FrmOgrKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YurtKayitSistemi.Properties.Resources.ogrenci;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1246, 584);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtOgrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PcbOgrSil);
            this.Controls.Add(this.PcbOgrAdd);
            this.Controls.Add(this.PcbOgrGuncelle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RchAdres);
            this.Controls.Add(this.LblAdres);
            this.Controls.Add(this.MskVeliTelefon);
            this.Controls.Add(this.LblVeliTelefon);
            this.Controls.Add(this.LblVeliAdSoyad);
            this.Controls.Add(this.TxtVeliAdSoyad);
            this.Controls.Add(this.CmbOdaNo);
            this.Controls.Add(this.LblOgrOdaNo);
            this.Controls.Add(this.LblOgrMail);
            this.Controls.Add(this.CmbBolum);
            this.Controls.Add(this.LblOgrBolum);
            this.Controls.Add(this.MskDogum);
            this.Controls.Add(this.LblOgrDogum);
            this.Controls.Add(this.MskOgrTelefon);
            this.Controls.Add(this.LblOgrTelefon);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.LblOgrTc);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.LblOgrSoyad);
            this.Controls.Add(this.TxtOgrSoyad);
            this.Controls.Add(this.LblOgrAd);
            this.Controls.Add(this.TxtOgrAd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgrKayit";
            this.Text = "Öğrenci Kayıt";
            this.Load += new System.EventHandler(this.FrmOgrKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbOgrSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbOgrAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbOgrGuncelle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtOgrAd;
        private System.Windows.Forms.Label LblOgrAd;
        private System.Windows.Forms.Label LblOgrSoyad;
        private System.Windows.Forms.TextBox TxtOgrSoyad;
        private System.Windows.Forms.Label LblOgrTc;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.MaskedTextBox MskOgrTelefon;
        private System.Windows.Forms.Label LblOgrTelefon;
        private System.Windows.Forms.MaskedTextBox MskDogum;
        private System.Windows.Forms.Label LblOgrDogum;
        private System.Windows.Forms.Label LblOgrBolum;
        private System.Windows.Forms.ComboBox CmbBolum;
        private System.Windows.Forms.Label LblOgrMail;
        private System.Windows.Forms.ComboBox CmbOdaNo;
        private System.Windows.Forms.Label LblOgrOdaNo;
        private System.Windows.Forms.Label LblVeliAdSoyad;
        private System.Windows.Forms.TextBox TxtVeliAdSoyad;
        private System.Windows.Forms.Label LblVeliTelefon;
        private System.Windows.Forms.MaskedTextBox MskVeliTelefon;
        private System.Windows.Forms.Label LblAdres;
        private System.Windows.Forms.RichTextBox RchAdres;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox PcbOgrGuncelle;
        private System.Windows.Forms.PictureBox PcbOgrAdd;
        private System.Windows.Forms.PictureBox PcbOgrSil;
        private YurtOtomasyonDataSet1 yurtOtomasyonDataSet1;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private YurtOtomasyonDataSet1TableAdapters.OgrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrDogumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrBolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrOdaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrVeliAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrVeliTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrVeliAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOgrid;
    }
}

