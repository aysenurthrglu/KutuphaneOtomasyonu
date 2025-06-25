namespace KutuphaneOtomasyonu
{
    partial class Form1
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
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.lblYazar = new System.Windows.Forms.Label();
            this.lblSayfaSayisi = new System.Windows.Forms.Label();
            this.lblYayinYili = new System.Windows.Forms.Label();
            this.lblRafNo = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.txtYayinYili = new System.Windows.Forms.TextBox();
            this.txtRafNo = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapAdi.ForeColor = System.Drawing.Color.Navy;
            this.lblKitapAdi.Location = new System.Drawing.Point(66, 83);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(232, 112);
            this.lblKitapAdi.TabIndex = 0;
            this.lblKitapAdi.Text = "Kitap Adı:";
            // 
            // lblYazar
            // 
            this.lblYazar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazar.ForeColor = System.Drawing.Color.Navy;
            this.lblYazar.Location = new System.Drawing.Point(66, 167);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(208, 89);
            this.lblYazar.TabIndex = 1;
            this.lblYazar.Text = "Yazar:";
            // 
            // lblSayfaSayisi
            // 
            this.lblSayfaSayisi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayfaSayisi.ForeColor = System.Drawing.Color.Navy;
            this.lblSayfaSayisi.Location = new System.Drawing.Point(66, 247);
            this.lblSayfaSayisi.Name = "lblSayfaSayisi";
            this.lblSayfaSayisi.Size = new System.Drawing.Size(208, 89);
            this.lblSayfaSayisi.TabIndex = 2;
            this.lblSayfaSayisi.Text = "Sayfa Sayısı:";
            // 
            // lblYayinYili
            // 
            this.lblYayinYili.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYayinYili.ForeColor = System.Drawing.Color.Navy;
            this.lblYayinYili.Location = new System.Drawing.Point(66, 312);
            this.lblYayinYili.Name = "lblYayinYili";
            this.lblYayinYili.Size = new System.Drawing.Size(208, 89);
            this.lblYayinYili.TabIndex = 3;
            this.lblYayinYili.Text = "Yayın Yılı:";
            // 
            // lblRafNo
            // 
            this.lblRafNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRafNo.ForeColor = System.Drawing.Color.Navy;
            this.lblRafNo.Location = new System.Drawing.Point(66, 394);
            this.lblRafNo.Name = "lblRafNo";
            this.lblRafNo.Size = new System.Drawing.Size(208, 89);
            this.lblRafNo.TabIndex = 4;
            this.lblRafNo.Text = "Raf No:";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKitapAdi.Location = new System.Drawing.Point(227, 83);
            this.txtKitapAdi.Multiline = true;
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(217, 41);
            this.txtKitapAdi.TabIndex = 5;
            // 
            // txtYazar
            // 
            this.txtYazar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYazar.Location = new System.Drawing.Point(227, 167);
            this.txtYazar.Multiline = true;
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(217, 41);
            this.txtYazar.TabIndex = 6;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSayfaSayisi.Location = new System.Drawing.Point(227, 238);
            this.txtSayfaSayisi.Multiline = true;
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(217, 41);
            this.txtSayfaSayisi.TabIndex = 7;
            // 
            // txtYayinYili
            // 
            this.txtYayinYili.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYayinYili.Location = new System.Drawing.Point(227, 312);
            this.txtYayinYili.Multiline = true;
            this.txtYayinYili.Name = "txtYayinYili";
            this.txtYayinYili.Size = new System.Drawing.Size(217, 41);
            this.txtYayinYili.TabIndex = 8;
            // 
            // txtRafNo
            // 
            this.txtRafNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRafNo.Location = new System.Drawing.Point(227, 394);
            this.txtRafNo.Multiline = true;
            this.txtRafNo.Name = "txtRafNo";
            this.txtRafNo.Size = new System.Drawing.Size(217, 41);
            this.txtRafNo.TabIndex = 9;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(464, 457);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(222, 60);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Kitap Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgvKitaplar
            // 
            this.dgvKitaplar.BackgroundColor = System.Drawing.Color.White;
            this.dgvKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitaplar.GridColor = System.Drawing.Color.Gray;
            this.dgvKitaplar.Location = new System.Drawing.Point(464, 29);
            this.dgvKitaplar.Name = "dgvKitaplar";
            this.dgvKitaplar.RowHeadersWidth = 51;
            this.dgvKitaplar.RowTemplate.Height = 24;
            this.dgvKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKitaplar.Size = new System.Drawing.Size(508, 406);
            this.dgvKitaplar.TabIndex = 11;
            this.dgvKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKitaplar_CellClick);
            this.dgvKitaplar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKitaplar_CellContentClick);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(750, 551);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(222, 61);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.AutoSize = true;
            this.btnGuncelle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(750, 457);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(222, 60);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(464, 551);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(222, 61);
            this.btnTemizle.TabIndex = 14;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.dgvKitaplar);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.txtRafNo);
            this.panel1.Controls.Add(this.txtYayinYili);
            this.panel1.Controls.Add(this.txtSayfaSayisi);
            this.panel1.Controls.Add(this.txtYazar);
            this.panel1.Controls.Add(this.txtKitapAdi);
            this.panel1.Controls.Add(this.lblRafNo);
            this.panel1.Controls.Add(this.lblYayinYili);
            this.panel1.Controls.Add(this.lblSayfaSayisi);
            this.panel1.Controls.Add(this.lblYazar);
            this.panel1.Controls.Add(this.lblKitapAdi);
            this.panel1.Location = new System.Drawing.Point(12, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 652);
            this.panel1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1098, 690);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.Label lblSayfaSayisi;
        private System.Windows.Forms.Label lblYayinYili;
        private System.Windows.Forms.Label lblRafNo;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.TextBox txtYayinYili;
        private System.Windows.Forms.TextBox txtRafNo;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgvKitaplar;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Panel panel1;
    }
}

