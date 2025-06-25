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
using System.Net;
using System.Net.Mail;


namespace KutuphaneOtomasyonu
{
    public partial class emanetform : Form
    {
        public emanetform()
        {
            InitializeComponent();
        }
        private void TextBox_Click_ClearText(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null && txt.Tag == null) // ilk tıklamada siler
            {
                txt.Clear();
                txt.Tag = "clicked"; // bir daha silinmesin diye işaret
            }
        }
        private void MailGonder(string alici, string konu, string icerik)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("seninmailin@gmail.com"); // kendi mail adresin
            mail.To.Add(alici);
            mail.Subject = konu;
            mail.Body = icerik;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("seninmailin@gmail.com", "uygulama_sifresi"); // şifreni buraya yaz
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail gönderilemedi: " + ex.Message);
            }
        }

        private void EmanetleriListele()
        {
            using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Ayse123654;Database=kutuphane"))
            {
                conn.Open();

                string sql = @"
            SELECT 
                o.odunc_id,
                ogr.ad AS ogrenci_ad,
                k.kitap_adi,
                o.alis_tarihi,
                o.teslim_tarihi,
                CASE 
                    WHEN o.teslim_edildi THEN 'Teslim Edildi'
                    ELSE 'Teslim Edilmedi'
                END AS durum
            FROM odunc o
            JOIN ogrenciler ogr ON o.ogrenci_id = ogr.ogrenci_id
            JOIN kitaplar k ON o.kitap_id = k.kitap_id
WHERE o.teslim_edildi = false
            ORDER BY o.alis_tarihi DESC;
        ";

                using (var da = new NpgsqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvEmanetler.DataSource = dt;
                }

                conn.Close();
            }
        }
        private void txtKitapAra_KeyUp(object sender, KeyEventArgs e)
      
        {
            using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Ayse123654;Database=kutuphane"))
            {
                conn.Open();

                string sql = "SELECT kitap_id, kitap_adi, yazar FROM kitaplar WHERE kitap_adi ILIKE @kitapAdi";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@kitapAdi", "%" + txtKitapAra.Text + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        lstKitapSonuc.Items.Clear();
                        while (reader.Read())
                        {
                            int kitapId = Convert.ToInt32(reader["kitap_id"]);
                            string kitapAdi = reader["kitap_adi"].ToString();
                            string yazar = reader["yazar"].ToString();

                            lstKitapSonuc.Items.Add($"{kitapId} - {kitapAdi} - {yazar}");
                        }
                    }
                }

                conn.Close();
            }
        }


        private void TeslimTarihiYaklasanlariBul()
        {
            using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Ayse123654;Database=kutuphane"))
            {
                conn.Open();

                string sql =  @"
    SELECT ogr.ogrenci_id, ogr.eposta AS email, od.kitap_id, od.teslim_tarihi
    FROM odunc od
    JOIN ogrenciler ogr ON od.ogrenci_id = ogr.ogrenci_id
    WHERE od.teslim_tarihi BETWEEN CURRENT_DATE AND CURRENT_DATE + INTERVAL '3 days'";



                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string email = reader["email"].ToString();
                        string kitapNo = reader["kitap_id"].ToString();
                        string teslimTarihi = Convert.ToDateTime(reader["teslim_tarihi"]).ToShortDateString();

                        string konu = "Kitap Teslim Tarihiniz Yaklaşıyor!";
                        string icerik = $"Teslim tarihine yaklaşan bir kitabınız var.\nKitap No: {kitapNo}\nTeslim Tarihi: {teslimTarihi}";

                        MailGonder(email, konu, icerik);
                    }
                }

                conn.Close();
            }

            MessageBox.Show("Uyarı e-postaları gönderildi.");
        }
        private void OgrenciListele()
        {
            using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Ayse123654;Database=kutuphane"))
            {
                conn.Open();

                string sql = "SELECT ogrenci_id, okul_no, ad, soyad FROM ogrenciler WHERE okul_no ILIKE @no";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@no", "%" + txtOgrenciAra.Text + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        lstOgrenciSonuc.Items.Clear();
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["ogrenci_id"]);
                            string okulNo = reader["okul_no"].ToString();
                            string ad = reader["ad"].ToString();
                            string soyad = reader["soyad"].ToString();

                            lstOgrenciSonuc.Items.Add($"{id} - {okulNo} - {ad} {soyad}");
                        }
                    }
                }

                conn.Close();
            }
        }

        private void KitaplariListele()
        {
            using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Ayse123654;Database=kutuphane"))
            {
                conn.Open();
                string sql = "SELECT * FROM kitaplar";
                using (var da = new NpgsqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvEmanetler.DataSource = dt; // varsa bir DataGridView
                }
                conn.Close();
            }
        }

        private void btnKitapVer_Click(object sender, EventArgs e)
        {
           
            {
                if (string.IsNullOrWhiteSpace(txtOgrenciNo.Text) ||
                    string.IsNullOrWhiteSpace(txtKitapNo.Text))
                {
                    MessageBox.Show("Lütfen öğrenci ve kitap seçiniz.");
                    return;
                }

                int ogrenciId = int.Parse(txtOgrenciNo.Text);
                int kitapId = int.Parse(txtKitapNo.Text);
                DateTime alisTarihi = dtVerilisTarihi.Value;
                DateTime teslimTarihi = dtTeslimTarihi.Value;

                using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Ayse123654;Database=kutuphane"))
                {
                    conn.Open();

                    // 1. Kitap stok kontrolü
                    string stokSorgu = "SELECT stok FROM kitaplar WHERE kitap_id = @kitapId";
                    using (var cmd = new NpgsqlCommand(stokSorgu, conn))
                    {
                        cmd.Parameters.AddWithValue("@kitapId", kitapId);
                        int stok = Convert.ToInt32(cmd.ExecuteScalar());

                        if (stok <= 0)
                        {
                            MessageBox.Show("Bu kitap şu anda stokta yok.");
                            return;
                        }
                    }

                    // 2. Daha önce teslim edilmemiş aynı kitap kontrolü
                    string kontrolSql = "SELECT COUNT(*) FROM odunc WHERE ogrenci_id = @ogrenciId AND kitap_id = @kitapId AND teslim_edildi = false";
                    using (var kontrolCmd = new NpgsqlCommand(kontrolSql, conn))
                    {
                        kontrolCmd.Parameters.AddWithValue("@ogrenciId", ogrenciId);
                        kontrolCmd.Parameters.AddWithValue("@kitapId", kitapId);
                        int mevcut = Convert.ToInt32(kontrolCmd.ExecuteScalar());

                        if (mevcut > 0)
                        {
                            MessageBox.Show("Bu kitap zaten bu öğrenciye verilmiş ve henüz teslim edilmemiş.");
                            return;
                        }
                    }

                    // 3. Ödünç kaydı ekle
                    string ekleSql = "INSERT INTO odunc (ogrenci_id, kitap_id, alis_tarihi, teslim_tarihi, teslim_edildi) " +
                                     "VALUES (@ogrenciId, @kitapId, @alisTarihi, @teslimTarihi, false)";
                    using (var cmd = new NpgsqlCommand(ekleSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ogrenciId", ogrenciId);
                        cmd.Parameters.AddWithValue("@kitapId", kitapId);
                        cmd.Parameters.AddWithValue("@alisTarihi", alisTarihi);
                        cmd.Parameters.AddWithValue("@teslimTarihi", teslimTarihi);
                        cmd.ExecuteNonQuery();
                    }

                    // 4. Kitap stok azalt
                    string stokAzaltSql = "UPDATE kitaplar SET stok = stok - 1 WHERE kitap_id = @kitapId";
                    using (var cmd = new NpgsqlCommand(stokAzaltSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@kitapId", kitapId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Kitap başarıyla ödünç verildi.");
                    
                    conn.Close();
                }
                EmanetleriListele();
                // Listeyi güncellemek istiyorsan buraya:
                // EmanetleriListele();
            }





        }
        private void GecikenTeslimKontrol()
        {
            foreach (DataGridViewRow row in dgvEmanetler.Rows)
            {
                if (row.Cells["teslim_tarihi"].Value != null &&
                    DateTime.TryParse(row.Cells["teslim_tarihi"].Value.ToString(), out DateTime teslimTarihi))
                {
                    if (teslimTarihi < DateTime.Today)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                        row.Cells["teslim_tarihi"].ToolTipText = "⚠️ Teslim tarihi geçmiş!";
                    }
                }
            }
        }

        private void emanetform_Load(object sender, EventArgs e)
        
        {
            EmanetleriListele();
            txtOgrenciNo.ReadOnly = true;
            txtOgrenciNo.BackColor = SystemColors.Control;

            txtKitapNo.ReadOnly = true;
            txtKitapNo.BackColor = SystemColors.Control;
          
            {
                TeslimTarihiYaklasanlariBul();
            }
            {
                txtOgrenciNo.Click += TextBox_Click_ClearText;
                txtKitapNo.Click += TextBox_Click_ClearText;
                txtOgrenciAra.Click += TextBox_Click_ClearText;
                txtKitapAra.Click += TextBox_Click_ClearText;
               
            }
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            panel1.Anchor = AnchorStyles.None;
        }

        private void btnKitapAl_Click(object sender, EventArgs e)
        {

           
            {
                if (string.IsNullOrWhiteSpace(txtOgrenciNo.Text) ||
                    string.IsNullOrWhiteSpace(txtKitapNo.Text))
                {
                    MessageBox.Show("Lütfen öğrenci ve kitap seçiniz.");
                    return;
                }

                int ogrenciId = int.Parse(txtOgrenciNo.Text);
                int kitapId = int.Parse(txtKitapNo.Text);

                using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Ayse123654;Database=kutuphane"))
                {
                    conn.Open();

                    // 1. Teslim edilmemiş ödünç kaydı kontrolü
                    string kontrolSql = "SELECT COUNT(*) FROM odunc WHERE ogrenci_id = @ogrenciId AND kitap_id = @kitapId AND teslim_edildi = false";
                    using (var kontrolCmd = new NpgsqlCommand(kontrolSql, conn))
                    {
                        kontrolCmd.Parameters.AddWithValue("@ogrenciId", ogrenciId);
                        kontrolCmd.Parameters.AddWithValue("@kitapId", kitapId);
                        int mevcut = Convert.ToInt32(kontrolCmd.ExecuteScalar());

                        if (mevcut == 0)
                        {
                            MessageBox.Show("Bu kitap zaten teslim alınmış veya hiç verilmemiş.");
                            return;
                        }
                    }

                    // 2. Teslim edildi olarak işaretle
                    string teslimEtSql = "UPDATE odunc SET teslim_edildi = true WHERE ogrenci_id = @ogrenciId AND kitap_id = @kitapId AND teslim_edildi = false";
                    using (var cmd = new NpgsqlCommand(teslimEtSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ogrenciId", ogrenciId);
                        cmd.Parameters.AddWithValue("@kitapId", kitapId);
                        cmd.ExecuteNonQuery();
                    }

                    // 3. Stok geri artır
                    string stokArtirSql = "UPDATE kitaplar SET stok = stok + 1 WHERE kitap_id = @kitapId";
                    using (var cmd = new NpgsqlCommand(stokArtirSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@kitapId", kitapId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Kitap başarıyla teslim alındı.");
                    conn.Close();
                }

                EmanetleriListele();
                KitaplariListele();// İstersen listeyi güncelle
                // EmanetleriListele();
            }

        }

        private void dgvEmanetler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
       
        {
            if (!int.TryParse(txtOgrenciNo.Text, out int ogrenciId))
            {
                MessageBox.Show("Lütfen geçerli bir öğrenci numarası girin.");
                return;
            }

            using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Ayse123654;Database=kutuphane"))
            {
                conn.Open();

                string sql = @"
SELECT k.kitap_adi, o.alis_tarihi, o.teslim_tarihi
FROM odunc o
JOIN kitaplar k ON o.kitap_id = k.kitap_id
WHERE o.ogrenci_id = @ogrenciId";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ogrenciId", ogrenciId);

                    using (var da = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count == dgvEmanetler.Rows.Count && dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Zaten listelenebilecek tüm ödünç kayıtları gösteriliyor.");
                        }

                        dgvEmanetler.DataSource = dt;
                    }
                }

                conn.Close();
            }

            EmanetleriListele();
            GecikenTeslimKontrol();
        }


        private void lstOgrenciSonuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            {
                if (lstOgrenciSonuc.SelectedItem != null)
                {
                    string secilen = lstOgrenciSonuc.SelectedItem.ToString();
                    string[] parcalar = secilen.Split('-');
                    txtOgrenciNo.Text = parcalar[0].Trim(); // ID alınıyor
                }
            }

        }

        private void lstKitapSonuc_SelectedIndexChanged(object sender, EventArgs e)
      
        {
            if (lstKitapSonuc.SelectedItem != null)
            {
                string secilen = lstKitapSonuc.SelectedItem.ToString();
                string[] parcalar = secilen.Split('-');
                if (parcalar.Length > 0)
                {
                    txtKitapNo.Text = parcalar[0].Trim(); // kitap_id'yi gizli textboxa yaz
                }
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        


       

        

       

        private void txtOgrenciAra_KeyUp(object sender, KeyEventArgs e)

        { 
            OgrenciListele();
        }

        private void btnYeniKitapEkle_Click(object sender, EventArgs e)
        {
           
            {
                Form1 kitapForm = new Form1();
                this.Hide();
                kitapForm.ShowDialog(); // KitapForm'u modal olarak aç
                this.Show();                    // İsteğe bağlı: KitapForm kapandıktan sonra kitap listesini güncelle
                KitaplariListele();
            }

        }

        private void btnYeniOgrenciEkle_Click(object sender, EventArgs e)
        {
            ogrenciform ogrForm = new ogrenciform();
            this.Hide();
            ogrForm.ShowDialog();
            this.Show();
            OgrenciListele();
        }

        private void txtGecmisOgrenciNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridGecmis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GecmisListeForm gecmisForm = new GecmisListeForm();
            
            gecmisForm.ShowDialog();
            this.Show();
        }

        private void txtOgrenciAra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
