using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data;

namespace KutuphaneOtomasyonu
{
    public partial class OgrenciBilgiForm : Form
         
    {
        private string kullaniciAdi;
       
        public OgrenciBilgiForm()
        {
            InitializeComponent();
            kullaniciAdi = LoginForm.girisYapanKullaniciAdi;
        }
        private void KitaplariListele()
        {
           

            using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Ayse123654;Database=kutuphane"))
            {
                conn.Open();

                string sql = @"
SELECT k.kitap_adi, o.alis_tarihi, o.teslim_tarihi
FROM odunc o
JOIN kitaplar k ON o.kitap_id = k.kitap_id
JOIN ogrenciler ogr ON o.ogrenci_id = ogr.ogrenci_id
WHERE ogr.kullanici_adi = @kullaniciAdi";


                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);

                    using (var da = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }

                conn.Close();
            }
        }

        private void OgrenciBilgiForm_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            panel1.Anchor = AnchorStyles.None;
            {
                string kullaniciAdi = LoginForm.girisYapanKullaniciAdi;


                using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Ayse123654;Database=kutuphane"))
                {
                    conn.Open();
                    string sql = @"SELECT k.kitap_adi, o.alis_tarihi, o.teslim_tarihi
               FROM odunc o
               JOIN kitaplar k ON o.kitap_id = k.kitap_id
               JOIN ogrenciler ogr ON o.ogrenci_id = ogr.ogrenci_id
               WHERE ogr.kullanici_adi = @kullaniciAdi";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);

                        using (var da = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                            dataGridView1.Columns[0].HeaderText = "Kitap Adı";
                            dataGridView1.Columns[1].HeaderText = "Alış Tarihi";
                            dataGridView1.Columns[2].HeaderText = "Teslim Tarihi";
                        }
                    }
                }
            }
            KitaplariListele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
