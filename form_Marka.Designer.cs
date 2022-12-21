namespace Stok_Takip_Otomasyonu
{
    partial class form_Marka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Marka));
            this.lbl_Kategori = new System.Windows.Forms.Label();
            this.lbl_Marka = new System.Windows.Forms.Label();
            this.cbx_Kategori = new System.Windows.Forms.ComboBox();
            this.txt_Marka = new System.Windows.Forms.TextBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Kategori
            // 
            this.lbl_Kategori.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Kategori.AutoSize = true;
            this.lbl_Kategori.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kategori.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Kategori.Location = new System.Drawing.Point(67, 40);
            this.lbl_Kategori.Name = "lbl_Kategori";
            this.lbl_Kategori.Size = new System.Drawing.Size(53, 15);
            this.lbl_Kategori.TabIndex = 0;
            this.lbl_Kategori.Text = "Kategori";
            // 
            // lbl_Marka
            // 
            this.lbl_Marka.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Marka.AutoSize = true;
            this.lbl_Marka.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Marka.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Marka.Location = new System.Drawing.Point(67, 77);
            this.lbl_Marka.Name = "lbl_Marka";
            this.lbl_Marka.Size = new System.Drawing.Size(42, 15);
            this.lbl_Marka.TabIndex = 1;
            this.lbl_Marka.Text = "Marka";
            // 
            // cbx_Kategori
            // 
            this.cbx_Kategori.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_Kategori.FormattingEnabled = true;
            this.cbx_Kategori.Location = new System.Drawing.Point(131, 37);
            this.cbx_Kategori.Name = "cbx_Kategori";
            this.cbx_Kategori.Size = new System.Drawing.Size(101, 21);
            this.cbx_Kategori.TabIndex = 2;
            // 
            // txt_Marka
            // 
            this.txt_Marka.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Marka.Location = new System.Drawing.Point(132, 74);
            this.txt_Marka.Name = "txt_Marka";
            this.txt_Marka.Size = new System.Drawing.Size(100, 20);
            this.txt_Marka.TabIndex = 3;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ekle.Location = new System.Drawing.Point(157, 110);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_Ekle.TabIndex = 4;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // form_Marka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stok_Takip_Otomasyonu.Properties.Resources.unnamed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(335, 193);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.txt_Marka);
            this.Controls.Add(this.cbx_Kategori);
            this.Controls.Add(this.lbl_Marka);
            this.Controls.Add(this.lbl_Kategori);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_Marka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marka Sayfsaı";
            this.Load += new System.EventHandler(this.form_Marka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Kategori;
        private System.Windows.Forms.Label lbl_Marka;
        private System.Windows.Forms.ComboBox cbx_Kategori;
        private System.Windows.Forms.TextBox txt_Marka;
        private System.Windows.Forms.Button btn_Ekle;
    }
}