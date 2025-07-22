using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class GecmisListeForm : Form
    {
        public GecmisListeForm()
        {
            InitializeComponent();
        }
        private void TextBox_Click_ClearText(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null && txt.Tag == null) 
            {
                txt.Clear();
                txt.Tag = "clicked"; 
            }
        }
        private void MailGonder(string alici, string konu, string icerik)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("seninmailin@gmail.com"); 
            mail.To.Add(alici);
            mail.Subject = konu;
            mail.Body = icerik;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("seninmailin@gmail.com", "uygulama_sifresi"); 
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
        private void TeslimTarihiYaklasanlariBul()
        {
            using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Ayse123654;Database=kutuphane"))
            {
                conn.Open();

                string sql = @"
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
        private void lblGecmis_Click(object sender, EventArgs e)
        {

        }

        private void txtGecmisOgrenciNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGecmisiListele_Click(object sender, EventArgs e)

        {
            if (string.IsNullOrWhiteSpace(txtGecmisOgrenciNo.Text))
            {
                MessageBox.Show("Lütfen öğrenci numarası girin.");
                return;
            }

            using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Ayse123654;Database=kutuphane"))
            {
                conn.Open();

                string sql = @"
            SELECT 
                o.ogrenci_id,
                ogr.ad AS ogrenci_adi,
                ogr.soyad AS ogrenci_soyadi,
                ogr.okul_no,
                k.kitap_adi,
                o.alis_tarihi,
                o.teslim_tarihi,
                o.teslim_edildi
            FROM odunc o
            JOIN kitaplar k ON o.kitap_id = k.kitap_id
            JOIN ogrenciler ogr ON o.ogrenci_id = ogr.ogrenci_id
            WHERE ogr.okul_no = @no"; // okul numarasıyla sorgulama

                using (var da = new NpgsqlDataAdapter(sql, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@no", txtGecmisOgrenciNo.Text);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridGecmis.DataSource = dt;
                }

                conn.Close();
            }
        }

        private void btnUyarilariGonder_Click(object sender, EventArgs e)
        {

            TeslimTarihiYaklasanlariBul();

        }

        private void GecmisListeForm_Load(object sender, EventArgs e)
        {
            {
                txtGecmisOgrenciNo.Click += TextBox_Click_ClearText;
                
            }
        }
    }
}
