using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Stok_Takip_Otomasyonu
{
    public partial class form_Kategori : Form
    {
        public form_Kategori()
        {
            InitializeComponent();
        }

        SQLiteConnection baglanti = new SQLiteConnection("Data Source=C:\\Users\\Ozzy\\Desktop\\sqlite_db\\StokTakip.db;Version=3;");

        /*
        bool durum;
        private void kategoriKontrol()
        {
            durum = true;
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand("Select * From Kategori_Bilgileri", baglanti);
            SQLiteDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txt_Kategori.Text == read["Kategori"].ToString() || txt_Kategori.Text=="")
                {
                    durum = false;
                }
            }
        }
        */

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            /*kategoriKontrol();
            if (durum == true)
            {
            */
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand("Insert Into Kategori_Bilgileri(Kategori) values( '" + txt_Kategori.Text + "' )", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kategori Eklendi!");
            /*
            }
            else
            {
                MessageBox.Show("Böyle bir kategori var!", "Uyarı");
            }
            */
            txt_Kategori.Text = "";
            
        }

        private void txt_Kategori_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
