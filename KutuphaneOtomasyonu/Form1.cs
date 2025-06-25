
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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                KitaplariListele();//Form Yüklenince Otomatik Listelemek İçin
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            panel1.Anchor = AnchorStyles.None;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKitapAdi.Text) ||
    string.IsNullOrWhiteSpace(txtYazar.Text) ||
    string.IsNullOrWhiteSpace(txtSayfaSayisi.Text) ||
    string.IsNullOrWhiteSpace(txtYayinYili.Text) ||
    string.IsNullOrWhiteSpace(txtRafNo.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // durdur
            }
            using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Ayse123654;Database=kutuphane"))
            {
                conn.Open();

                string sql = "INSERT INTO kitaplar (kitap_adi, yazar, sayfa_sayisi, yayin_yili, raf_no, stok) " +
              "VALUES (@kitap_adi, @yazar, @sayfa_sayisi, @yayin_yili, @raf_no, @stok)";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@kitap_adi", txtKitapAdi.Text);
                    cmd.Parameters.AddWithValue("@yazar", txtYazar.Text);
                    cmd.Parameters.AddWithValue("@sayfa_sayisi", int.Parse(txtSayfaSayisi.Text));
                    cmd.Parameters.AddWithValue("@yayin_yili", int.Parse(txtYayinYili.Text));
                    cmd.Parameters.AddWithValue("@raf_no", txtRafNo.Text);
                    cmd.Parameters.AddWithValue("@stok", 1);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kitap başarıyla eklendi.");
                }

                conn.Close();
                KitaplariListele();
            }
        }
        // BURAYA EKLE 👇👇👇
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKitaplar.Rows[e.RowIndex];

                txtKitapAdi.Text = row.Cells["ad"].Value.ToString();
                txtYazar.Text = row.Cells["yazar"].Value.ToString();
                txtSayfaSayisi.Text = row.Cells["sayfa_sayisi"].Value.ToString();
                txtYayinYili.Text = row.Cells["yayin_yili"].Value.ToString();
                txtRafNo.Text = row.Cells["raf_no"].Value.ToString();
            }
        }
        private void KitaplariListele()
        {
            using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Ayse123654;Database=kutuphane"))
            {
                conn.Open();
                var da = new NpgsqlDataAdapter("SELECT * FROM kitaplar", conn);
                var dt = new DataTable();
                da.Fill(dt);
                dgvKitaplar.DataSource = dt;  // 👈 Burada "dgvKitaplar" senin DataGridView kontrolünün adıdır. Değiştiyse kendi adını yaz.
                conn.Close();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // 1. Hiç satır seçilmemişse uyar
            if (dgvKitaplar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir kitap seçin!");
                return;
            }

            // 2. Seçilen satırdan kitap_id'yi al
            int kitapId = Convert.ToInt32(dgvKitaplar.SelectedRows[0].Cells["kitap_id"].Value); // sütun adı doğruysa

            // 3. Kullanıcıya emin misiniz sor
            DialogResult onay = MessageBox.Show("Seçili kitabı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.No)
                return;

            // 4. Silme işlemi
            using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Ayse123654;Database=kutuphane"))
            {
                conn.Open();
                string sql = "DELETE FROM kitaplar WHERE kitap_id = @id";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", kitapId);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }

            // 5. Tabloyu güncelle
            KitaplariListele();
            MessageBox.Show("Kitap başarıyla silindi.");
        }

        private void dgvKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKitaplar.Rows[e.RowIndex];

                txtKitapAdi.Text = row.Cells["kitap_adi"].Value.ToString();
                txtYazar.Text = row.Cells["yazar"].Value.ToString();
                txtSayfaSayisi.Text = row.Cells["sayfa_sayisi"].Value.ToString();
                txtYayinYili.Text = row.Cells["yayin_yili"].Value.ToString();
                txtRafNo.Text = row.Cells["raf_no"].Value.ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvKitaplar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek için bir kitap seçin!");
                return;
            }

            int kitapId = Convert.ToInt32(dgvKitaplar.SelectedRows[0].Cells[0].Value);

            // Sayısal alanları doğrula
            int sayfaSayisi, yayinYili;

            if (!int.TryParse(txtSayfaSayisi.Text, out sayfaSayisi))
            {
                MessageBox.Show("Sayfa sayısı geçerli bir sayı değil!");
                return;
            }

            if (!int.TryParse(txtYayinYili.Text, out yayinYili))
            {
                MessageBox.Show("Yayın yılı geçerli bir sayı değil!");
                return;
            }

            using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Ayse123654;Database=kutuphane"))
            {
                conn.Open();

                string sql = @"UPDATE kitaplar 
               SET kitap_adi = @kitap_adi, 
                   yazar = @yazar, 
                   sayfa_sayisi = @sayfa_sayisi, 
                   yayin_yili = @yayin_yili, 
                   raf_no = @raf_no 
               WHERE kitap_id = @kitap_id";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@kitap_adi", txtKitapAdi.Text);
                    cmd.Parameters.AddWithValue("@yazar", txtYazar.Text);
                    cmd.Parameters.AddWithValue("@sayfa_sayisi", sayfaSayisi);
                    cmd.Parameters.AddWithValue("@yayin_yili", yayinYili);
                    cmd.Parameters.AddWithValue("@raf_no", txtRafNo.Text);
                    cmd.Parameters.AddWithValue("@kitap_id", kitapId);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }

            KitaplariListele();
            MessageBox.Show("Kitap başarıyla güncellendi.");
        }
        private void TemizleForm()
        {
            txtKitapAdi.Clear();
            txtYazar.Clear();
            txtSayfaSayisi.Clear();
            txtYayinYili.Clear();
            txtRafNo.Clear();
        }
        

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            TemizleForm();
            dgvKitaplar.ClearSelection(); // Seçimi de kaldır
        }

        private void dgvKitaplar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
