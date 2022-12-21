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
    public partial class form_Marka : Form
    {
        public form_Marka()
        {
            InitializeComponent();
        }

        SQLiteConnection baglanti = new SQLiteConnection("Data Source=C:\\Users\\Ozzy\\Desktop\\sqlite_db\\StokTakip.db;Version=3;");

        /*
        bool durum;
        private void markaKontrol()
        {
            durum = true;
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand("Select * From Marka_Bilgileri", baglanti);
            SQLiteDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (cbx_Kategori.Text == read["Kategori"].ToString() && txt_Marka.Text == read["Marka"].ToString() || cbx_Kategori.Text == "" || txt_Marka.Text == "")
                {
                    durum = false;
                }
            }
        }
        */

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            /*
            markaKontrol();
            if (durum == true)
            {
            */
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand("Insert Into Marka_Bilgileri(Kategori, Marka) values( '"+ cbx_Kategori.Text +"'  , '"+ txt_Marka.Text +"' )", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Marka Eklendi!");
            /*
            }
            else
            {
                MessageBox.Show("Böyle bir marka var!", "Uyarı");
            }
            */
            cbx_Kategori.Text = "";
            txt_Marka.Text = "";
            
        }

        private void form_Marka_Load(object sender, EventArgs e)
        {
            kategori_Getir();
        }

        private void kategori_Getir()
        {
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand("Select * From Kategori_Bilgileri", baglanti);
            SQLiteDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cbx_Kategori.Items.Add(read["Kategori"].ToString());
            }
            baglanti.Close();
        }
    }
}
