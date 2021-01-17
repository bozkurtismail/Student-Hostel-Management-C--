namespace YurtKayitOtomasyonu
{
    partial class frmOgrenciKayit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgrenciKayit));
            this.lblTc = new System.Windows.Forms.Label();
            this.maskedTcNo = new System.Windows.Forms.MaskedTextBox();
            this.lblVeliAdSoyad = new System.Windows.Forms.Label();
            this.lblOgrenciSoyad = new System.Windows.Forms.Label();
            this.txtVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.lblOgrenciTelefon = new System.Windows.Forms.Label();
            this.maskedOgrenciTelefon = new System.Windows.Forms.MaskedTextBox();
            this.lblOgrenciDogumTarihi = new System.Windows.Forms.Label();
            this.maskedDogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.lblOgrenciBolum = new System.Windows.Forms.Label();
            this.comboBolum = new System.Windows.Forms.ComboBox();
            this.lblOgrenciMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblOgrenciOda = new System.Windows.Forms.Label();
            this.comboOda = new System.Windows.Forms.ComboBox();
            this.lblOgrenciAd = new System.Windows.Forms.Label();
            this.txtOgrenciAd = new System.Windows.Forms.TextBox();
            this.maskedVeliTelefon = new System.Windows.Forms.MaskedTextBox();
            this.lblVeliTelefon = new System.Windows.Forms.Label();
            this.lblVeliAdres = new System.Windows.Forms.Label();
            this.richtxtAdres = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblOgrenciId = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.Location = new System.Drawing.Point(94, 23);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(32, 14);
            this.lblTc.TabIndex = 13;
            this.lblTc.Text = "TC :";
            // 
            // maskedTcNo
            // 
            this.maskedTcNo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.maskedTcNo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTcNo.Location = new System.Drawing.Point(147, 20);
            this.maskedTcNo.Mask = "00000000000";
            this.maskedTcNo.Name = "maskedTcNo";
            this.maskedTcNo.Size = new System.Drawing.Size(198, 22);
            this.maskedTcNo.TabIndex = 0;
            this.maskedTcNo.ValidatingType = typeof(int);
            this.maskedTcNo.TextChanged += new System.EventHandler(this.maskedTcNo_TextChanged);
            this.maskedTcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTcNo_KeyPress);
            // 
            // lblVeliAdSoyad
            // 
            this.lblVeliAdSoyad.AutoSize = true;
            this.lblVeliAdSoyad.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVeliAdSoyad.Location = new System.Drawing.Point(26, 35);
            this.lblVeliAdSoyad.Name = "lblVeliAdSoyad";
            this.lblVeliAdSoyad.Size = new System.Drawing.Size(100, 14);
            this.lblVeliAdSoyad.TabIndex = 22;
            this.lblVeliAdSoyad.Text = "Veli Ad Soyad :";
            // 
            // lblOgrenciSoyad
            // 
            this.lblOgrenciSoyad.AutoSize = true;
            this.lblOgrenciSoyad.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenciSoyad.Location = new System.Drawing.Point(19, 96);
            this.lblOgrenciSoyad.Name = "lblOgrenciSoyad";
            this.lblOgrenciSoyad.Size = new System.Drawing.Size(107, 14);
            this.lblOgrenciSoyad.TabIndex = 15;
            this.lblOgrenciSoyad.Text = "Öğrenci Soyad :";
            // 
            // txtVeliAdSoyad
            // 
            this.txtVeliAdSoyad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtVeliAdSoyad.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVeliAdSoyad.Location = new System.Drawing.Point(147, 32);
            this.txtVeliAdSoyad.Name = "txtVeliAdSoyad";
            this.txtVeliAdSoyad.Size = new System.Drawing.Size(200, 22);
            this.txtVeliAdSoyad.TabIndex = 9;
            this.txtVeliAdSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVeliAdSoyad_KeyPress);
            // 
            // txtOgrenciSoyad
            // 
            this.txtOgrenciSoyad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtOgrenciSoyad.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciSoyad.Location = new System.Drawing.Point(147, 93);
            this.txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            this.txtOgrenciSoyad.Size = new System.Drawing.Size(199, 22);
            this.txtOgrenciSoyad.TabIndex = 3;
            this.txtOgrenciSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOgrenciSoyad_KeyPress);
            // 
            // lblOgrenciTelefon
            // 
            this.lblOgrenciTelefon.AutoSize = true;
            this.lblOgrenciTelefon.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenciTelefon.Location = new System.Drawing.Point(65, 131);
            this.lblOgrenciTelefon.Name = "lblOgrenciTelefon";
            this.lblOgrenciTelefon.Size = new System.Drawing.Size(61, 14);
            this.lblOgrenciTelefon.TabIndex = 16;
            this.lblOgrenciTelefon.Text = "Telefon :";
            // 
            // maskedOgrenciTelefon
            // 
            this.maskedOgrenciTelefon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.maskedOgrenciTelefon.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedOgrenciTelefon.Location = new System.Drawing.Point(147, 128);
            this.maskedOgrenciTelefon.Mask = "(999) 000-0000";
            this.maskedOgrenciTelefon.Name = "maskedOgrenciTelefon";
            this.maskedOgrenciTelefon.Size = new System.Drawing.Size(199, 22);
            this.maskedOgrenciTelefon.TabIndex = 4;
            // 
            // lblOgrenciDogumTarihi
            // 
            this.lblOgrenciDogumTarihi.AutoSize = true;
            this.lblOgrenciDogumTarihi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenciDogumTarihi.Location = new System.Drawing.Point(29, 169);
            this.lblOgrenciDogumTarihi.Name = "lblOgrenciDogumTarihi";
            this.lblOgrenciDogumTarihi.Size = new System.Drawing.Size(97, 14);
            this.lblOgrenciDogumTarihi.TabIndex = 17;
            this.lblOgrenciDogumTarihi.Text = "Doğum Tarihi :";
            // 
            // maskedDogumTarihi
            // 
            this.maskedDogumTarihi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.maskedDogumTarihi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedDogumTarihi.Location = new System.Drawing.Point(147, 166);
            this.maskedDogumTarihi.Mask = "00/00/0000";
            this.maskedDogumTarihi.Name = "maskedDogumTarihi";
            this.maskedDogumTarihi.Size = new System.Drawing.Size(199, 22);
            this.maskedDogumTarihi.TabIndex = 5;
            this.maskedDogumTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // lblOgrenciBolum
            // 
            this.lblOgrenciBolum.AutoSize = true;
            this.lblOgrenciBolum.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenciBolum.Location = new System.Drawing.Point(20, 208);
            this.lblOgrenciBolum.Name = "lblOgrenciBolum";
            this.lblOgrenciBolum.Size = new System.Drawing.Size(106, 14);
            this.lblOgrenciBolum.TabIndex = 18;
            this.lblOgrenciBolum.Text = "Öğrenci Bölüm :";
            // 
            // comboBolum
            // 
            this.comboBolum.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBolum.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBolum.FormattingEnabled = true;
            this.comboBolum.Location = new System.Drawing.Point(147, 205);
            this.comboBolum.Name = "comboBolum";
            this.comboBolum.Size = new System.Drawing.Size(200, 22);
            this.comboBolum.TabIndex = 6;
            // 
            // lblOgrenciMail
            // 
            this.lblOgrenciMail.AutoSize = true;
            this.lblOgrenciMail.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenciMail.Location = new System.Drawing.Point(86, 246);
            this.lblOgrenciMail.Name = "lblOgrenciMail";
            this.lblOgrenciMail.Size = new System.Drawing.Size(40, 14);
            this.lblOgrenciMail.TabIndex = 19;
            this.lblOgrenciMail.Text = "Mail :";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtMail.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(147, 243);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(200, 22);
            this.txtMail.TabIndex = 7;
            // 
            // lblOgrenciOda
            // 
            this.lblOgrenciOda.AutoSize = true;
            this.lblOgrenciOda.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenciOda.Location = new System.Drawing.Point(63, 283);
            this.lblOgrenciOda.Name = "lblOgrenciOda";
            this.lblOgrenciOda.Size = new System.Drawing.Size(63, 14);
            this.lblOgrenciOda.TabIndex = 20;
            this.lblOgrenciOda.Text = "Oda No :";
            // 
            // comboOda
            // 
            this.comboOda.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboOda.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboOda.FormattingEnabled = true;
            this.comboOda.Location = new System.Drawing.Point(147, 280);
            this.comboOda.Name = "comboOda";
            this.comboOda.Size = new System.Drawing.Size(200, 22);
            this.comboOda.TabIndex = 8;
            // 
            // lblOgrenciAd
            // 
            this.lblOgrenciAd.AutoSize = true;
            this.lblOgrenciAd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenciAd.Location = new System.Drawing.Point(42, 61);
            this.lblOgrenciAd.Name = "lblOgrenciAd";
            this.lblOgrenciAd.Size = new System.Drawing.Size(84, 14);
            this.lblOgrenciAd.TabIndex = 14;
            this.lblOgrenciAd.Text = "Öğrenci Ad :";
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtOgrenciAd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciAd.Location = new System.Drawing.Point(147, 58);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(200, 22);
            this.txtOgrenciAd.TabIndex = 2;
            this.txtOgrenciAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOgrenciAd_KeyPress);
            // 
            // maskedVeliTelefon
            // 
            this.maskedVeliTelefon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.maskedVeliTelefon.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedVeliTelefon.Location = new System.Drawing.Point(147, 65);
            this.maskedVeliTelefon.Mask = "(999) 000-0000";
            this.maskedVeliTelefon.Name = "maskedVeliTelefon";
            this.maskedVeliTelefon.Size = new System.Drawing.Size(199, 22);
            this.maskedVeliTelefon.TabIndex = 10;
            // 
            // lblVeliTelefon
            // 
            this.lblVeliTelefon.AutoSize = true;
            this.lblVeliTelefon.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVeliTelefon.Location = new System.Drawing.Point(40, 68);
            this.lblVeliTelefon.Name = "lblVeliTelefon";
            this.lblVeliTelefon.Size = new System.Drawing.Size(86, 14);
            this.lblVeliTelefon.TabIndex = 23;
            this.lblVeliTelefon.Text = "Veli Telefon :";
            // 
            // lblVeliAdres
            // 
            this.lblVeliAdres.AutoSize = true;
            this.lblVeliAdres.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVeliAdres.Location = new System.Drawing.Point(62, 99);
            this.lblVeliAdres.Name = "lblVeliAdres";
            this.lblVeliAdres.Size = new System.Drawing.Size(52, 14);
            this.lblVeliAdres.TabIndex = 24;
            this.lblVeliAdres.Text = "Adres :";
            // 
            // richtxtAdres
            // 
            this.richtxtAdres.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.richtxtAdres.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richtxtAdres.Location = new System.Drawing.Point(147, 99);
            this.richtxtAdres.Name = "richtxtAdres";
            this.richtxtAdres.Size = new System.Drawing.Size(200, 96);
            this.richtxtAdres.TabIndex = 11;
            this.richtxtAdres.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblOgrenciOda);
            this.groupBox1.Controls.Add(this.lblTc);
            this.groupBox1.Controls.Add(this.comboOda);
            this.groupBox1.Controls.Add(this.maskedTcNo);
            this.groupBox1.Controls.Add(this.comboBolum);
            this.groupBox1.Controls.Add(this.maskedOgrenciTelefon);
            this.groupBox1.Controls.Add(this.txtOgrenciSoyad);
            this.groupBox1.Controls.Add(this.maskedDogumTarihi);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.lblOgrenciAd);
            this.groupBox1.Controls.Add(this.txtOgrenciAd);
            this.groupBox1.Controls.Add(this.lblOgrenciSoyad);
            this.groupBox1.Controls.Add(this.lblOgrenciTelefon);
            this.groupBox1.Controls.Add(this.lblOgrenciMail);
            this.groupBox1.Controls.Add(this.lblOgrenciDogumTarihi);
            this.groupBox1.Controls.Add(this.lblOgrenciBolum);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 311);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(382, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.lblVeliAdSoyad);
            this.groupBox2.Controls.Add(this.maskedVeliTelefon);
            this.groupBox2.Controls.Add(this.richtxtAdres);
            this.groupBox2.Controls.Add(this.lblVeliTelefon);
            this.groupBox2.Controls.Add(this.txtVeliAdSoyad);
            this.groupBox2.Controls.Add(this.lblVeliAdres);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 212);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Veli Bilgileri";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::YurtKayitOtomasyonu.Properties.Resources.kam;
            this.pictureBox2.Location = new System.Drawing.Point(427, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(188, 184);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Image = global::YurtKayitOtomasyonu.Properties.Resources.add_icon;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(288, 545);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(131, 65);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // lblOgrenciId
            // 
            this.lblOgrenciId.AutoSize = true;
            this.lblOgrenciId.Location = new System.Drawing.Point(31, 545);
            this.lblOgrenciId.Name = "lblOgrenciId";
            this.lblOgrenciId.Size = new System.Drawing.Size(61, 13);
            this.lblOgrenciId.TabIndex = 11;
            this.lblOgrenciId.Text = "ogrenciId";
            this.lblOgrenciId.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmOgrenciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(698, 631);
            this.Controls.Add(this.lblOgrenciId);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOgrenciKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Kayıt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.MaskedTextBox maskedTcNo;
        private System.Windows.Forms.Label lblVeliAdSoyad;
        private System.Windows.Forms.Label lblOgrenciSoyad;
        private System.Windows.Forms.TextBox txtVeliAdSoyad;
        private System.Windows.Forms.TextBox txtOgrenciSoyad;
        private System.Windows.Forms.Label lblOgrenciTelefon;
        private System.Windows.Forms.MaskedTextBox maskedOgrenciTelefon;
        private System.Windows.Forms.Label lblOgrenciDogumTarihi;
        private System.Windows.Forms.MaskedTextBox maskedDogumTarihi;
        private System.Windows.Forms.Label lblOgrenciBolum;
        private System.Windows.Forms.ComboBox comboBolum;
        private System.Windows.Forms.Label lblOgrenciMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblOgrenciOda;
        private System.Windows.Forms.ComboBox comboOda;
        private System.Windows.Forms.Label lblOgrenciAd;
        private System.Windows.Forms.TextBox txtOgrenciAd;
        private System.Windows.Forms.MaskedTextBox maskedVeliTelefon;
        private System.Windows.Forms.Label lblVeliTelefon;
        private System.Windows.Forms.Label lblVeliAdres;
        private System.Windows.Forms.RichTextBox richtxtAdres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblOgrenciId;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

