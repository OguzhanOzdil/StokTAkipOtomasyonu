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
    public partial class form_MusteriEkle : Form
    {
        public form_MusteriEkle()
        {
            InitializeComponent();
        }

        SQLiteConnection baglanti = new SQLiteConnection("Data Source=C:\\Users\\Ozzy\\Desktop\\sqlite_db\\StokTakip.db;Version=3;");

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand("Insert Into Musteriler(TC,Ad_Soyad,Telefon,Sehir,Email) values(@TC,@Ad_Soyad,@Telefon,@Sehir,@Email)", baglanti);
            komut.Parameters.AddWithValue("@TC", txt_TC.Text);
            komut.Parameters.AddWithValue("@Ad_Soyad", txt_AdSoyad.Text);
            komut.Parameters.AddWithValue("@Telefon", txt_Telefon.Text);
            komut.Parameters.AddWithValue("@Sehir", txt_Sehir.Text);
            komut.Parameters.AddWithValue("@Email", txt_Email.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Eklendi!");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
