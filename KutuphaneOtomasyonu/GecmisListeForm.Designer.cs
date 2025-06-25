namespace KutuphaneOtomasyonu
{
    partial class GecmisListeForm
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
            this.btnUyarilariGonder = new System.Windows.Forms.Button();
            this.dataGridGecmis = new System.Windows.Forms.DataGridView();
            this.btnGecmisiListele = new System.Windows.Forms.Button();
            this.txtGecmisOgrenciNo = new System.Windows.Forms.TextBox();
            this.lblGecmis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGecmis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUyarilariGonder
            // 
            this.btnUyarilariGonder.BackColor = System.Drawing.SystemColors.Control;
            this.btnUyarilariGonder.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyarilariGonder.ForeColor = System.Drawing.Color.Navy;
            this.btnUyarilariGonder.Location = new System.Drawing.Point(306, 441);
            this.btnUyarilariGonder.Name = "btnUyarilariGonder";
            this.btnUyarilariGonder.Size = new System.Drawing.Size(224, 64);
            this.btnUyarilariGonder.TabIndex = 29;
            this.btnUyarilariGonder.Text = "Teslim Tarihi Uyarılarını Gönder";
            this.btnUyarilariGonder.UseVisualStyleBackColor = false;
            this.btnUyarilariGonder.Click += new System.EventHandler(this.btnUyarilariGonder_Click);
            // 
            // dataGridGecmis
            // 
            this.dataGridGecmis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGecmis.Location = new System.Drawing.Point(306, 191);
            this.dataGridGecmis.Name = "dataGridGecmis";
            this.dataGridGecmis.RowHeadersWidth = 51;
            this.dataGridGecmis.RowTemplate.Height = 24;
            this.dataGridGecmis.Size = new System.Drawing.Size(240, 227);
            this.dataGridGecmis.TabIndex = 28;
            // 
            // btnGecmisiListele
            // 
            this.btnGecmisiListele.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGecmisiListele.ForeColor = System.Drawing.Color.Navy;
            this.btnGecmisiListele.Location = new System.Drawing.Point(348, 122);
            this.btnGecmisiListele.Name = "btnGecmisiListele";
            this.btnGecmisiListele.Size = new System.Drawing.Size(134, 63);
            this.btnGecmisiListele.TabIndex = 27;
            this.btnGecmisiListele.Text = "Geçmişi Listele";
            this.btnGecmisiListele.UseVisualStyleBackColor = true;
            this.btnGecmisiListele.Click += new System.EventHandler(this.btnGecmisiListele_Click);
            // 
            // txtGecmisOgrenciNo
            // 
            this.txtGecmisOgrenciNo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGecmisOgrenciNo.ForeColor = System.Drawing.Color.Navy;
            this.txtGecmisOgrenciNo.Location = new System.Drawing.Point(325, 78);
            this.txtGecmisOgrenciNo.Name = "txtGecmisOgrenciNo";
            this.txtGecmisOgrenciNo.Size = new System.Drawing.Size(174, 30);
            this.txtGecmisOgrenciNo.TabIndex = 26;
            this.txtGecmisOgrenciNo.Text = "Öğrenci numarası:";
            this.txtGecmisOgrenciNo.TextChanged += new System.EventHandler(this.txtGecmisOgrenciNo_TextChanged);
            // 
            // lblGecmis
            // 
            this.lblGecmis.AutoSize = true;
            this.lblGecmis.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGecmis.ForeColor = System.Drawing.Color.Navy;
            this.lblGecmis.Location = new System.Drawing.Point(193, 81);
            this.lblGecmis.Name = "lblGecmis";
            this.lblGecmis.Size = new System.Drawing.Size(106, 23);
            this.lblGecmis.TabIndex = 25;
            this.lblGecmis.Text = "Öğrenci No:";
            this.lblGecmis.Click += new System.EventHandler(this.lblGecmis_Click);
            // 
            // GecmisListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 553);
            this.Controls.Add(this.btnUyarilariGonder);
            this.Controls.Add(this.dataGridGecmis);
            this.Controls.Add(this.btnGecmisiListele);
            this.Controls.Add(this.txtGecmisOgrenciNo);
            this.Controls.Add(this.lblGecmis);
            this.Name = "GecmisListeForm";
            this.Text = "GecmisListeForm";
            this.Load += new System.EventHandler(this.GecmisListeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGecmis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUyarilariGonder;
        private System.Windows.Forms.DataGridView dataGridGecmis;
        private System.Windows.Forms.Button btnGecmisiListele;
        private System.Windows.Forms.TextBox txtGecmisOgrenciNo;
        private System.Windows.Forms.Label lblGecmis;
    }
}