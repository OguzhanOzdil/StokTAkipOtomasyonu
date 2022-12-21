namespace Stok_Takip_Otomasyonu
{
    partial class form_SatisSayfasi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_SatisSayfasi));
            this.btn_MusteriEkle = new System.Windows.Forms.Button();
            this.btn_MusteriListele = new System.Windows.Forms.Button();
            this.btn_UrunEkle = new System.Windows.Forms.Button();
            this.btn_UrunListele = new System.Windows.Forms.Button();
            this.btn_SatisListele = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Satisİptal = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_SatisYap = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbx_MusteriIslemleri = new System.Windows.Forms.GroupBox();
            this.txt_TC = new System.Windows.Forms.TextBox();
            this.txt_Telefon = new System.Windows.Forms.TextBox();
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            this.lbl_TC = new System.Windows.Forms.Label();
            this.lbl_AdSoyad = new System.Windows.Forms.Label();
            this.lbl_Telefon = new System.Windows.Forms.Label();
            this.gbx_UrunIslemleri = new System.Windows.Forms.GroupBox();
            this.txt_ToplamFiyat = new System.Windows.Forms.TextBox();
            this.txt_SatisFiyati = new System.Windows.Forms.TextBox();
            this.lbl_ToplamFiyat = new System.Windows.Forms.Label();
            this.txt_Miktari = new System.Windows.Forms.TextBox();
            this.lbl_SatisFiyati = new System.Windows.Forms.Label();
            this.txt_UrunAdi = new System.Windows.Forms.TextBox();
            this.lbl_Miktari = new System.Windows.Forms.Label();
            this.txt_BarkodNo = new System.Windows.Forms.TextBox();
            this.lbl_UrunAdi = new System.Windows.Forms.Label();
            this.lbl_BarkodNo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_GenelToplam = new System.Windows.Forms.Label();
            this.lbl_GenelToplamResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbx_MusteriIslemleri.SuspendLayout();
            this.gbx_UrunIslemleri.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_MusteriEkle
            // 
            this.btn_MusteriEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_MusteriEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MusteriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_MusteriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_MusteriEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_MusteriEkle.Location = new System.Drawing.Point(12, 12);
            this.btn_MusteriEkle.Name = "btn_MusteriEkle";
            this.btn_MusteriEkle.Size = new System.Drawing.Size(120, 36);
            this.btn_MusteriEkle.TabIndex = 0;
            this.btn_MusteriEkle.Text = "Müşteri Ekle";
            this.btn_MusteriEkle.UseVisualStyleBackColor = false;
            this.btn_MusteriEkle.Click += new System.EventHandler(this.btn_MusteriEkle_Click);
            // 
            // btn_MusteriListele
            // 
            this.btn_MusteriListele.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_MusteriListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MusteriListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_MusteriListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_MusteriListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_MusteriListele.Location = new System.Drawing.Point(138, 12);
            this.btn_MusteriListele.Name = "btn_MusteriListele";
            this.btn_MusteriListele.Size = new System.Drawing.Size(120, 36);
            this.btn_MusteriListele.TabIndex = 1;
            this.btn_MusteriListele.Text = "Müşteri Listele";
            this.btn_MusteriListele.UseVisualStyleBackColor = false;
            this.btn_MusteriListele.Click += new System.EventHandler(this.btn_MusteriListele_Click);
            // 
            // btn_UrunEkle
            // 
            this.btn_UrunEkle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_UrunEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_UrunEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_UrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_UrunEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_UrunEkle.Location = new System.Drawing.Point(368, 12);
            this.btn_UrunEkle.Name = "btn_UrunEkle";
            this.btn_UrunEkle.Size = new System.Drawing.Size(120, 36);
            this.btn_UrunEkle.TabIndex = 2;
            this.btn_UrunEkle.Text = "Ürün Ekle";
            this.btn_UrunEkle.UseVisualStyleBackColor = false;
            this.btn_UrunEkle.Click += new System.EventHandler(this.btn_UrunEkle_Click);
            // 
            // btn_UrunListele
            // 
            this.btn_UrunListele.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_UrunListele.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_UrunListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UrunListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_UrunListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_UrunListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_UrunListele.Location = new System.Drawing.Point(494, 12);
            this.btn_UrunListele.Name = "btn_UrunListele";
            this.btn_UrunListele.Size = new System.Drawing.Size(120, 36);
            this.btn_UrunListele.TabIndex = 3;
            this.btn_UrunListele.Text = "Ürün Listele";
            this.btn_UrunListele.UseVisualStyleBackColor = false;
            this.btn_UrunListele.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_SatisListele
            // 
            this.btn_SatisListele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SatisListele.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_SatisListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SatisListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SatisListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SatisListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_SatisListele.Location = new System.Drawing.Point(746, 12);
            this.btn_SatisListele.Name = "btn_SatisListele";
            this.btn_SatisListele.Size = new System.Drawing.Size(120, 36);
            this.btn_SatisListele.TabIndex = 4;
            this.btn_SatisListele.Text = "Satış Listele";
            this.btn_SatisListele.UseVisualStyleBackColor = false;
            this.btn_SatisListele.Click += new System.EventHandler(this.btn_SiparisListele_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ekle.Location = new System.Drawing.Point(216, 417);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_Ekle.TabIndex = 5;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Satisİptal
            // 
            this.btn_Satisİptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Satisİptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Satisİptal.Location = new System.Drawing.Point(876, 116);
            this.btn_Satisİptal.Name = "btn_Satisİptal";
            this.btn_Satisİptal.Size = new System.Drawing.Size(75, 23);
            this.btn_Satisİptal.TabIndex = 6;
            this.btn_Satisİptal.Text = "Satış İptal";
            this.btn_Satisİptal.UseVisualStyleBackColor = true;
            this.btn_Satisİptal.Click += new System.EventHandler(this.btn_Satisİptal_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sil.Location = new System.Drawing.Point(876, 78);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(75, 23);
            this.btn_Sil.TabIndex = 7;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_SatisYap
            // 
            this.btn_SatisYap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SatisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SatisYap.Location = new System.Drawing.Point(791, 417);
            this.btn_SatisYap.Name = "btn_SatisYap";
            this.btn_SatisYap.Size = new System.Drawing.Size(75, 23);
            this.btn_SatisYap.TabIndex = 8;
            this.btn_SatisYap.Text = "Satış Yap";
            this.btn_SatisYap.UseVisualStyleBackColor = true;
            this.btn_SatisYap.Click += new System.EventHandler(this.btn_SatisYap_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(216, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 327);
            this.dataGridView1.TabIndex = 9;
            // 
            // gbx_MusteriIslemleri
            // 
            this.gbx_MusteriIslemleri.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbx_MusteriIslemleri.BackColor = System.Drawing.Color.Transparent;
            this.gbx_MusteriIslemleri.Controls.Add(this.txt_TC);
            this.gbx_MusteriIslemleri.Controls.Add(this.txt_Telefon);
            this.gbx_MusteriIslemleri.Controls.Add(this.txt_AdSoyad);
            this.gbx_MusteriIslemleri.Controls.Add(this.lbl_TC);
            this.gbx_MusteriIslemleri.Controls.Add(this.lbl_AdSoyad);
            this.gbx_MusteriIslemleri.Controls.Add(this.lbl_Telefon);
            this.gbx_MusteriIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbx_MusteriIslemleri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbx_MusteriIslemleri.Location = new System.Drawing.Point(12, 84);
            this.gbx_MusteriIslemleri.Name = "gbx_MusteriIslemleri";
            this.gbx_MusteriIslemleri.Size = new System.Drawing.Size(200, 113);
            this.gbx_MusteriIslemleri.TabIndex = 10;
            this.gbx_MusteriIslemleri.TabStop = false;
            this.gbx_MusteriIslemleri.Text = "Müşteri İşlemleri ";
            // 
            // txt_TC
            // 
            this.txt_TC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_TC.Location = new System.Drawing.Point(84, 26);
            this.txt_TC.Name = "txt_TC";
            this.txt_TC.Size = new System.Drawing.Size(100, 20);
            this.txt_TC.TabIndex = 18;
            this.txt_TC.TextChanged += new System.EventHandler(this.txt_TC_TextChanged);
            // 
            // txt_Telefon
            // 
            this.txt_Telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Telefon.Location = new System.Drawing.Point(85, 76);
            this.txt_Telefon.Name = "txt_Telefon";
            this.txt_Telefon.Size = new System.Drawing.Size(100, 20);
            this.txt_Telefon.TabIndex = 17;
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_AdSoyad.Location = new System.Drawing.Point(85, 51);
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txt_AdSoyad.TabIndex = 16;
            // 
            // lbl_TC
            // 
            this.lbl_TC.AutoSize = true;
            this.lbl_TC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_TC.Location = new System.Drawing.Point(12, 29);
            this.lbl_TC.Name = "lbl_TC";
            this.lbl_TC.Size = new System.Drawing.Size(21, 13);
            this.lbl_TC.TabIndex = 13;
            this.lbl_TC.Text = "TC";
            // 
            // lbl_AdSoyad
            // 
            this.lbl_AdSoyad.AutoSize = true;
            this.lbl_AdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AdSoyad.Location = new System.Drawing.Point(12, 54);
            this.lbl_AdSoyad.Name = "lbl_AdSoyad";
            this.lbl_AdSoyad.Size = new System.Drawing.Size(53, 13);
            this.lbl_AdSoyad.TabIndex = 14;
            this.lbl_AdSoyad.Text = "Ad Soyad";
            // 
            // lbl_Telefon
            // 
            this.lbl_Telefon.AutoSize = true;
            this.lbl_Telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Telefon.Location = new System.Drawing.Point(12, 79);
            this.lbl_Telefon.Name = "lbl_Telefon";
            this.lbl_Telefon.Size = new System.Drawing.Size(43, 13);
            this.lbl_Telefon.TabIndex = 15;
            this.lbl_Telefon.Text = "Telefon";
            // 
            // gbx_UrunIslemleri
            // 
            this.gbx_UrunIslemleri.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbx_UrunIslemleri.BackColor = System.Drawing.Color.Transparent;
            this.gbx_UrunIslemleri.Controls.Add(this.txt_ToplamFiyat);
            this.gbx_UrunIslemleri.Controls.Add(this.txt_SatisFiyati);
            this.gbx_UrunIslemleri.Controls.Add(this.lbl_ToplamFiyat);
            this.gbx_UrunIslemleri.Controls.Add(this.txt_Miktari);
            this.gbx_UrunIslemleri.Controls.Add(this.lbl_SatisFiyati);
            this.gbx_UrunIslemleri.Controls.Add(this.txt_UrunAdi);
            this.gbx_UrunIslemleri.Controls.Add(this.lbl_Miktari);
            this.gbx_UrunIslemleri.Controls.Add(this.txt_BarkodNo);
            this.gbx_UrunIslemleri.Controls.Add(this.lbl_UrunAdi);
            this.gbx_UrunIslemleri.Controls.Add(this.lbl_BarkodNo);
            this.gbx_UrunIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbx_UrunIslemleri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbx_UrunIslemleri.Location = new System.Drawing.Point(12, 214);
            this.gbx_UrunIslemleri.Name = "gbx_UrunIslemleri";
            this.gbx_UrunIslemleri.Size = new System.Drawing.Size(200, 177);
            this.gbx_UrunIslemleri.TabIndex = 11;
            this.gbx_UrunIslemleri.TabStop = false;
            this.gbx_UrunIslemleri.Text = "Ürün İşlemleri ";
            // 
            // txt_ToplamFiyat
            // 
            this.txt_ToplamFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ToplamFiyat.Location = new System.Drawing.Point(84, 147);
            this.txt_ToplamFiyat.Name = "txt_ToplamFiyat";
            this.txt_ToplamFiyat.Size = new System.Drawing.Size(100, 20);
            this.txt_ToplamFiyat.TabIndex = 4;
            // 
            // txt_SatisFiyati
            // 
            this.txt_SatisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_SatisFiyati.Location = new System.Drawing.Point(85, 116);
            this.txt_SatisFiyati.Name = "txt_SatisFiyati";
            this.txt_SatisFiyati.Size = new System.Drawing.Size(100, 20);
            this.txt_SatisFiyati.TabIndex = 3;
            this.txt_SatisFiyati.TextChanged += new System.EventHandler(this.txt_SatisFiyati_TextChanged);
            // 
            // lbl_ToplamFiyat
            // 
            this.lbl_ToplamFiyat.AutoSize = true;
            this.lbl_ToplamFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ToplamFiyat.Location = new System.Drawing.Point(12, 150);
            this.lbl_ToplamFiyat.Name = "lbl_ToplamFiyat";
            this.lbl_ToplamFiyat.Size = new System.Drawing.Size(67, 13);
            this.lbl_ToplamFiyat.TabIndex = 20;
            this.lbl_ToplamFiyat.Text = "Toplam Fiyat";
            // 
            // txt_Miktari
            // 
            this.txt_Miktari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Miktari.Location = new System.Drawing.Point(84, 85);
            this.txt_Miktari.Name = "txt_Miktari";
            this.txt_Miktari.Size = new System.Drawing.Size(100, 20);
            this.txt_Miktari.TabIndex = 2;
            this.txt_Miktari.Text = "1";
            this.txt_Miktari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Miktari.TextChanged += new System.EventHandler(this.txt_Miktari_TextChanged);
            // 
            // lbl_SatisFiyati
            // 
            this.lbl_SatisFiyati.AutoSize = true;
            this.lbl_SatisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_SatisFiyati.Location = new System.Drawing.Point(12, 119);
            this.lbl_SatisFiyati.Name = "lbl_SatisFiyati";
            this.lbl_SatisFiyati.Size = new System.Drawing.Size(57, 13);
            this.lbl_SatisFiyati.TabIndex = 19;
            this.lbl_SatisFiyati.Text = "Satış Fiyatı";
            // 
            // txt_UrunAdi
            // 
            this.txt_UrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_UrunAdi.Location = new System.Drawing.Point(84, 54);
            this.txt_UrunAdi.Name = "txt_UrunAdi";
            this.txt_UrunAdi.Size = new System.Drawing.Size(100, 20);
            this.txt_UrunAdi.TabIndex = 1;
            // 
            // lbl_Miktari
            // 
            this.lbl_Miktari.AutoSize = true;
            this.lbl_Miktari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Miktari.Location = new System.Drawing.Point(12, 88);
            this.lbl_Miktari.Name = "lbl_Miktari";
            this.lbl_Miktari.Size = new System.Drawing.Size(38, 13);
            this.lbl_Miktari.TabIndex = 18;
            this.lbl_Miktari.Text = "Miktarı";
            // 
            // txt_BarkodNo
            // 
            this.txt_BarkodNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_BarkodNo.Location = new System.Drawing.Point(85, 23);
            this.txt_BarkodNo.Name = "txt_BarkodNo";
            this.txt_BarkodNo.Size = new System.Drawing.Size(100, 20);
            this.txt_BarkodNo.TabIndex = 0;
            this.txt_BarkodNo.TextChanged += new System.EventHandler(this.txt_BarkodNo_TextChanged);
            // 
            // lbl_UrunAdi
            // 
            this.lbl_UrunAdi.AutoSize = true;
            this.lbl_UrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_UrunAdi.Location = new System.Drawing.Point(12, 57);
            this.lbl_UrunAdi.Name = "lbl_UrunAdi";
            this.lbl_UrunAdi.Size = new System.Drawing.Size(48, 13);
            this.lbl_UrunAdi.TabIndex = 17;
            this.lbl_UrunAdi.Text = "Ürün Adı";
            // 
            // lbl_BarkodNo
            // 
            this.lbl_BarkodNo.AutoSize = true;
            this.lbl_BarkodNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_BarkodNo.Location = new System.Drawing.Point(12, 26);
            this.lbl_BarkodNo.Name = "lbl_BarkodNo";
            this.lbl_BarkodNo.Size = new System.Drawing.Size(58, 13);
            this.lbl_BarkodNo.TabIndex = 16;
            this.lbl_BarkodNo.Text = "Barkod No";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_UrunListele);
            this.panel1.Controls.Add(this.btn_MusteriEkle);
            this.panel1.Controls.Add(this.btn_MusteriListele);
            this.panel1.Controls.Add(this.btn_UrunEkle);
            this.panel1.Controls.Add(this.btn_SatisListele);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 58);
            this.panel1.TabIndex = 12;
            // 
            // lbl_GenelToplam
            // 
            this.lbl_GenelToplam.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_GenelToplam.AutoSize = true;
            this.lbl_GenelToplam.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GenelToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_GenelToplam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_GenelToplam.Location = new System.Drawing.Point(480, 420);
            this.lbl_GenelToplam.Name = "lbl_GenelToplam";
            this.lbl_GenelToplam.Size = new System.Drawing.Size(88, 15);
            this.lbl_GenelToplam.TabIndex = 21;
            this.lbl_GenelToplam.Text = "Genel Toplam:";
            // 
            // lbl_GenelToplamResult
            // 
            this.lbl_GenelToplamResult.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_GenelToplamResult.AutoSize = true;
            this.lbl_GenelToplamResult.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GenelToplamResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_GenelToplamResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_GenelToplamResult.Location = new System.Drawing.Point(574, 420);
            this.lbl_GenelToplamResult.Name = "lbl_GenelToplamResult";
            this.lbl_GenelToplamResult.Size = new System.Drawing.Size(0, 15);
            this.lbl_GenelToplamResult.TabIndex = 22;
            // 
            // form_SatisSayfasi
            // 
            this.AcceptButton = this.btn_Ekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stok_Takip_Otomasyonu.Properties.Resources.b83ffb5a6b74b5ef38c6ce2a640ee956;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 465);
            this.Controls.Add(this.lbl_GenelToplamResult);
            this.Controls.Add(this.lbl_GenelToplam);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbx_UrunIslemleri);
            this.Controls.Add(this.gbx_MusteriIslemleri);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_SatisYap);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Satisİptal);
            this.Controls.Add(this.btn_Ekle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_SatisSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Sayfası";
            this.Load += new System.EventHandler(this.form_SatisSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbx_MusteriIslemleri.ResumeLayout(false);
            this.gbx_MusteriIslemleri.PerformLayout();
            this.gbx_UrunIslemleri.ResumeLayout(false);
            this.gbx_UrunIslemleri.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MusteriEkle;
        private System.Windows.Forms.Button btn_MusteriListele;
        private System.Windows.Forms.Button btn_UrunEkle;
        private System.Windows.Forms.Button btn_UrunListele;
        private System.Windows.Forms.Button btn_SatisListele;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Satisİptal;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_SatisYap;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbx_MusteriIslemleri;
        private System.Windows.Forms.GroupBox gbx_UrunIslemleri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_TC;
        private System.Windows.Forms.Label lbl_AdSoyad;
        private System.Windows.Forms.Label lbl_Telefon;
        private System.Windows.Forms.Label lbl_BarkodNo;
        private System.Windows.Forms.Label lbl_UrunAdi;
        private System.Windows.Forms.Label lbl_Miktari;
        private System.Windows.Forms.Label lbl_SatisFiyati;
        private System.Windows.Forms.Label lbl_ToplamFiyat;
        private System.Windows.Forms.Label lbl_GenelToplam;
        private System.Windows.Forms.Label lbl_GenelToplamResult;
        private System.Windows.Forms.TextBox txt_TC;
        private System.Windows.Forms.TextBox txt_Telefon;
        private System.Windows.Forms.TextBox txt_AdSoyad;
        private System.Windows.Forms.TextBox txt_ToplamFiyat;
        private System.Windows.Forms.TextBox txt_SatisFiyati;
        private System.Windows.Forms.TextBox txt_Miktari;
        private System.Windows.Forms.TextBox txt_UrunAdi;
        private System.Windows.Forms.TextBox txt_BarkodNo;
    }
}

