namespace KutuphaneOtomasyonu
{
    partial class SifreDegistirForm
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
            this.lblEskiSifre = new System.Windows.Forms.Label();
            this.txtEskiSifre = new System.Windows.Forms.TextBox();
            this.lblYeniSifre = new System.Windows.Forms.Label();
            this.lblTekrarSifre = new System.Windows.Forms.Label();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.txtTekrarSifre = new System.Windows.Forms.TextBox();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEskiSifre
            // 
            this.lblEskiSifre.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEskiSifre.ForeColor = System.Drawing.Color.Navy;
            this.lblEskiSifre.Location = new System.Drawing.Point(190, 88);
            this.lblEskiSifre.Name = "lblEskiSifre";
            this.lblEskiSifre.Size = new System.Drawing.Size(149, 41);
            this.lblEskiSifre.TabIndex = 0;
            this.lblEskiSifre.Text = "Eski Şifre:";
            // 
            // txtEskiSifre
            // 
            this.txtEskiSifre.Location = new System.Drawing.Point(417, 88);
            this.txtEskiSifre.Name = "txtEskiSifre";
            this.txtEskiSifre.PasswordChar = '*';
            this.txtEskiSifre.Size = new System.Drawing.Size(100, 22);
            this.txtEskiSifre.TabIndex = 1;
            // 
            // lblYeniSifre
            // 
            this.lblYeniSifre.AutoSize = true;
            this.lblYeniSifre.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYeniSifre.ForeColor = System.Drawing.Color.Navy;
            this.lblYeniSifre.Location = new System.Drawing.Point(190, 148);
            this.lblYeniSifre.Name = "lblYeniSifre";
            this.lblYeniSifre.Size = new System.Drawing.Size(121, 31);
            this.lblYeniSifre.TabIndex = 2;
            this.lblYeniSifre.Text = "Yeni Şifre:\n";
            // 
            // lblTekrarSifre
            // 
            this.lblTekrarSifre.AutoSize = true;
            this.lblTekrarSifre.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTekrarSifre.ForeColor = System.Drawing.Color.Navy;
            this.lblTekrarSifre.Location = new System.Drawing.Point(190, 215);
            this.lblTekrarSifre.Name = "lblTekrarSifre";
            this.lblTekrarSifre.Size = new System.Drawing.Size(209, 31);
            this.lblTekrarSifre.TabIndex = 3;
            this.lblTekrarSifre.Text = "Yeni Şifre (Tekrar):";
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(417, 148);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.PasswordChar = '*';
            this.txtYeniSifre.Size = new System.Drawing.Size(100, 22);
            this.txtYeniSifre.TabIndex = 4;
            // 
            // txtTekrarSifre
            // 
            this.txtTekrarSifre.Location = new System.Drawing.Point(417, 224);
            this.txtTekrarSifre.Name = "txtTekrarSifre";
            this.txtTekrarSifre.PasswordChar = '*';
            this.txtTekrarSifre.Size = new System.Drawing.Size(100, 22);
            this.txtTekrarSifre.TabIndex = 5;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDegistir.ForeColor = System.Drawing.Color.Navy;
            this.btnDegistir.Location = new System.Drawing.Point(238, 279);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(247, 123);
            this.btnDegistir.TabIndex = 6;
            this.btnDegistir.Text = "Şifreyi Güncelle";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(417, 32);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 22);
            this.txtKullaniciAdi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(190, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtKullaniciAdi);
            this.panel1.Controls.Add(this.btnDegistir);
            this.panel1.Controls.Add(this.txtTekrarSifre);
            this.panel1.Controls.Add(this.txtYeniSifre);
            this.panel1.Controls.Add(this.lblTekrarSifre);
            this.panel1.Controls.Add(this.lblYeniSifre);
            this.panel1.Controls.Add(this.txtEskiSifre);
            this.panel1.Controls.Add(this.lblEskiSifre);
            this.panel1.Location = new System.Drawing.Point(19, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 424);
            this.panel1.TabIndex = 9;
            // 
            // SifreDegistirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "SifreDegistirForm";
            this.Text = "SifreDegistirForm";
            this.Load += new System.EventHandler(this.SifreDegistirForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEskiSifre;
        private System.Windows.Forms.TextBox txtEskiSifre;
        private System.Windows.Forms.Label lblYeniSifre;
        private System.Windows.Forms.Label lblTekrarSifre;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.TextBox txtTekrarSifre;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}