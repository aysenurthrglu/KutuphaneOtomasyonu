namespace KutuphaneOtomasyonu
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKullaniciTuru = new System.Windows.Forms.Label();
            this.cmbKullaniciTuru = new System.Windows.Forms.ComboBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKullaniciTuru
            // 
            this.lblKullaniciTuru.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciTuru.ForeColor = System.Drawing.Color.Firebrick;
            this.lblKullaniciTuru.Location = new System.Drawing.Point(207, 266);
            this.lblKullaniciTuru.Name = "lblKullaniciTuru";
            this.lblKullaniciTuru.Size = new System.Drawing.Size(228, 75);
            this.lblKullaniciTuru.TabIndex = 0;
            this.lblKullaniciTuru.Text = "Kullanıcı Türü:";
            this.lblKullaniciTuru.Click += new System.EventHandler(this.lblKullaniciTuru_Click);
            // 
            // cmbKullaniciTuru
            // 
            this.cmbKullaniciTuru.FormattingEnabled = true;
            this.cmbKullaniciTuru.Items.AddRange(new object[] {
            "Öğrenci",
            "Görevli"});
            this.cmbKullaniciTuru.Location = new System.Drawing.Point(376, 266);
            this.cmbKullaniciTuru.Name = "cmbKullaniciTuru";
            this.cmbKullaniciTuru.Size = new System.Drawing.Size(249, 24);
            this.cmbKullaniciTuru.TabIndex = 1;
            this.cmbKullaniciTuru.Text = "Öğrenci / Görevli ";
            this.cmbKullaniciTuru.SelectedIndexChanged += new System.EventHandler(this.cmbKullaniciTuru_SelectedIndexChanged);
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.Firebrick;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(207, 309);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(130, 39);
            this.lblKullaniciAdi.TabIndex = 2;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            this.lblKullaniciAdi.Click += new System.EventHandler(this.lblKullaniciAdi_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(376, 313);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(249, 22);
            this.txtKullaniciAdi.TabIndex = 3;
            this.txtKullaniciAdi.Text = "Kullanıcı adı";
            this.txtKullaniciAdi.TextChanged += new System.EventHandler(this.txtKullaniciAdi_TextChanged);
            // 
            // lblSifre
            // 
            this.lblSifre.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSifre.Location = new System.Drawing.Point(278, 354);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(112, 42);
            this.lblSifre.TabIndex = 4;
            this.lblSifre.Text = "Şifre:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(376, 358);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(249, 22);
            this.txtSifre.TabIndex = 5;
            this.txtSifre.Text = "Şifre";
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.Firebrick;
            this.btnGiris.Location = new System.Drawing.Point(176, 445);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(248, 59);
            this.btnGiris.TabIndex = 6;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::KutuphaneOtomasyonu.Properties.Resources.kilt;
            this.pictureBox2.Location = new System.Drawing.Point(455, 445);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::KutuphaneOtomasyonu.Properties.Resources.login_icon_vector;
            this.pictureBox1.Location = new System.Drawing.Point(303, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Firebrick;
            this.button1.Location = new System.Drawing.Point(176, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 62);
            this.button1.TabIndex = 9;
            this.button1.Text = "Şifre Değiştir(Öğrenci)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnGiris);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.lblSifre);
            this.panel1.Controls.Add(this.txtKullaniciAdi);
            this.panel1.Controls.Add(this.lblKullaniciAdi);
            this.panel1.Controls.Add(this.cmbKullaniciTuru);
            this.panel1.Controls.Add(this.lblKullaniciTuru);
            this.panel1.Location = new System.Drawing.Point(26, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 624);
            this.panel1.TabIndex = 10;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1025, 734);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblKullaniciTuru;
        private System.Windows.Forms.ComboBox cmbKullaniciTuru;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}