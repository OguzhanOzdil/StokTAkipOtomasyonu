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
    public partial class form_SatisListele : Form
    {
        public form_SatisListele()
        {
            InitializeComponent();
        }

        SQLiteConnection baglanti = new SQLiteConnection("Data Source=C:\\Users\\Ozzy\\Desktop\\sqlite_db\\StokTakip.db;Version=3;");
        DataSet d_Set = new DataSet();

        private void form_SatisListele_Load(object sender, EventArgs e)
        {
            satisGoster();
        }

        private void satisGoster()
        {
            baglanti.Open();
            SQLiteDataAdapter adaptr = new SQLiteDataAdapter("Select * From Satislar", baglanti);
            adaptr.Fill(d_Set, "Satislar");
            dataGridView1.DataSource = d_Set.Tables["Satislar"];
            baglanti.Close();
        }

    }
}
