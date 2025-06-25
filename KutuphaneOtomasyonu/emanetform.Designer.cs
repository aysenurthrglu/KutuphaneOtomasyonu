namespace KutuphaneOtomasyonu
{
    partial class emanetform
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
            this.dgvEmanetler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrenciAra = new System.Windows.Forms.TextBox();
            this.lstOgrenciSonuc = new System.Windows.Forms.ListBox();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKitapAra = new System.Windows.Forms.TextBox();
            this.lstKitapSonuc = new System.Windows.Forms.ListBox();
            this.txtKitapNo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtVerilisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnKitapVer = new System.Windows.Forms.Button();
            this.btnKitapAl = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnYeniKitapEkle = new System.Windows.Forms.Button();
            this.btnYeniOgrenciEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmanetler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmanetler
            // 
            this.dgvEmanetler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmanetler.Location = new System.Drawing.Point(756, 20);
            this.dgvEmanetler.Name = "dgvEmanetler";
            this.dgvEmanetler.RowHeadersWidth = 51;
            this.dgvEmanetler.RowTemplate.Height = 24;
            this.dgvEmanetler.Size = new System.Drawing.Size(314, 356);
            this.dgvEmanetler.TabIndex = 9;
            this.dgvEmanetler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmanetler_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOgrenciNo);
            this.groupBox1.Controls.Add(this.lstOgrenciSonuc);
            this.groupBox1.Controls.Add(this.txtOgrenciAra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Location = new System.Drawing.Point(28, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 364);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Arama(numara)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(19, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ara";
            // 
            // txtOgrenciAra
            // 
            this.txtOgrenciAra.Location = new System.Drawing.Point(192, 35);
            this.txtOgrenciAra.Name = "txtOgrenciAra";
            this.txtOgrenciAra.Size = new System.Drawing.Size(126, 30);
            this.txtOgrenciAra.TabIndex = 2;
            this.txtOgrenciAra.TextChanged += new System.EventHandler(this.txtOgrenciAra_TextChanged);
            this.txtOgrenciAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOgrenciAra_KeyUp);
            // 
            // lstOgrenciSonuc
            // 
            this.lstOgrenciSonuc.FormattingEnabled = true;
            this.lstOgrenciSonuc.ItemHeight = 23;
            this.lstOgrenciSonuc.Location = new System.Drawing.Point(12, 79);
            this.lstOgrenciSonuc.Name = "lstOgrenciSonuc";
            this.lstOgrenciSonuc.Size = new System.Drawing.Size(314, 234);
            this.lstOgrenciSonuc.TabIndex = 4;
            this.lstOgrenciSonuc.SelectedIndexChanged += new System.EventHandler(this.lstOgrenciSonuc_SelectedIndexChanged);
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Enabled = false;
            this.txtOgrenciNo.Location = new System.Drawing.Point(12, 316);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(128, 30);
            this.txtOgrenciNo.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKitapNo);
            this.groupBox2.Controls.Add(this.lstKitapSonuc);
            this.groupBox2.Controls.Add(this.txtKitapAra);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Location = new System.Drawing.Point(416, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 364);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Arama(Kitap Adı)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(11, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Ara";
            // 
            // txtKitapAra
            // 
            this.txtKitapAra.Location = new System.Drawing.Point(169, 35);
            this.txtKitapAra.Name = "txtKitapAra";
            this.txtKitapAra.Size = new System.Drawing.Size(120, 30);
            this.txtKitapAra.TabIndex = 3;
            this.txtKitapAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKitapAra_KeyUp);
            // 
            // lstKitapSonuc
            // 
            this.lstKitapSonuc.FormattingEnabled = true;
            this.lstKitapSonuc.ItemHeight = 23;
            this.lstKitapSonuc.Location = new System.Drawing.Point(6, 79);
            this.lstKitapSonuc.Name = "lstKitapSonuc";
            this.lstKitapSonuc.Size = new System.Drawing.Size(295, 234);
            this.lstKitapSonuc.TabIndex = 5;
            this.lstKitapSonuc.SelectedIndexChanged += new System.EventHandler(this.lstKitapSonuc_SelectedIndexChanged);
            // 
            // txtKitapNo
            // 
            this.txtKitapNo.Enabled = false;
            this.txtKitapNo.Location = new System.Drawing.Point(15, 326);
            this.txtKitapNo.Name = "txtKitapNo";
            this.txtKitapNo.Size = new System.Drawing.Size(120, 30);
            this.txtKitapNo.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dtTeslimTarihi);
            this.groupBox3.Controls.Add(this.dtVerilisTarihi);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.AliceBlue;
            this.groupBox3.Location = new System.Drawing.Point(38, 398);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(866, 70);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alış-Teslim Tarihleri";
            // 
            // dtVerilisTarihi
            // 
            this.dtVerilisTarihi.Location = new System.Drawing.Point(132, 34);
            this.dtVerilisTarihi.Name = "dtVerilisTarihi";
            this.dtVerilisTarihi.Size = new System.Drawing.Size(260, 30);
            this.dtVerilisTarihi.TabIndex = 6;
            // 
            // dtTeslimTarihi
            // 
            this.dtTeslimTarihi.Location = new System.Drawing.Point(592, 29);
            this.dtTeslimTarihi.Name = "dtTeslimTarihi";
            this.dtTeslimTarihi.Size = new System.Drawing.Size(268, 30);
            this.dtTeslimTarihi.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(7, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Alış Tarihi:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(417, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Geri Teslim Tarihi:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnListele);
            this.groupBox4.Controls.Add(this.btnKitapAl);
            this.groupBox4.Controls.Add(this.btnKitapVer);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox4.Location = new System.Drawing.Point(249, 465);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(411, 66);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            // 
            // btnKitapVer
            // 
            this.btnKitapVer.Location = new System.Drawing.Point(6, 21);
            this.btnKitapVer.Name = "btnKitapVer";
            this.btnKitapVer.Size = new System.Drawing.Size(134, 36);
            this.btnKitapVer.TabIndex = 8;
            this.btnKitapVer.Text = "Kitap Ver";
            this.btnKitapVer.UseVisualStyleBackColor = true;
            this.btnKitapVer.Click += new System.EventHandler(this.btnKitapVer_Click);
            // 
            // btnKitapAl
            // 
            this.btnKitapAl.Location = new System.Drawing.Point(154, 21);
            this.btnKitapAl.Name = "btnKitapAl";
            this.btnKitapAl.Size = new System.Drawing.Size(120, 37);
            this.btnKitapAl.TabIndex = 10;
            this.btnKitapAl.Text = "Teslim Al";
            this.btnKitapAl.UseVisualStyleBackColor = true;
            this.btnKitapAl.Click += new System.EventHandler(this.btnKitapAl_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(295, 19);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(110, 40);
            this.btnListele.TabIndex = 11;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnYeniKitapEkle
            // 
            this.btnYeniKitapEkle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniKitapEkle.ForeColor = System.Drawing.Color.Navy;
            this.btnYeniKitapEkle.Location = new System.Drawing.Point(249, 546);
            this.btnYeniKitapEkle.Name = "btnYeniKitapEkle";
            this.btnYeniKitapEkle.Size = new System.Drawing.Size(187, 53);
            this.btnYeniKitapEkle.TabIndex = 26;
            this.btnYeniKitapEkle.Text = "Kitap İşlemleri";
            this.btnYeniKitapEkle.UseVisualStyleBackColor = true;
            this.btnYeniKitapEkle.Click += new System.EventHandler(this.btnYeniKitapEkle_Click);
            // 
            // btnYeniOgrenciEkle
            // 
            this.btnYeniOgrenciEkle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniOgrenciEkle.ForeColor = System.Drawing.Color.Navy;
            this.btnYeniOgrenciEkle.Location = new System.Drawing.Point(490, 546);
            this.btnYeniOgrenciEkle.Name = "btnYeniOgrenciEkle";
            this.btnYeniOgrenciEkle.Size = new System.Drawing.Size(180, 53);
            this.btnYeniOgrenciEkle.TabIndex = 27;
            this.btnYeniOgrenciEkle.Text = "Öğrenci İşlemleri";
            this.btnYeniOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnYeniOgrenciEkle.Click += new System.EventHandler(this.btnYeniOgrenciEkle_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(362, 615);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 63);
            this.button1.TabIndex = 28;
            this.button1.Text = "Numaraya Göre Geçmiş Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dgvEmanetler);
            this.panel1.Controls.Add(this.btnYeniOgrenciEkle);
            this.panel1.Controls.Add(this.btnYeniKitapEkle);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(40, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 699);
            this.panel1.TabIndex = 29;
            // 
            // emanetform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1229, 717);
            this.Controls.Add(this.panel1);
            this.Name = "emanetform";
            this.Text = "emanetform";
            this.Load += new System.EventHandler(this.emanetform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmanetler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEmanetler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.ListBox lstOgrenciSonuc;
        private System.Windows.Forms.TextBox txtOgrenciAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKitapNo;
        private System.Windows.Forms.ListBox lstKitapSonuc;
        private System.Windows.Forms.TextBox txtKitapAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtTeslimTarihi;
        private System.Windows.Forms.DateTimePicker dtVerilisTarihi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnKitapAl;
        private System.Windows.Forms.Button btnKitapVer;
        private System.Windows.Forms.Button btnYeniKitapEkle;
        private System.Windows.Forms.Button btnYeniOgrenciEkle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}