namespace DirencEsdegerHesabi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBaglanti = new System.Windows.Forms.ComboBox();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.nudDirenc1 = new System.Windows.Forms.NumericUpDown();
            this.nudDirenc2 = new System.Windows.Forms.NumericUpDown();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDirenc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDirenc2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.Direnç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2.Direnç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ohm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ohm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bağlantı Tipi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sonuç Birimi";
            // 
            // cmbBaglanti
            // 
            this.cmbBaglanti.FormattingEnabled = true;
            this.cmbBaglanti.Items.AddRange(new object[] {
            "Seri Bağlantı",
            "Paralel Bağlantı"});
            this.cmbBaglanti.Location = new System.Drawing.Point(185, 179);
            this.cmbBaglanti.Name = "cmbBaglanti";
            this.cmbBaglanti.Size = new System.Drawing.Size(121, 21);
            this.cmbBaglanti.TabIndex = 6;
            this.cmbBaglanti.SelectedIndexChanged += new System.EventHandler(this.cmbBaglanti_SelectedIndexChanged);
            // 
            // cmbBirim
            // 
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Items.AddRange(new object[] {
            "Ohm",
            "KiloOhm",
            "MegaOhm"});
            this.cmbBirim.Location = new System.Drawing.Point(185, 220);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(121, 21);
            this.cmbBirim.TabIndex = 7;
            this.cmbBirim.SelectedIndexChanged += new System.EventHandler(this.cmbBirim_SelectedIndexChanged);
            // 
            // nudDirenc1
            // 
            this.nudDirenc1.DecimalPlaces = 1;
            this.nudDirenc1.Location = new System.Drawing.Point(185, 78);
            this.nudDirenc1.Name = "nudDirenc1";
            this.nudDirenc1.Size = new System.Drawing.Size(120, 20);
            this.nudDirenc1.TabIndex = 8;
            this.nudDirenc1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nudDirenc2
            // 
            this.nudDirenc2.DecimalPlaces = 1;
            this.nudDirenc2.Location = new System.Drawing.Point(185, 110);
            this.nudDirenc2.Name = "nudDirenc2";
            this.nudDirenc2.Size = new System.Drawing.Size(120, 20);
            this.nudDirenc2.TabIndex = 9;
            this.nudDirenc2.ValueChanged += new System.EventHandler(this.nudDirenc2_ValueChanged);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(197, 273);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 10;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(194, 319);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(22, 13);
            this.lblSonuc.TabIndex = 11;
            this.lblSonuc.Text = "0.0";
            this.lblSonuc.Click += new System.EventHandler(this.lblSonuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 438);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.nudDirenc2);
            this.Controls.Add(this.nudDirenc1);
            this.Controls.Add(this.cmbBirim);
            this.Controls.Add(this.cmbBaglanti);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDirenc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDirenc2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBaglanti;
        private System.Windows.Forms.ComboBox cmbBirim;
        private System.Windows.Forms.NumericUpDown nudDirenc1;
        private System.Windows.Forms.NumericUpDown nudDirenc2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblSonuc;
    }
}

