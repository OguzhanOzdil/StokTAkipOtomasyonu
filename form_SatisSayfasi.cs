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
    public partial class form_SatisSayfasi : Form
    {
        public form_SatisSayfasi()
        {
            InitializeComponent();
        }

        SQLiteConnection baglanti = new SQLiteConnection("Data Source=C:\\Users\\Ozzy\\Desktop\\sqlite_db\\StokTakip.db;Version=3;");
        DataSet d_Set = new DataSet();

        private void btn_MusteriEkle_Click(object sender, EventArgs e)
        {
            form_MusteriEkle ekle = new form_MusteriEkle();
            ekle.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_UrunListele ekle = new Form_UrunListele();
            ekle.ShowDialog();
        }

        private void btn_MusteriListele_Click(object sender, EventArgs e)
        {
            form_MusteriListele listele = new form_MusteriListele();
            listele.ShowDialog();
        }

        private void btn_UrunEkle_Click(object sender, EventArgs e)
        {
            form_UrunEkle ekle = new form_UrunEkle();
            ekle.ShowDialog();
        }

        private void form_SatisSayfasi_Load(object sender, EventArgs e)
        {
            sepetListele();
        }

        private void sepetListele()
        {
            baglanti.Open();
            SQLiteDataAdapter adaptr = new SQLiteDataAdapter("Select * From Sepet", baglanti);
            adaptr.Fill(d_Set, "Sepet");
            dataGridView1.DataSource = d_Set.Tables["Sepet"];
            dataGridView1.Columns[0].Visible = false;   // kolon gizleme
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            baglanti.Close();
        }

        private void txt_TC_TextChanged(object sender, EventArgs e)
        {
            if (txt_TC.Text == "")
            {
                txt_AdSoyad.Text = "";
                txt_Telefon.Text = "";
            }
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand("Select * From Musteriler Where TC Like '" + txt_TC.Text + "' ", baglanti);
            SQLiteDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txt_AdSoyad.Text = read["Ad_soyad"].ToString();
                txt_Telefon.Text = read["Telefon"].ToString();
            }
            baglanti.Close();
        }

        private void txt_BarkodNo_TextChanged(object sender, EventArgs e)
        {
            if (txt_BarkodNo.Text == "")
            {
                foreach (Control item in gbx_UrunIslemleri.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txt_Miktari)
                        {
                            item.Text = "";
                        }
                    }
                }
            }

            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand("Select * From Urunler Where Barkod_No Like '" + txt_BarkodNo.Text + "' ", baglanti);
            SQLiteDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txt_UrunAdi.Text = read["Urun_Adi"].ToString();
                txt_SatisFiyati.Text = read["Satis_Fiyati"].ToString();
            }
            baglanti.Close();

        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand("Insert Into Sepet(TC,Ad_Soyad,Telefon,Barkod_No,Urun_Adi,Miktari,Satis_Fiyati,Toplam_Fiyat,Tarih) Values(@TC,@Ad_Soyad,@Telefon,@Barkod_No,@Urun_Adi,@Miktari,@Satis_Fiyati,@Toplam_Fiyat,@Tarih)", baglanti);
            komut.Parameters.AddWithValue("@TC", txt_TC.Text);
            komut.Parameters.AddWithValue("@Ad_Soyad", txt_AdSoyad.Text);
            komut.Parameters.AddWithValue("@Telefon", txt_Telefon.Text);
            komut.Parameters.AddWithValue("@Barkod_No", txt_BarkodNo.Text);
            komut.Parameters.AddWithValue("@Urun_Adi", txt_UrunAdi.Text);
            komut.Parameters.AddWithValue("@Miktari", int.Parse(txt_Miktari.Text));
            komut.Parameters.AddWithValue("@Satis_Fiyati", float.Parse(txt_SatisFiyati.Text));
            komut.Parameters.AddWithValue("@Toplam_Fiyat", float.Parse(txt_ToplamFiyat.Text));
            komut.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();

            txt_Miktari.Text = "1";
            d_Set.Tables["Sepet"].Clear();
            sepetListele();
            hesapla();

            foreach (Control item in gbx_UrunIslemleri.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txt_Miktari)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void txt_Miktari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_ToplamFiyat.Text = (float.Parse(txt_Miktari.Text) * float.Parse(txt_SatisFiyati.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void txt_SatisFiyati_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_ToplamFiyat.Text = (float.Parse(txt_Miktari.Text) * float.Parse(txt_SatisFiyati.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand("Delete From Sepet Where Barkod_No= '" + dataGridView1.CurrentRow.Cells["Barkod_No"].Value.ToString() + "' ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            d_Set.Tables["Sepet"].Clear();
            sepetListele();
            MessageBox.Show("Ürün Sepetten Çıkarıldı!");
            hesapla();
        }

        private void btn_Satisİptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand("Delete From Sepet", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            d_Set.Tables["Sepet"].Clear();
            sepetListele();
            MessageBox.Show("Sepet Boşaltıldı!");
            hesapla();

        }

        private void btn_SiparisListele_Click(object sender, EventArgs e)
        {
            form_SatisListele ekle = new form_SatisListele();
            ekle.ShowDialog();
        }

        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand("Select Sum(Toplam_Fiyat) From Sepet", baglanti);
                lbl_GenelToplamResult.Text = komut.ExecuteScalar() + " TL" ;
                baglanti.Close();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void btn_SatisYap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1 ; i++)
            {
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand("Insert Into Satislar(TC,Ad_Soyad,Telefon,Barkod_No,Urun_Adi,Miktari,Satis_Fiyati,Toplam_Fiyat,Tarih) Values(@TC,@Ad_Soyad,@Telefon,@Barkod_No,@Urun_Adi,@Miktari,@Satis_Fiyati,@Toplam_Fiyat,@Tarih)", baglanti);
                komut.Parameters.AddWithValue("@TC", txt_TC.Text);
                komut.Parameters.AddWithValue("@Ad_Soyad", txt_AdSoyad.Text);
                komut.Parameters.AddWithValue("@Telefon", txt_Telefon.Text);
                komut.Parameters.AddWithValue("@Barkod_No", dataGridView1.Rows[i].Cells["Barkod_No"].Value.ToString());
                komut.Parameters.AddWithValue("@Urun_Adi", dataGridView1.Rows[i].Cells["Urun_Adi"].Value.ToString());
                komut.Parameters.AddWithValue("@Miktari", int.Parse(dataGridView1.Rows[i].Cells["Miktari"].Value.ToString()));
                komut.Parameters.AddWithValue("@Satis_Fiyati", float.Parse(dataGridView1.Rows[i].Cells["Satis_Fiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@Toplam_Fiyat", float.Parse(dataGridView1.Rows[i].Cells["Toplam_Fiyat"].Value.ToString()));
                komut.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();

                SQLiteCommand komut2 = new SQLiteCommand("Update Urunler Set Miktari= Miktari- '" + int.Parse(dataGridView1.Rows[i].Cells["Miktari"].Value.ToString()) + "' Where Barkod_No= '" + dataGridView1.Rows[i].Cells["Barkod_No"].Value.ToString() + "' ", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
            }

            baglanti.Open();
            SQLiteCommand komut3 = new SQLiteCommand("Delete From Sepet", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();

            d_Set.Tables["Sepet"].Clear();
            sepetListele();
            hesapla();
        }
    }
}
