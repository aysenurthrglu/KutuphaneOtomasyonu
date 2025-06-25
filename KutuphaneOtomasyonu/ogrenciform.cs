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


namespace KutuphaneOtomasyonu
{
    public partial class ogrenciform : Form
    {
        public ogrenciform()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Ayse123654;Database=kutuphane"))
            {
                conn.Open();

                string sql = "INSERT INTO ogrenciler (ad, soyad, okul_no, telefon, eposta) " +
             "VALUES (@ad, @soyad, @okul_no, @telefon, @eposta)";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ad", txtOgrenciAd.Text);
                    cmd.Parameters.AddWithValue("@soyad", txtOgrenciSoyad.Text);
                    cmd.Parameters.AddWithValue("@okul_no", txtOgrenciNo.Text); // @numara yerine @okul_no

                    cmd.Parameters.AddWithValue("@telefon", txtOgrenciTelefon.Text);
                    cmd.Parameters.AddWithValue("@eposta", txtOgrenciMail.Text);
                    cmd.Parameters.AddWithValue("@kullanici_adi", txtKullaniciAdi.Text);
                    cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Öğrenci başarıyla eklendi!");
                }

                conn.Close();
                

                OgrencileriListele(); // DataGridView'i güncelle
             
            }

        }
        private void OgrencileriListele()
        {
            using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Ayse123654;Database=kutuphane"))
            {
                conn.Open();
                string sql = "SELECT * FROM ogrenciler ORDER BY okul_no";

                using (var da = new NpgsqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridOgrenciler.DataSource = dt;
                }

                conn.Close();
            }
            lblOgrenciSayisi.Text = "Toplam Öğrenci: " + dataGridOgrenciler.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow);

        }
        private void Temizle()
        {
            txtOgrenciAd.Clear();
            txtOgrenciSoyad.Clear();
            txtOgrenciNo.Clear();
            txtOgrenciTelefon.Clear();
            txtOgrenciMail.Clear();
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
        }

        private void ogrenciform_Load(object sender, EventArgs e)
        {
            OgrencileriListele();
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            panel1.Anchor = AnchorStyles.None;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridOgrenciler.SelectedRows.Count > 0)
            {
                int ogrenciId = Convert.ToInt32(dataGridOgrenciler.SelectedRows[0].Cells["ogrenci_id"].Value);

                DialogResult result = MessageBox.Show("Seçili öğrenciyi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Ayse123654;Database=kutuphane"))
                    {
                        conn.Open();

                        string sql = "DELETE FROM ogrenciler WHERE ogrenci_id = @ogrenci_id";

                        using (var cmd = new NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@ogrenci_id", ogrenciId);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Öğrenci başarıyla silindi.");
                        OgrencileriListele(); // Yeniden listele
                        Temizle(); // Alanları temizle
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek öğrenciyi seçin.");
            }
        }











        private void dataGridOgrenciler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridOgrenciler.Rows[e.RowIndex];

                    txtOgrenciAd.Text = row.Cells["ad"].Value.ToString();
                    txtOgrenciSoyad.Text = row.Cells["soyad"].Value.ToString();
                    txtOgrenciNo.Text = row.Cells["okul_no"].Value.ToString(); // Önemli
                    txtOgrenciTelefon.Text = row.Cells["telefon"].Value.ToString();
                    txtOgrenciMail.Text = row.Cells["eposta"].Value.ToString();
                    txtKullaniciAdi.Text = row.Cells["kullanici_adi"].Value.ToString();
                    txtSifre.Text = row.Cells["sifre"].Value.ToString();
                }
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
            {
                if (string.IsNullOrEmpty(txtOgrenciNo.Text))
                {
                    MessageBox.Show("Lütfen güncellenecek öğrenciyi seçin.");
                    return;
                }

                DialogResult result = MessageBox.Show("Seçili öğrenciyi güncellemek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Ayse123654;Database=kutuphane"))
                    {
                        conn.Open();

                        string sql = @"UPDATE ogrenciler 
                           SET ad = @ad, soyad = @soyad, telefon = @telefon, eposta = @eposta, kullanici_adi = @kullanici_adi, sifre = @sifre 
                           WHERE okul_no = @okul_no";

                        using (var cmd = new NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@ad", txtOgrenciAd.Text);
                            cmd.Parameters.AddWithValue("@soyad", txtOgrenciSoyad.Text);
                            cmd.Parameters.AddWithValue("@telefon", txtOgrenciTelefon.Text);
                            cmd.Parameters.AddWithValue("@eposta", txtOgrenciMail.Text);
                            cmd.Parameters.AddWithValue("@kullanici_adi", txtKullaniciAdi.Text);
                            cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);
                            cmd.Parameters.AddWithValue("@okul_no", txtOgrenciNo.Text);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Öğrenci bilgileri başarıyla güncellendi.");
                        OgrencileriListele(); // tabloyu güncelle
                        Temizle(); // textbox'ları temizle
                    }
                }
            }

        }

        private void dataGridOgrenciler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Başlık satırı değilse
            {
                DataGridViewRow row = dataGridOgrenciler.Rows[e.RowIndex];

                txtOgrenciAd.Text = row.Cells["ad"].Value.ToString();
                txtOgrenciSoyad.Text = row.Cells["soyad"].Value.ToString();
                txtOgrenciNo.Text = row.Cells["okul_no"].Value.ToString();
                txtOgrenciTelefon.Text = row.Cells["telefon"].Value.ToString();
                txtOgrenciMail.Text = row.Cells["eposta"].Value.ToString();
            }

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string connStr = "Host=localhost;Port=5432;Username=postgres;Password=Ayse123654;Database=kutuphane";

            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM ogrenciler";

                using (var da = new NpgsqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridOgrenciler.DataSource = dt;
                }

                conn.Close();
            }

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
           
            {
                string aranan = txtAra.Text.ToLower();

                foreach (DataGridViewRow row in dataGridOgrenciler.Rows)
                {
                    if (row.Cells["ad"].Value != null && row.Cells["soyad"].Value != null)
                    {
                        string ad = row.Cells["ad"].Value.ToString().ToLower();
                        string soyad = row.Cells["soyad"].Value.ToString().ToLower();

                        row.Visible = ad.Contains(aranan) || soyad.Contains(aranan);
                    }
                }
            }

        }

        private void lblOgrenciSayisi_Click(object sender, EventArgs e)
        {

        }
    }
}
