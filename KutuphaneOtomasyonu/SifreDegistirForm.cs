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
    public partial class SifreDegistirForm : Form
    {
        public SifreDegistirForm()
        {
            InitializeComponent();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
       
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string eskiSifre = txtEskiSifre.Text.Trim();
            string yeniSifre = txtYeniSifre.Text.Trim();
            string yeniSifreTekrar = txtTekrarSifre.Text.Trim();

            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(eskiSifre) ||
                string.IsNullOrWhiteSpace(yeniSifre) || string.IsNullOrWhiteSpace(yeniSifreTekrar))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            if (yeniSifre != yeniSifreTekrar)
            {
                MessageBox.Show("Yeni şifreler uyuşmuyor.");
                return;
            }

            using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Ayse123654;Database=kutuphane"))
            {
                conn.Open();

                string sqlKontrol = "SELECT COUNT(*) FROM ogrenciler WHERE kullanici_adi = @kullaniciAdi AND sifre = @sifre";
                using (var cmd = new NpgsqlCommand(sqlKontrol, conn))
                {
                    cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@sifre", eskiSifre);

                    int sonuc = Convert.ToInt32(cmd.ExecuteScalar());
                    if (sonuc == 0)
                    {
                        MessageBox.Show("Kullanıcı adı veya mevcut şifre yanlış.");
                        return;
                    }
                }

                string sqlGuncelle = "UPDATE ogrenciler SET sifre = @yeniSifre WHERE kullanici_adi = @kullaniciAdi";
                using (var cmd = new NpgsqlCommand(sqlGuncelle, conn))
                {
                    cmd.Parameters.AddWithValue("@yeniSifre", yeniSifre);
                    cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Şifre başarıyla güncellendi.");
                this.Close();
                conn.Close();
            }
        }

        private void SifreDegistirForm_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            panel1.Anchor = AnchorStyles.None;
        }
    }
}
