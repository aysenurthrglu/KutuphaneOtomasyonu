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
    public partial class LoginForm : Form
    {
        public static string girisYapanKullaniciAdi;

        public LoginForm()
        {
            
            
            {
                InitializeComponent();
                this.Load += new System.EventHandler(this.LoginForm_Load);

                cmbKullaniciTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            }
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
        private void LoginForm_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            panel1.Anchor = AnchorStyles.None;

            {
                cmbKullaniciTuru.Items.Clear(); // varsa önce temizle
                cmbKullaniciTuru.Items.Add("Öğrenci");
                cmbKullaniciTuru.Items.Add("Personel");
                cmbKullaniciTuru.SelectedIndex = 0; // varsayılan seçim
            }

            txtSifre.PasswordChar = '*';
            {
                txtKullaniciAdi.Click += TextBox_Click_ClearText;
                txtSifre.Click += TextBox_Click_ClearText;
               
            }

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            {
                string kullaniciAdi = txtKullaniciAdi.Text.Trim();
                string sifre = txtSifre.Text.Trim();
                string tur = cmbKullaniciTuru.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(tur))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                    return;
                }

                if (tur == "Öğrenci")
                {
                    using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Ayse123654;Database=kutuphane"))
                    {
                        conn.Open();

                        string sql = "SELECT COUNT(*) FROM ogrenciler WHERE LOWER(TRIM(kullanici_adi)) = LOWER(@kullaniciAdi) AND TRIM(sifre) = @sifre";


                        using (var cmd = new NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                            cmd.Parameters.AddWithValue("@sifre", sifre);
                            MessageBox.Show("Giriş başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);




                            int sonuc = Convert.ToInt32(cmd.ExecuteScalar());

                            if (sonuc > 0)
                            {
                               
                                LoginForm.girisYapanKullaniciAdi = kullaniciAdi;

                                this.Hide();
                                OgrenciBilgiForm ogrBilgiForm = new OgrenciBilgiForm();
                                ogrBilgiForm.FormClosed += (s, args) => this.Show();
                                ogrBilgiForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Öğrenci bilgileri hatalı.");
                            }
                        }

                        conn.Close();
                    }
                }






                else if (tur == "Personel")
                {
                    // Personel veritabanı kontrolü
                    if (kullaniciAdi == "personel" && sifre == "4321") // burası da veritabanına bağlanacak
                    {
                        this.Hide();
                        emanetform persForm = new emanetform();
                        
                        persForm.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Personel bilgileri hatalı.");
                    }

                }
            }

        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }

        private void cmbKullaniciTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // LoginForm gizlenir
            SifreDegistirForm sifreForm = new SifreDegistirForm();
            sifreForm.FormClosed += (s, args) => this.Show(); // Form kapanınca Login tekrar gösterilir
            sifreForm.Show();
        }

        private void lblKullaniciAdi_Click(object sender, EventArgs e)
        {

        }

        private void lblKullaniciTuru_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
