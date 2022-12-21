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
    public partial class Form_UrunListele : Form
    {
        public Form_UrunListele()
        {
            InitializeComponent();
        }

        SQLiteConnection baglanti = new SQLiteConnection("Data Source=C:\\Users\\Ozzy\\Desktop\\sqlite_db\\StokTakip.db;Version=3;");
        DataSet d_Set = new DataSet();
        private void Form_UrunListele_Load(object sender, EventArgs e)
        {
            urunListele();
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


        private void urunListele()
        {
            baglanti.Open();
            SQLiteDataAdapter adaptr = new SQLiteDataAdapter("Select * From Urunler", baglanti);
            adaptr.Fill(d_Set, "Urunler");
            dataGridView1.DataSource = d_Set.Tables["Urunler"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_BarkodNo.Text = dataGridView1.CurrentRow.Cells["Barkod_No"].Value.ToString();
            cbx_Kategori.Text = dataGridView1.CurrentRow.Cells["Kategori"].Value.ToString();
            cbx_Marka.Text = dataGridView1.CurrentRow.Cells["Marka"].Value.ToString();
            txt_UrunAdi.Text = dataGridView1.CurrentRow.Cells["Urun_Adi"].Value.ToString();
            txt_Miktari.Text = dataGridView1.CurrentRow.Cells["Miktari"].Value.ToString();
            txt_AlisFiyati.Text = dataGridView1.CurrentRow.Cells["Alis_Fiyati"].Value.ToString();
            txt_SatisFiyati.Text = dataGridView1.CurrentRow.Cells["Satis_Fiyati"].Value.ToString();

        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            /*
            if (txt_BarkodNo != "")
            {
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand("Update Urunler Set Kategori=@Kategori, Marka=@Marka, Urun_Adi=@Urun_Adi, Miktari=@Miktari, Alis_Fiyati=@Alis_Fiyati, Satis_Fiyati=@Satis_Fiyati Where Barkod_No=@Barkod_No", baglanti);
                komut.Parameters.AddWithValue("@Barkod_No", txt_BarkodNo.Text);
                komut.Parameters.AddWithValue("@Kategori", txt_Kategori.Text);
                komut.Parameters.AddWithValue("@Marka", txt_Marka.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün Kaydı Güncellendi!");
            }
            else
            {
            MessageBox.Show("Barkod Yazılı Değil!");
            }

            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }

             
             */
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand("Update Urunler Set Kategori=@Kategori, Marka=@Marka, Urun_Adi=@Urun_Adi, Miktari=@Miktari, Alis_Fiyati=@Alis_Fiyati, Satis_Fiyati=@Satis_Fiyati Where Barkod_No=@Barkod_No", baglanti);
            komut.Parameters.AddWithValue("@Barkod_No", txt_BarkodNo.Text);
            komut.Parameters.AddWithValue("@Kategori", cbx_Kategori.Text);
            komut.Parameters.AddWithValue("@Marka", cbx_Marka.Text);
            komut.Parameters.AddWithValue("@Urun_Adi", txt_UrunAdi.Text);
            komut.Parameters.AddWithValue("@Miktari", int.Parse(txt_Miktari.Text));
            komut.Parameters.AddWithValue("@Alis_Fiyati", double.Parse(txt_AlisFiyati.Text));
            komut.Parameters.AddWithValue("@Satis_Fiyati", double.Parse(txt_SatisFiyati.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            d_Set.Tables["Urunler"].Clear();
            urunListele();
            MessageBox.Show("Ürün Kaydı Güncellendi!");
            foreach (Control item in this.Controls)
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

        private void txt_BarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SQLiteDataAdapter adaptr = new SQLiteDataAdapter("Select * From Urunler Where Barkod_No Like '%" + txt_BarkodNoAra.Text + "%' ", baglanti);
            adaptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand("Delete From Urunler Where Barkod_No= '" + dataGridView1.CurrentRow.Cells["Barkod_No"].Value.ToString() + "' ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            d_Set.Tables["Urunler"].Clear();
            urunListele();
            MessageBox.Show("Kayıt Silindi!");

        }
    }
}
