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
    public partial class form_MusteriListele : Form
    {
        public form_MusteriListele()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        SQLiteConnection baglanti = new SQLiteConnection("Data Source=C:\\Users\\Ozzy\\Desktop\\sqlite_db\\StokTakip.db;Version=3;");
        DataSet d_Set = new DataSet();

        private void form_MusteriListele_Load(object sender, EventArgs e)
        {
            Kayıt_Goster();
        }

        private void Kayıt_Goster()
        {
            baglanti.Open();
            SQLiteDataAdapter adaptr = new SQLiteDataAdapter("Select * From Musteriler", baglanti);
            adaptr.Fill(d_Set, "Musteriler");
            dataGridView1.DataSource = d_Set.Tables["Musteriler"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_TC.Text = dataGridView1.CurrentRow.Cells["TC"].Value.ToString();
            txt_AdSoyad.Text = dataGridView1.CurrentRow.Cells["Ad_Soyad"].Value.ToString();
            txt_Telefon.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            txt_Sehir.Text = dataGridView1.CurrentRow.Cells["Sehir"].Value.ToString();
            txt_Email.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand("Update Musteriler Set Ad_Soyad=@Ad_Soyad, Telefon=@Telefon, Sehir=@Sehir, Email=@Email Where TC=@TC", baglanti);
            komut.Parameters.AddWithValue("@TC", txt_TC.Text);
            komut.Parameters.AddWithValue("@Ad_Soyad", txt_AdSoyad.Text);
            komut.Parameters.AddWithValue("@Telefon", txt_Telefon.Text);
            komut.Parameters.AddWithValue("@Sehir", txt_Sehir.Text);
            komut.Parameters.AddWithValue("@Email", txt_Email.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            d_Set.Tables["Musteriler"].Clear();
            Kayıt_Goster();
            MessageBox.Show("Müşteri Kaydı Güncellendi!");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand("Delete From Musteriler Where TC= '" + dataGridView1.CurrentRow.Cells["TC"].Value.ToString() + "' ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            d_Set.Tables["Musteriler"].Clear();
            Kayıt_Goster();
            MessageBox.Show("Kayıt Silindi!");
        }

        private void txt_TCAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SQLiteDataAdapter adaptr = new SQLiteDataAdapter("Select * From Musteriler Where TC Like '%" + txt_TCAra.Text + "%' ", baglanti);
            adaptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
