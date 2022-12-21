namespace Stok_Takip_Otomasyonu
{
    partial class form_MusteriListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_MusteriListele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Sehir = new System.Windows.Forms.TextBox();
            this.txt_Telefon = new System.Windows.Forms.TextBox();
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            this.txt_TC = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Sehir = new System.Windows.Forms.Label();
            this.lbl_Telefon = new System.Windows.Forms.Label();
            this.lbl_AdSoyad = new System.Windows.Forms.Label();
            this.lbl_TC = new System.Windows.Forms.Label();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.txt_TCAra = new System.Windows.Forms.TextBox();
            this.lbl_TCAra = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(241, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 287);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guncelle.Location = new System.Drawing.Point(143, 300);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_Guncelle.TabIndex = 21;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Email.Location = new System.Drawing.Point(118, 263);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(100, 20);
            this.txt_Email.TabIndex = 20;
            // 
            // txt_Sehir
            // 
            this.txt_Sehir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Sehir.Location = new System.Drawing.Point(118, 224);
            this.txt_Sehir.Name = "txt_Sehir";
            this.txt_Sehir.Size = new System.Drawing.Size(100, 20);
            this.txt_Sehir.TabIndex = 19;
            // 
            // txt_Telefon
            // 
            this.txt_Telefon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Telefon.Location = new System.Drawing.Point(118, 185);
            this.txt_Telefon.Name = "txt_Telefon";
            this.txt_Telefon.Size = new System.Drawing.Size(100, 20);
            this.txt_Telefon.TabIndex = 18;
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_AdSoyad.Location = new System.Drawing.Point(118, 146);
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txt_AdSoyad.TabIndex = 17;
            // 
            // txt_TC
            // 
            this.txt_TC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_TC.Location = new System.Drawing.Point(118, 107);
            this.txt_TC.Name = "txt_TC";
            this.txt_TC.Size = new System.Drawing.Size(100, 20);
            this.txt_TC.TabIndex = 16;
            // 
            // lbl_Email
            // 
            this.lbl_Email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Email.Location = new System.Drawing.Point(26, 266);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.lbl_Email.TabIndex = 15;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_Sehir
            // 
            this.lbl_Sehir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Sehir.AutoSize = true;
            this.lbl_Sehir.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sehir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Sehir.Location = new System.Drawing.Point(26, 227);
            this.lbl_Sehir.Name = "lbl_Sehir";
            this.lbl_Sehir.Size = new System.Drawing.Size(31, 13);
            this.lbl_Sehir.TabIndex = 14;
            this.lbl_Sehir.Text = "Şehir";
            // 
            // lbl_Telefon
            // 
            this.lbl_Telefon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Telefon.AutoSize = true;
            this.lbl_Telefon.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Telefon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Telefon.Location = new System.Drawing.Point(26, 188);
            this.lbl_Telefon.Name = "lbl_Telefon";
            this.lbl_Telefon.Size = new System.Drawing.Size(43, 13);
            this.lbl_Telefon.TabIndex = 13;
            this.lbl_Telefon.Text = "Telefon";
            // 
            // lbl_AdSoyad
            // 
            this.lbl_AdSoyad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_AdSoyad.AutoSize = true;
            this.lbl_AdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AdSoyad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_AdSoyad.Location = new System.Drawing.Point(26, 149);
            this.lbl_AdSoyad.Name = "lbl_AdSoyad";
            this.lbl_AdSoyad.Size = new System.Drawing.Size(53, 13);
            this.lbl_AdSoyad.TabIndex = 12;
            this.lbl_AdSoyad.Text = "Ad Soyad";
            // 
            // lbl_TC
            // 
            this.lbl_TC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_TC.AutoSize = true;
            this.lbl_TC.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_TC.Location = new System.Drawing.Point(26, 110);
            this.lbl_TC.Name = "lbl_TC";
            this.lbl_TC.Size = new System.Drawing.Size(21, 13);
            this.lbl_TC.TabIndex = 11;
            this.lbl_TC.Text = "TC";
            // 
            // btn_Sil
            // 
            this.btn_Sil.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sil.Location = new System.Drawing.Point(789, 91);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(75, 23);
            this.btn_Sil.TabIndex = 22;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // txt_TCAra
            // 
            this.txt_TCAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TCAra.Location = new System.Drawing.Point(607, 56);
            this.txt_TCAra.Name = "txt_TCAra";
            this.txt_TCAra.Size = new System.Drawing.Size(100, 20);
            this.txt_TCAra.TabIndex = 25;
            this.txt_TCAra.TextChanged += new System.EventHandler(this.txt_TCAra_TextChanged);
            // 
            // lbl_TCAra
            // 
            this.lbl_TCAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TCAra.AutoSize = true;
            this.lbl_TCAra.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TCAra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_TCAra.Location = new System.Drawing.Point(561, 59);
            this.lbl_TCAra.Name = "lbl_TCAra";
            this.lbl_TCAra.Size = new System.Drawing.Size(40, 13);
            this.lbl_TCAra.TabIndex = 24;
            this.lbl_TCAra.Text = "TC Ara";
            // 
            // form_MusteriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stok_Takip_Otomasyonu.Properties.Resources.technology_wire_mesh_network_connection_digital_background_1017_28407;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 464);
            this.Controls.Add(this.txt_TCAra);
            this.Controls.Add(this.lbl_TCAra);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Sehir);
            this.Controls.Add(this.txt_Telefon);
            this.Controls.Add(this.txt_AdSoyad);
            this.Controls.Add(this.txt_TC);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Sehir);
            this.Controls.Add(this.lbl_Telefon);
            this.Controls.Add(this.lbl_AdSoyad);
            this.Controls.Add(this.lbl_TC);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_MusteriListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Listele";
            this.Load += new System.EventHandler(this.form_MusteriListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Sehir;
        private System.Windows.Forms.TextBox txt_Telefon;
        private System.Windows.Forms.TextBox txt_AdSoyad;
        private System.Windows.Forms.TextBox txt_TC;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Sehir;
        private System.Windows.Forms.Label lbl_Telefon;
        private System.Windows.Forms.Label lbl_AdSoyad;
        private System.Windows.Forms.Label lbl_TC;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.TextBox txt_TCAra;
        private System.Windows.Forms.Label lbl_TCAra;
    }
}