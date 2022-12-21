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
    public partial class form_UrunEkle : Form
    {
        public form_UrunEkle()
        {
            InitializeComponent();
        }

        private void btn_KategoriEkle_Click(object sender, EventArgs e)
        {
            form_Kategori kategori_Ekle = new form_Kategori();
            kategori_Ekle.ShowDialog();
        }

        private void btn_MarkaEkle_Click(object sender, EventArgs e)
        {
            form_Marka marka_Ekle = new form_Marka();
            marka_Ekle.ShowDialog();
        }

        SQLiteConnection baglanti = new SQLiteConnection("Data Source=C:\\Users\\Ozzy\\Desktop\\sqlite_db\\StokTakip.db;Version=3;");

        private void form_UrunEkle_Load(object sender, EventArgs e)
        {
            kategoriGetir();
        }

        private void kategoriGetir()
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

        private void cbx_Kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_Marka.Items.Clear();
            cbx_Marka.Text = "";
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand("Select * From Marka_Bilgileri Where Kategori = '" + cbx_Kategori.SelectedItem + "' ", baglanti);
            SQLiteDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cbx_Marka.Items.Add(read["Marka"].ToString());
            }
            baglanti.Close();

        }

        private void btn_YeniEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand("Insert Into Urunler(Barkod_No, Kategori, Marka, Urun_Adi, Miktari, Alis_Fiyati, Satis_Fiyati, Tarih) Values(@Barkod_No, @Kategori, @Marka, @Urun_Adi, @Miktari, @Alis_Fiyati, @Satis_Fiyati, @Tarih)", baglanti);
            komut.Parameters.AddWithValue("@Barkod_No", txt_YeniBarkodNo.Text);
            komut.Parameters.AddWithValue("@Kategori", cbx_Kategori.Text);
            komut.Parameters.AddWithValue("@Marka", cbx_Marka.Text);
            komut.Parameters.AddWithValue("@Urun_Adi", txt_YeniUrunAdi.Text);
            komut.Parameters.AddWithValue("@Miktari", int.Parse(txt_YeniMiktar.Text));
            komut.Parameters.AddWithValue("@Alis_Fiyati", float.Parse(txt_YeniAlisFiyati.Text));
            komut.Parameters.AddWithValue("@Satis_Fiyati", float.Parse(txt_YeniSatisFiyati.Text));
            komut.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Eklendi!");
            cbx_Marka.Items.Clear();
            foreach  (Control item in gbx_YeniUrun.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void txt_BarkodNo_TextChanged(object sender, EventArgs e)
        {
            if (txt_BarkodNo.Text == "")
            {
                lbl_KayitliMiktarResult.Text = "";
                foreach (Control item in gbx_VarOlanUrun.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand("Select * From Urunler Where Barkod_No Like '" + txt_BarkodNo.Text + "' ", baglanti);
            SQLiteDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txt_Kategori.Text = read["Kategori"].ToString();
                txt_Marka.Text = read["Marka"].ToString();
                txt_UrunAdi.Text = read["Urun_Adi"].ToString();
                lbl_KayitliMiktarResult.Text = read["Miktari"].ToString();
                txt_AlisFiyati.Text = read["Alis_Fiyati"].ToString();
                txt_SatisFiyati.Text = read["Satis_Fiyati"].ToString();
            }
            baglanti.Close();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand("Update Urunler Set Miktari= Miktari+ '" + int.Parse(txt_Miktari.Text) + "' Where Barkod_No= '" + txt_BarkodNo.Text + "' ", baglanti) ;
            komut.ExecuteNonQuery();
            baglanti.Close();
            foreach (Control item in gbx_VarOlanUrun.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Yeni miktar var olan miktarın üzerine eklendi!");
        }
    }
}
