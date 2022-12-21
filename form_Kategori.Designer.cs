namespace Stok_Takip_Otomasyonu
{
    partial class form_Kategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Kategori));
            this.txt_Kategori = new System.Windows.Forms.TextBox();
            this.lbl_Kategori = new System.Windows.Forms.Label();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Kategori
            // 
            this.txt_Kategori.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Kategori.Location = new System.Drawing.Point(97, 36);
            this.txt_Kategori.Name = "txt_Kategori";
            this.txt_Kategori.Size = new System.Drawing.Size(100, 20);
            this.txt_Kategori.TabIndex = 0;
            this.txt_Kategori.TextChanged += new System.EventHandler(this.txt_Kategori_TextChanged);
            // 
            // lbl_Kategori
            // 
            this.lbl_Kategori.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Kategori.AutoSize = true;
            this.lbl_Kategori.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kategori.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Kategori.Location = new System.Drawing.Point(38, 37);
            this.lbl_Kategori.Name = "lbl_Kategori";
            this.lbl_Kategori.Size = new System.Drawing.Size(53, 15);
            this.lbl_Kategori.TabIndex = 1;
            this.lbl_Kategori.Text = "Kategori";
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ekle.Location = new System.Drawing.Point(122, 72);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_Ekle.TabIndex = 2;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // form_Kategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stok_Takip_Otomasyonu.Properties.Resources.unnamed__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(268, 141);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.lbl_Kategori);
            this.Controls.Add(this.txt_Kategori);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_Kategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori Sayfası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Kategori;
        private System.Windows.Forms.Label lbl_Kategori;
        private System.Windows.Forms.Button btn_Ekle;
    }
}