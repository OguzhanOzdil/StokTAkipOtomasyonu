namespace Stok_Takip_Otomasyonu
{
    partial class form_UrunEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_UrunEkle));
            this.gbx_YeniUrun = new System.Windows.Forms.GroupBox();
            this.cbx_Kategori = new System.Windows.Forms.ComboBox();
            this.btn_YeniEkle = new System.Windows.Forms.Button();
            this.cbx_Marka = new System.Windows.Forms.ComboBox();
            this.lbl_YeniSatisFiyati = new System.Windows.Forms.Label();
            this.txt_YeniSatisFiyati = new System.Windows.Forms.TextBox();
            this.lbl_YeniAlisFiyati = new System.Windows.Forms.Label();
            this.txt_YeniUrunAdi = new System.Windows.Forms.TextBox();
            this.lbl_YeniMiktar = new System.Windows.Forms.Label();
            this.txt_YeniMiktar = new System.Windows.Forms.TextBox();
            this.lbl_YeniUrunAdi = new System.Windows.Forms.Label();
            this.lbl_YeniMarka = new System.Windows.Forms.Label();
            this.txt_YeniAlisFiyati = new System.Windows.Forms.TextBox();
            this.lbl_YeniKategori = new System.Windows.Forms.Label();
            this.lbl_YeniBarkodNo = new System.Windows.Forms.Label();
            this.txt_YeniBarkodNo = new System.Windows.Forms.TextBox();
            this.btn_UzerineEkle = new System.Windows.Forms.Button();
            this.txt_BarkodNo = new System.Windows.Forms.TextBox();
            this.lbl_BarkodNo = new System.Windows.Forms.Label();
            this.txt_Kategori = new System.Windows.Forms.TextBox();
            this.lbl_Kategori = new System.Windows.Forms.Label();
            this.txt_AlisFiyati = new System.Windows.Forms.TextBox();
            this.lbl_Marka = new System.Windows.Forms.Label();
            this.txt_Marka = new System.Windows.Forms.TextBox();
            this.lbl_UrunAdi = new System.Windows.Forms.Label();
            this.txt_Miktari = new System.Windows.Forms.TextBox();
            this.lbl_Miktari = new System.Windows.Forms.Label();
            this.txt_UrunAdi = new System.Windows.Forms.TextBox();
            this.lbl_AlisFiyati = new System.Windows.Forms.Label();
            this.txt_SatisFiyati = new System.Windows.Forms.TextBox();
            this.lbl_SatisFiyati = new System.Windows.Forms.Label();
            this.gbx_VarOlanUrun = new System.Windows.Forms.GroupBox();
            this.lbl_KayitliMiktarResult = new System.Windows.Forms.Label();
            this.lbl_KayitliMiktar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_KategoriEkle = new System.Windows.Forms.Button();
            this.btn_MarkaEkle = new System.Windows.Forms.Button();
            this.gbx_YeniUrun.SuspendLayout();
            this.gbx_VarOlanUrun.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_YeniUrun
            // 
            this.gbx_YeniUrun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbx_YeniUrun.BackColor = System.Drawing.Color.Transparent;
            this.gbx_YeniUrun.Controls.Add(this.cbx_Kategori);
            this.gbx_YeniUrun.Controls.Add(this.btn_YeniEkle);
            this.gbx_YeniUrun.Controls.Add(this.cbx_Marka);
            this.gbx_YeniUrun.Controls.Add(this.lbl_YeniSatisFiyati);
            this.gbx_YeniUrun.Controls.Add(this.txt_YeniSatisFiyati);
            this.gbx_YeniUrun.Controls.Add(this.lbl_YeniAlisFiyati);
            this.gbx_YeniUrun.Controls.Add(this.txt_YeniUrunAdi);
            this.gbx_YeniUrun.Controls.Add(this.lbl_YeniMiktar);
            this.gbx_YeniUrun.Controls.Add(this.txt_YeniMiktar);
            this.gbx_YeniUrun.Controls.Add(this.lbl_YeniUrunAdi);
            this.gbx_YeniUrun.Controls.Add(this.lbl_YeniMarka);
            this.gbx_YeniUrun.Controls.Add(this.txt_YeniAlisFiyati);
            this.gbx_YeniUrun.Controls.Add(this.lbl_YeniKategori);
            this.gbx_YeniUrun.Controls.Add(this.lbl_YeniBarkodNo);
            this.gbx_YeniUrun.Controls.Add(this.txt_YeniBarkodNo);
            this.gbx_YeniUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbx_YeniUrun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbx_YeniUrun.Location = new System.Drawing.Point(59, 88);
            this.gbx_YeniUrun.Name = "gbx_YeniUrun";
            this.gbx_YeniUrun.Size = new System.Drawing.Size(223, 341);
            this.gbx_YeniUrun.TabIndex = 0;
            this.gbx_YeniUrun.TabStop = false;
            this.gbx_YeniUrun.Text = "Yeni Ürün ";
            // 
            // cbx_Kategori
            // 
            this.cbx_Kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbx_Kategori.FormattingEnabled = true;
            this.cbx_Kategori.Location = new System.Drawing.Point(104, 70);
            this.cbx_Kategori.Name = "cbx_Kategori";
            this.cbx_Kategori.Size = new System.Drawing.Size(100, 21);
            this.cbx_Kategori.TabIndex = 2;
            this.cbx_Kategori.SelectedIndexChanged += new System.EventHandler(this.cbx_Kategori_SelectedIndexChanged);
            // 
            // btn_YeniEkle
            // 
            this.btn_YeniEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btn_YeniEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_YeniEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_YeniEkle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_YeniEkle.Location = new System.Drawing.Point(129, 301);
            this.btn_YeniEkle.Name = "btn_YeniEkle";
            this.btn_YeniEkle.Size = new System.Drawing.Size(75, 23);
            this.btn_YeniEkle.TabIndex = 2;
            this.btn_YeniEkle.Text = "Ekle";
            this.btn_YeniEkle.UseVisualStyleBackColor = false;
            this.btn_YeniEkle.Click += new System.EventHandler(this.btn_YeniEkle_Click);
            // 
            // cbx_Marka
            // 
            this.cbx_Marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbx_Marka.FormattingEnabled = true;
            this.cbx_Marka.Location = new System.Drawing.Point(104, 109);
            this.cbx_Marka.Name = "cbx_Marka";
            this.cbx_Marka.Size = new System.Drawing.Size(100, 21);
            this.cbx_Marka.TabIndex = 3;
            // 
            // lbl_YeniSatisFiyati
            // 
            this.lbl_YeniSatisFiyati.AutoSize = true;
            this.lbl_YeniSatisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_YeniSatisFiyati.Location = new System.Drawing.Point(18, 268);
            this.lbl_YeniSatisFiyati.Name = "lbl_YeniSatisFiyati";
            this.lbl_YeniSatisFiyati.Size = new System.Drawing.Size(57, 13);
            this.lbl_YeniSatisFiyati.TabIndex = 48;
            this.lbl_YeniSatisFiyati.Text = "Satış Fiyatı";
            // 
            // txt_YeniSatisFiyati
            // 
            this.txt_YeniSatisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_YeniSatisFiyati.Location = new System.Drawing.Point(104, 265);
            this.txt_YeniSatisFiyati.Name = "txt_YeniSatisFiyati";
            this.txt_YeniSatisFiyati.Size = new System.Drawing.Size(100, 20);
            this.txt_YeniSatisFiyati.TabIndex = 40;
            // 
            // lbl_YeniAlisFiyati
            // 
            this.lbl_YeniAlisFiyati.AutoSize = true;
            this.lbl_YeniAlisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_YeniAlisFiyati.Location = new System.Drawing.Point(18, 229);
            this.lbl_YeniAlisFiyati.Name = "lbl_YeniAlisFiyati";
            this.lbl_YeniAlisFiyati.Size = new System.Drawing.Size(50, 13);
            this.lbl_YeniAlisFiyati.TabIndex = 47;
            this.lbl_YeniAlisFiyati.Text = "Alış Fitayı";
            // 
            // txt_YeniUrunAdi
            // 
            this.txt_YeniUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_YeniUrunAdi.Location = new System.Drawing.Point(104, 148);
            this.txt_YeniUrunAdi.Name = "txt_YeniUrunAdi";
            this.txt_YeniUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.txt_YeniUrunAdi.TabIndex = 37;
            // 
            // lbl_YeniMiktar
            // 
            this.lbl_YeniMiktar.AutoSize = true;
            this.lbl_YeniMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_YeniMiktar.Location = new System.Drawing.Point(18, 190);
            this.lbl_YeniMiktar.Name = "lbl_YeniMiktar";
            this.lbl_YeniMiktar.Size = new System.Drawing.Size(38, 13);
            this.lbl_YeniMiktar.TabIndex = 46;
            this.lbl_YeniMiktar.Text = "Miktarı";
            // 
            // txt_YeniMiktar
            // 
            this.txt_YeniMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_YeniMiktar.Location = new System.Drawing.Point(104, 187);
            this.txt_YeniMiktar.Name = "txt_YeniMiktar";
            this.txt_YeniMiktar.Size = new System.Drawing.Size(100, 20);
            this.txt_YeniMiktar.TabIndex = 38;
            // 
            // lbl_YeniUrunAdi
            // 
            this.lbl_YeniUrunAdi.AutoSize = true;
            this.lbl_YeniUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_YeniUrunAdi.Location = new System.Drawing.Point(18, 151);
            this.lbl_YeniUrunAdi.Name = "lbl_YeniUrunAdi";
            this.lbl_YeniUrunAdi.Size = new System.Drawing.Size(48, 13);
            this.lbl_YeniUrunAdi.TabIndex = 45;
            this.lbl_YeniUrunAdi.Text = "Ürün Adı";
            // 
            // lbl_YeniMarka
            // 
            this.lbl_YeniMarka.AutoSize = true;
            this.lbl_YeniMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_YeniMarka.Location = new System.Drawing.Point(18, 112);
            this.lbl_YeniMarka.Name = "lbl_YeniMarka";
            this.lbl_YeniMarka.Size = new System.Drawing.Size(37, 13);
            this.lbl_YeniMarka.TabIndex = 44;
            this.lbl_YeniMarka.Text = "Marka";
            // 
            // txt_YeniAlisFiyati
            // 
            this.txt_YeniAlisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_YeniAlisFiyati.Location = new System.Drawing.Point(104, 226);
            this.txt_YeniAlisFiyati.Name = "txt_YeniAlisFiyati";
            this.txt_YeniAlisFiyati.Size = new System.Drawing.Size(100, 20);
            this.txt_YeniAlisFiyati.TabIndex = 39;
            // 
            // lbl_YeniKategori
            // 
            this.lbl_YeniKategori.AutoSize = true;
            this.lbl_YeniKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_YeniKategori.Location = new System.Drawing.Point(18, 73);
            this.lbl_YeniKategori.Name = "lbl_YeniKategori";
            this.lbl_YeniKategori.Size = new System.Drawing.Size(46, 13);
            this.lbl_YeniKategori.TabIndex = 43;
            this.lbl_YeniKategori.Text = "Kategori";
            // 
            // lbl_YeniBarkodNo
            // 
            this.lbl_YeniBarkodNo.AutoSize = true;
            this.lbl_YeniBarkodNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_YeniBarkodNo.Location = new System.Drawing.Point(18, 34);
            this.lbl_YeniBarkodNo.Name = "lbl_YeniBarkodNo";
            this.lbl_YeniBarkodNo.Size = new System.Drawing.Size(58, 13);
            this.lbl_YeniBarkodNo.TabIndex = 42;
            this.lbl_YeniBarkodNo.Text = "Barkod No";
            // 
            // txt_YeniBarkodNo
            // 
            this.txt_YeniBarkodNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_YeniBarkodNo.Location = new System.Drawing.Point(104, 31);
            this.txt_YeniBarkodNo.Name = "txt_YeniBarkodNo";
            this.txt_YeniBarkodNo.Size = new System.Drawing.Size(100, 20);
            this.txt_YeniBarkodNo.TabIndex = 41;
            // 
            // btn_UzerineEkle
            // 
            this.btn_UzerineEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btn_UzerineEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UzerineEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_UzerineEkle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_UzerineEkle.Location = new System.Drawing.Point(135, 301);
            this.btn_UzerineEkle.Name = "btn_UzerineEkle";
            this.btn_UzerineEkle.Size = new System.Drawing.Size(75, 23);
            this.btn_UzerineEkle.TabIndex = 3;
            this.btn_UzerineEkle.Text = "Üzerine Ekle";
            this.btn_UzerineEkle.UseVisualStyleBackColor = false;
            this.btn_UzerineEkle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // txt_BarkodNo
            // 
            this.txt_BarkodNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_BarkodNo.Location = new System.Drawing.Point(110, 31);
            this.txt_BarkodNo.Name = "txt_BarkodNo";
            this.txt_BarkodNo.Size = new System.Drawing.Size(100, 20);
            this.txt_BarkodNo.TabIndex = 27;
            this.txt_BarkodNo.TextChanged += new System.EventHandler(this.txt_BarkodNo_TextChanged);
            // 
            // lbl_BarkodNo
            // 
            this.lbl_BarkodNo.AutoSize = true;
            this.lbl_BarkodNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_BarkodNo.Location = new System.Drawing.Point(16, 34);
            this.lbl_BarkodNo.Name = "lbl_BarkodNo";
            this.lbl_BarkodNo.Size = new System.Drawing.Size(58, 13);
            this.lbl_BarkodNo.TabIndex = 28;
            this.lbl_BarkodNo.Text = "Barkod No";
            // 
            // txt_Kategori
            // 
            this.txt_Kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Kategori.Location = new System.Drawing.Point(110, 70);
            this.txt_Kategori.Name = "txt_Kategori";
            this.txt_Kategori.Size = new System.Drawing.Size(100, 20);
            this.txt_Kategori.TabIndex = 21;
            // 
            // lbl_Kategori
            // 
            this.lbl_Kategori.AutoSize = true;
            this.lbl_Kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kategori.Location = new System.Drawing.Point(16, 73);
            this.lbl_Kategori.Name = "lbl_Kategori";
            this.lbl_Kategori.Size = new System.Drawing.Size(46, 13);
            this.lbl_Kategori.TabIndex = 29;
            this.lbl_Kategori.Text = "Kategori";
            // 
            // txt_AlisFiyati
            // 
            this.txt_AlisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_AlisFiyati.Location = new System.Drawing.Point(110, 226);
            this.txt_AlisFiyati.Name = "txt_AlisFiyati";
            this.txt_AlisFiyati.Size = new System.Drawing.Size(100, 20);
            this.txt_AlisFiyati.TabIndex = 25;
            // 
            // lbl_Marka
            // 
            this.lbl_Marka.AutoSize = true;
            this.lbl_Marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Marka.Location = new System.Drawing.Point(16, 112);
            this.lbl_Marka.Name = "lbl_Marka";
            this.lbl_Marka.Size = new System.Drawing.Size(37, 13);
            this.lbl_Marka.TabIndex = 30;
            this.lbl_Marka.Text = "Marka";
            // 
            // txt_Marka
            // 
            this.txt_Marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Marka.Location = new System.Drawing.Point(110, 109);
            this.txt_Marka.Name = "txt_Marka";
            this.txt_Marka.Size = new System.Drawing.Size(100, 20);
            this.txt_Marka.TabIndex = 22;
            // 
            // lbl_UrunAdi
            // 
            this.lbl_UrunAdi.AutoSize = true;
            this.lbl_UrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_UrunAdi.Location = new System.Drawing.Point(16, 151);
            this.lbl_UrunAdi.Name = "lbl_UrunAdi";
            this.lbl_UrunAdi.Size = new System.Drawing.Size(48, 13);
            this.lbl_UrunAdi.TabIndex = 31;
            this.lbl_UrunAdi.Text = "Ürün Adı";
            // 
            // txt_Miktari
            // 
            this.txt_Miktari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Miktari.Location = new System.Drawing.Point(110, 185);
            this.txt_Miktari.Name = "txt_Miktari";
            this.txt_Miktari.Size = new System.Drawing.Size(100, 20);
            this.txt_Miktari.TabIndex = 24;
            // 
            // lbl_Miktari
            // 
            this.lbl_Miktari.AutoSize = true;
            this.lbl_Miktari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Miktari.Location = new System.Drawing.Point(16, 190);
            this.lbl_Miktari.Name = "lbl_Miktari";
            this.lbl_Miktari.Size = new System.Drawing.Size(90, 13);
            this.lbl_Miktari.TabIndex = 32;
            this.lbl_Miktari.Text = "Eklenecek Miktar";
            // 
            // txt_UrunAdi
            // 
            this.txt_UrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_UrunAdi.Location = new System.Drawing.Point(110, 148);
            this.txt_UrunAdi.Name = "txt_UrunAdi";
            this.txt_UrunAdi.Size = new System.Drawing.Size(100, 20);
            this.txt_UrunAdi.TabIndex = 23;
            // 
            // lbl_AlisFiyati
            // 
            this.lbl_AlisFiyati.AutoSize = true;
            this.lbl_AlisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AlisFiyati.Location = new System.Drawing.Point(16, 229);
            this.lbl_AlisFiyati.Name = "lbl_AlisFiyati";
            this.lbl_AlisFiyati.Size = new System.Drawing.Size(50, 13);
            this.lbl_AlisFiyati.TabIndex = 33;
            this.lbl_AlisFiyati.Text = "Alış Fitayı";
            // 
            // txt_SatisFiyati
            // 
            this.txt_SatisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_SatisFiyati.Location = new System.Drawing.Point(110, 265);
            this.txt_SatisFiyati.Name = "txt_SatisFiyati";
            this.txt_SatisFiyati.Size = new System.Drawing.Size(100, 20);
            this.txt_SatisFiyati.TabIndex = 26;
            // 
            // lbl_SatisFiyati
            // 
            this.lbl_SatisFiyati.AutoSize = true;
            this.lbl_SatisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_SatisFiyati.Location = new System.Drawing.Point(16, 268);
            this.lbl_SatisFiyati.Name = "lbl_SatisFiyati";
            this.lbl_SatisFiyati.Size = new System.Drawing.Size(57, 13);
            this.lbl_SatisFiyati.TabIndex = 34;
            this.lbl_SatisFiyati.Text = "Satış Fiyatı";
            // 
            // gbx_VarOlanUrun
            // 
            this.gbx_VarOlanUrun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_VarOlanUrun.BackColor = System.Drawing.Color.Transparent;
            this.gbx_VarOlanUrun.Controls.Add(this.lbl_KayitliMiktarResult);
            this.gbx_VarOlanUrun.Controls.Add(this.lbl_KayitliMiktar);
            this.gbx_VarOlanUrun.Controls.Add(this.txt_BarkodNo);
            this.gbx_VarOlanUrun.Controls.Add(this.btn_UzerineEkle);
            this.gbx_VarOlanUrun.Controls.Add(this.lbl_SatisFiyati);
            this.gbx_VarOlanUrun.Controls.Add(this.txt_AlisFiyati);
            this.gbx_VarOlanUrun.Controls.Add(this.lbl_Kategori);
            this.gbx_VarOlanUrun.Controls.Add(this.txt_SatisFiyati);
            this.gbx_VarOlanUrun.Controls.Add(this.lbl_Marka);
            this.gbx_VarOlanUrun.Controls.Add(this.lbl_AlisFiyati);
            this.gbx_VarOlanUrun.Controls.Add(this.txt_Kategori);
            this.gbx_VarOlanUrun.Controls.Add(this.txt_Marka);
            this.gbx_VarOlanUrun.Controls.Add(this.txt_UrunAdi);
            this.gbx_VarOlanUrun.Controls.Add(this.lbl_BarkodNo);
            this.gbx_VarOlanUrun.Controls.Add(this.lbl_Miktari);
            this.gbx_VarOlanUrun.Controls.Add(this.lbl_UrunAdi);
            this.gbx_VarOlanUrun.Controls.Add(this.txt_Miktari);
            this.gbx_VarOlanUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbx_VarOlanUrun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbx_VarOlanUrun.Location = new System.Drawing.Point(309, 88);
            this.gbx_VarOlanUrun.Name = "gbx_VarOlanUrun";
            this.gbx_VarOlanUrun.Size = new System.Drawing.Size(223, 341);
            this.gbx_VarOlanUrun.TabIndex = 49;
            this.gbx_VarOlanUrun.TabStop = false;
            this.gbx_VarOlanUrun.Text = "Var Olan Ürün ";
            // 
            // lbl_KayitliMiktarResult
            // 
            this.lbl_KayitliMiktarResult.AutoSize = true;
            this.lbl_KayitliMiktarResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KayitliMiktarResult.Location = new System.Drawing.Point(48, 306);
            this.lbl_KayitliMiktarResult.Name = "lbl_KayitliMiktarResult";
            this.lbl_KayitliMiktarResult.Size = new System.Drawing.Size(0, 13);
            this.lbl_KayitliMiktarResult.TabIndex = 36;
            // 
            // lbl_KayitliMiktar
            // 
            this.lbl_KayitliMiktar.AutoSize = true;
            this.lbl_KayitliMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KayitliMiktar.Location = new System.Drawing.Point(6, 306);
            this.lbl_KayitliMiktar.Name = "lbl_KayitliMiktar";
            this.lbl_KayitliMiktar.Size = new System.Drawing.Size(39, 13);
            this.lbl_KayitliMiktar.TabIndex = 35;
            this.lbl_KayitliMiktar.Text = "Miktar:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_KategoriEkle);
            this.panel1.Controls.Add(this.btn_MarkaEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 58);
            this.panel1.TabIndex = 50;
            // 
            // btn_KategoriEkle
            // 
            this.btn_KategoriEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_KategoriEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KategoriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_KategoriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KategoriEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_KategoriEkle.Location = new System.Drawing.Point(107, 12);
            this.btn_KategoriEkle.Name = "btn_KategoriEkle";
            this.btn_KategoriEkle.Size = new System.Drawing.Size(120, 36);
            this.btn_KategoriEkle.TabIndex = 1;
            this.btn_KategoriEkle.Text = "Kategori Ekle";
            this.btn_KategoriEkle.UseVisualStyleBackColor = false;
            this.btn_KategoriEkle.Click += new System.EventHandler(this.btn_KategoriEkle_Click);
            // 
            // btn_MarkaEkle
            // 
            this.btn_MarkaEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MarkaEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_MarkaEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MarkaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_MarkaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_MarkaEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_MarkaEkle.Location = new System.Drawing.Point(360, 12);
            this.btn_MarkaEkle.Name = "btn_MarkaEkle";
            this.btn_MarkaEkle.Size = new System.Drawing.Size(120, 36);
            this.btn_MarkaEkle.TabIndex = 2;
            this.btn_MarkaEkle.Text = "Marka Ekle";
            this.btn_MarkaEkle.UseVisualStyleBackColor = false;
            this.btn_MarkaEkle.Click += new System.EventHandler(this.btn_MarkaEkle_Click);
            // 
            // form_UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stok_Takip_Otomasyonu.Properties.Resources.pattern_369543_960_720;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(595, 478);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbx_VarOlanUrun);
            this.Controls.Add(this.gbx_YeniUrun);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_UrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Ekle";
            this.Load += new System.EventHandler(this.form_UrunEkle_Load);
            this.gbx_YeniUrun.ResumeLayout(false);
            this.gbx_YeniUrun.PerformLayout();
            this.gbx_VarOlanUrun.ResumeLayout(false);
            this.gbx_VarOlanUrun.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_YeniUrun;
        private System.Windows.Forms.ComboBox cbx_Kategori;
        private System.Windows.Forms.ComboBox cbx_Marka;
        private System.Windows.Forms.Label lbl_YeniSatisFiyati;
        private System.Windows.Forms.TextBox txt_YeniSatisFiyati;
        private System.Windows.Forms.Label lbl_YeniAlisFiyati;
        private System.Windows.Forms.TextBox txt_YeniUrunAdi;
        private System.Windows.Forms.Label lbl_YeniMiktar;
        private System.Windows.Forms.TextBox txt_YeniMiktar;
        private System.Windows.Forms.Label lbl_YeniUrunAdi;
        private System.Windows.Forms.Label lbl_YeniMarka;
        private System.Windows.Forms.TextBox txt_YeniAlisFiyati;
        private System.Windows.Forms.Label lbl_YeniKategori;
        private System.Windows.Forms.Label lbl_YeniBarkodNo;
        private System.Windows.Forms.TextBox txt_YeniBarkodNo;
        private System.Windows.Forms.Button btn_YeniEkle;
        private System.Windows.Forms.Button btn_UzerineEkle;
        private System.Windows.Forms.TextBox txt_BarkodNo;
        private System.Windows.Forms.Label lbl_BarkodNo;
        private System.Windows.Forms.TextBox txt_Kategori;
        private System.Windows.Forms.Label lbl_Kategori;
        private System.Windows.Forms.TextBox txt_AlisFiyati;
        private System.Windows.Forms.Label lbl_Marka;
        private System.Windows.Forms.TextBox txt_Marka;
        private System.Windows.Forms.Label lbl_UrunAdi;
        private System.Windows.Forms.TextBox txt_Miktari;
        private System.Windows.Forms.Label lbl_Miktari;
        private System.Windows.Forms.TextBox txt_UrunAdi;
        private System.Windows.Forms.Label lbl_AlisFiyati;
        private System.Windows.Forms.TextBox txt_SatisFiyati;
        private System.Windows.Forms.Label lbl_SatisFiyati;
        private System.Windows.Forms.GroupBox gbx_VarOlanUrun;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_KategoriEkle;
        private System.Windows.Forms.Button btn_MarkaEkle;
        private System.Windows.Forms.Label lbl_KayitliMiktarResult;
        private System.Windows.Forms.Label lbl_KayitliMiktar;
    }
}