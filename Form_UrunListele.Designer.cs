namespace Stok_Takip_Otomasyonu
{
    partial class Form_UrunListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UrunListele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_BarkodNo = new System.Windows.Forms.TextBox();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.lbl_SatisFiyati = new System.Windows.Forms.Label();
            this.txt_AlisFiyati = new System.Windows.Forms.TextBox();
            this.lbl_Kategori = new System.Windows.Forms.Label();
            this.txt_SatisFiyati = new System.Windows.Forms.TextBox();
            this.lbl_Marka = new System.Windows.Forms.Label();
            this.lbl_AlisFiyati = new System.Windows.Forms.Label();
            this.txt_UrunAdi = new System.Windows.Forms.TextBox();
            this.lbl_BarkodNo = new System.Windows.Forms.Label();
            this.lbl_Miktari = new System.Windows.Forms.Label();
            this.lbl_UrunAdi = new System.Windows.Forms.Label();
            this.txt_Miktari = new System.Windows.Forms.TextBox();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.txt_BarkodNoAra = new System.Windows.Forms.TextBox();
            this.lbl_BarkodNoAra = new System.Windows.Forms.Label();
            this.cbx_Kategori = new System.Windows.Forms.ComboBox();
            this.cbx_Marka = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(193, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 282);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txt_BarkodNo
            // 
            this.txt_BarkodNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_BarkodNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_BarkodNo.Location = new System.Drawing.Point(84, 83);
            this.txt_BarkodNo.Name = "txt_BarkodNo";
            this.txt_BarkodNo.Size = new System.Drawing.Size(100, 20);
            this.txt_BarkodNo.TabIndex = 44;
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Guncelle.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Guncelle.Location = new System.Drawing.Point(109, 342);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_Guncelle.TabIndex = 37;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // lbl_SatisFiyati
            // 
            this.lbl_SatisFiyati.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_SatisFiyati.AutoSize = true;
            this.lbl_SatisFiyati.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SatisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_SatisFiyati.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_SatisFiyati.Location = new System.Drawing.Point(14, 308);
            this.lbl_SatisFiyati.Name = "lbl_SatisFiyati";
            this.lbl_SatisFiyati.Size = new System.Drawing.Size(57, 13);
            this.lbl_SatisFiyati.TabIndex = 51;
            this.lbl_SatisFiyati.Text = "Satış Fiyatı";
            // 
            // txt_AlisFiyati
            // 
            this.txt_AlisFiyati.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_AlisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_AlisFiyati.Location = new System.Drawing.Point(84, 268);
            this.txt_AlisFiyati.Name = "txt_AlisFiyati";
            this.txt_AlisFiyati.Size = new System.Drawing.Size(100, 20);
            this.txt_AlisFiyati.TabIndex = 42;
            // 
            // lbl_Kategori
            // 
            this.lbl_Kategori.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Kategori.AutoSize = true;
            this.lbl_Kategori.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kategori.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Kategori.Location = new System.Drawing.Point(13, 123);
            this.lbl_Kategori.Name = "lbl_Kategori";
            this.lbl_Kategori.Size = new System.Drawing.Size(46, 13);
            this.lbl_Kategori.TabIndex = 46;
            this.lbl_Kategori.Text = "Kategori";
            // 
            // txt_SatisFiyati
            // 
            this.txt_SatisFiyati.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_SatisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_SatisFiyati.Location = new System.Drawing.Point(84, 305);
            this.txt_SatisFiyati.Name = "txt_SatisFiyati";
            this.txt_SatisFiyati.Size = new System.Drawing.Size(100, 20);
            this.txt_SatisFiyati.TabIndex = 43;
            // 
            // lbl_Marka
            // 
            this.lbl_Marka.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Marka.AutoSize = true;
            this.lbl_Marka.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Marka.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Marka.Location = new System.Drawing.Point(13, 160);
            this.lbl_Marka.Name = "lbl_Marka";
            this.lbl_Marka.Size = new System.Drawing.Size(37, 13);
            this.lbl_Marka.TabIndex = 47;
            this.lbl_Marka.Text = "Marka";
            // 
            // lbl_AlisFiyati
            // 
            this.lbl_AlisFiyati.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_AlisFiyati.AutoSize = true;
            this.lbl_AlisFiyati.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AlisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AlisFiyati.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_AlisFiyati.Location = new System.Drawing.Point(13, 271);
            this.lbl_AlisFiyati.Name = "lbl_AlisFiyati";
            this.lbl_AlisFiyati.Size = new System.Drawing.Size(50, 13);
            this.lbl_AlisFiyati.TabIndex = 50;
            this.lbl_AlisFiyati.Text = "Alış Fitayı";
            // 
            // txt_UrunAdi
            // 
            this.txt_UrunAdi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_UrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_UrunAdi.Location = new System.Drawing.Point(84, 194);
            this.txt_UrunAdi.Name = "txt_UrunAdi";
            this.txt_UrunAdi.Size = new System.Drawing.Size(100, 20);
            this.txt_UrunAdi.TabIndex = 40;
            // 
            // lbl_BarkodNo
            // 
            this.lbl_BarkodNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_BarkodNo.AutoSize = true;
            this.lbl_BarkodNo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BarkodNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_BarkodNo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_BarkodNo.Location = new System.Drawing.Point(13, 86);
            this.lbl_BarkodNo.Name = "lbl_BarkodNo";
            this.lbl_BarkodNo.Size = new System.Drawing.Size(58, 13);
            this.lbl_BarkodNo.TabIndex = 45;
            this.lbl_BarkodNo.Text = "Barkod No";
            // 
            // lbl_Miktari
            // 
            this.lbl_Miktari.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Miktari.AutoSize = true;
            this.lbl_Miktari.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Miktari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Miktari.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Miktari.Location = new System.Drawing.Point(13, 234);
            this.lbl_Miktari.Name = "lbl_Miktari";
            this.lbl_Miktari.Size = new System.Drawing.Size(36, 13);
            this.lbl_Miktari.TabIndex = 49;
            this.lbl_Miktari.Text = "Miktar";
            // 
            // lbl_UrunAdi
            // 
            this.lbl_UrunAdi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_UrunAdi.AutoSize = true;
            this.lbl_UrunAdi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_UrunAdi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_UrunAdi.Location = new System.Drawing.Point(13, 197);
            this.lbl_UrunAdi.Name = "lbl_UrunAdi";
            this.lbl_UrunAdi.Size = new System.Drawing.Size(48, 13);
            this.lbl_UrunAdi.TabIndex = 48;
            this.lbl_UrunAdi.Text = "Ürün Adı";
            // 
            // txt_Miktari
            // 
            this.txt_Miktari.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Miktari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Miktari.Location = new System.Drawing.Point(84, 231);
            this.txt_Miktari.Name = "txt_Miktari";
            this.txt_Miktari.Size = new System.Drawing.Size(100, 20);
            this.txt_Miktari.TabIndex = 41;
            // 
            // btn_Sil
            // 
            this.btn_Sil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sil.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Sil.Location = new System.Drawing.Point(788, 377);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(75, 23);
            this.btn_Sil.TabIndex = 52;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // txt_BarkodNoAra
            // 
            this.txt_BarkodNoAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_BarkodNoAra.Location = new System.Drawing.Point(728, 55);
            this.txt_BarkodNoAra.Name = "txt_BarkodNoAra";
            this.txt_BarkodNoAra.Size = new System.Drawing.Size(100, 20);
            this.txt_BarkodNoAra.TabIndex = 53;
            this.txt_BarkodNoAra.TextChanged += new System.EventHandler(this.txt_BarkodNoAra_TextChanged);
            // 
            // lbl_BarkodNoAra
            // 
            this.lbl_BarkodNoAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_BarkodNoAra.AutoSize = true;
            this.lbl_BarkodNoAra.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BarkodNoAra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_BarkodNoAra.Location = new System.Drawing.Point(606, 58);
            this.lbl_BarkodNoAra.Name = "lbl_BarkodNoAra";
            this.lbl_BarkodNoAra.Size = new System.Drawing.Size(107, 13);
            this.lbl_BarkodNoAra.TabIndex = 54;
            this.lbl_BarkodNoAra.Text = "Barkod Numarası Ara";
            // 
            // cbx_Kategori
            // 
            this.cbx_Kategori.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbx_Kategori.FormattingEnabled = true;
            this.cbx_Kategori.Location = new System.Drawing.Point(84, 120);
            this.cbx_Kategori.Name = "cbx_Kategori";
            this.cbx_Kategori.Size = new System.Drawing.Size(100, 21);
            this.cbx_Kategori.TabIndex = 55;
            this.cbx_Kategori.SelectedIndexChanged += new System.EventHandler(this.cbx_Kategori_SelectedIndexChanged);
            // 
            // cbx_Marka
            // 
            this.cbx_Marka.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbx_Marka.FormattingEnabled = true;
            this.cbx_Marka.Location = new System.Drawing.Point(84, 157);
            this.cbx_Marka.Name = "cbx_Marka";
            this.cbx_Marka.Size = new System.Drawing.Size(100, 21);
            this.cbx_Marka.TabIndex = 56;
            // 
            // Form_UrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stok_Takip_Otomasyonu.Properties.Resources.technology_wire_mesh_network_connection_digital_background_1017_28407;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 464);
            this.Controls.Add(this.cbx_Marka);
            this.Controls.Add(this.cbx_Kategori);
            this.Controls.Add(this.lbl_BarkodNoAra);
            this.Controls.Add(this.txt_BarkodNoAra);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.txt_BarkodNo);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.lbl_SatisFiyati);
            this.Controls.Add(this.txt_AlisFiyati);
            this.Controls.Add(this.lbl_Kategori);
            this.Controls.Add(this.txt_SatisFiyati);
            this.Controls.Add(this.lbl_Marka);
            this.Controls.Add(this.lbl_AlisFiyati);
            this.Controls.Add(this.txt_UrunAdi);
            this.Controls.Add(this.lbl_BarkodNo);
            this.Controls.Add(this.lbl_Miktari);
            this.Controls.Add(this.lbl_UrunAdi);
            this.Controls.Add(this.txt_Miktari);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_UrunListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listele";
            this.Load += new System.EventHandler(this.Form_UrunListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_BarkodNo;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Label lbl_SatisFiyati;
        private System.Windows.Forms.TextBox txt_AlisFiyati;
        private System.Windows.Forms.Label lbl_Kategori;
        private System.Windows.Forms.TextBox txt_SatisFiyati;
        private System.Windows.Forms.Label lbl_Marka;
        private System.Windows.Forms.Label lbl_AlisFiyati;
        private System.Windows.Forms.TextBox txt_UrunAdi;
        private System.Windows.Forms.Label lbl_BarkodNo;
        private System.Windows.Forms.Label lbl_Miktari;
        private System.Windows.Forms.Label lbl_UrunAdi;
        private System.Windows.Forms.TextBox txt_Miktari;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.TextBox txt_BarkodNoAra;
        private System.Windows.Forms.Label lbl_BarkodNoAra;
        private System.Windows.Forms.ComboBox cbx_Kategori;
        private System.Windows.Forms.ComboBox cbx_Marka;
    }
}