namespace YurtKayitOtomasyonu
{
    partial class frmOgrenciListe
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgrenciListe));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciTcNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciDogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciBolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciOdaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciVeliAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciVeliTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrencilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtKayitOtomasyonuDataSet3 = new YurtKayitOtomasyonu.YurtKayitOtomasyonuDataSet3();
            this.ogrencilerTableAdapter = new YurtKayitOtomasyonu.YurtKayitOtomasyonuDataSet3TableAdapters.ogrencilerTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitOtomasyonuDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciIdDataGridViewTextBoxColumn,
            this.ogrenciTcNoDataGridViewTextBoxColumn,
            this.ogrenciAdDataGridViewTextBoxColumn,
            this.ogrenciSoyadDataGridViewTextBoxColumn,
            this.ogrenciTelefonDataGridViewTextBoxColumn,
            this.ogrenciDogumTarihiDataGridViewTextBoxColumn,
            this.ogrenciBolumDataGridViewTextBoxColumn,
            this.ogrenciMailDataGridViewTextBoxColumn,
            this.ogrenciOdaNoDataGridViewTextBoxColumn,
            this.ogrenciVeliAdSoyadDataGridViewTextBoxColumn,
            this.ogrenciVeliTelefonDataGridViewTextBoxColumn,
            this.ogrenciAdresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrencilerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1201, 394);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // ogrenciIdDataGridViewTextBoxColumn
            // 
            this.ogrenciIdDataGridViewTextBoxColumn.DataPropertyName = "ogrenciId";
            this.ogrenciIdDataGridViewTextBoxColumn.HeaderText = "ÖĞRENCİ ID";
            this.ogrenciIdDataGridViewTextBoxColumn.Name = "ogrenciIdDataGridViewTextBoxColumn";
            this.ogrenciIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogrenciIdDataGridViewTextBoxColumn.Width = 70;
            // 
            // ogrenciTcNoDataGridViewTextBoxColumn
            // 
            this.ogrenciTcNoDataGridViewTextBoxColumn.DataPropertyName = "ogrenciTcNo";
            this.ogrenciTcNoDataGridViewTextBoxColumn.HeaderText = "TC KİMLİK  NO";
            this.ogrenciTcNoDataGridViewTextBoxColumn.Name = "ogrenciTcNoDataGridViewTextBoxColumn";
            this.ogrenciTcNoDataGridViewTextBoxColumn.Width = 80;
            // 
            // ogrenciAdDataGridViewTextBoxColumn
            // 
            this.ogrenciAdDataGridViewTextBoxColumn.DataPropertyName = "ogrenciAd";
            this.ogrenciAdDataGridViewTextBoxColumn.HeaderText = "AD";
            this.ogrenciAdDataGridViewTextBoxColumn.Name = "ogrenciAdDataGridViewTextBoxColumn";
            this.ogrenciAdDataGridViewTextBoxColumn.Width = 120;
            // 
            // ogrenciSoyadDataGridViewTextBoxColumn
            // 
            this.ogrenciSoyadDataGridViewTextBoxColumn.DataPropertyName = "ogrenciSoyad";
            this.ogrenciSoyadDataGridViewTextBoxColumn.HeaderText = "SOYAD";
            this.ogrenciSoyadDataGridViewTextBoxColumn.Name = "ogrenciSoyadDataGridViewTextBoxColumn";
            this.ogrenciSoyadDataGridViewTextBoxColumn.Width = 120;
            // 
            // ogrenciTelefonDataGridViewTextBoxColumn
            // 
            this.ogrenciTelefonDataGridViewTextBoxColumn.DataPropertyName = "ogrenciTelefon";
            this.ogrenciTelefonDataGridViewTextBoxColumn.HeaderText = "TELEFON";
            this.ogrenciTelefonDataGridViewTextBoxColumn.Name = "ogrenciTelefonDataGridViewTextBoxColumn";
            // 
            // ogrenciDogumTarihiDataGridViewTextBoxColumn
            // 
            this.ogrenciDogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "ogrenciDogumTarihi";
            this.ogrenciDogumTarihiDataGridViewTextBoxColumn.HeaderText = "DOGUM TARİHİ";
            this.ogrenciDogumTarihiDataGridViewTextBoxColumn.Name = "ogrenciDogumTarihiDataGridViewTextBoxColumn";
            this.ogrenciDogumTarihiDataGridViewTextBoxColumn.Width = 70;
            // 
            // ogrenciBolumDataGridViewTextBoxColumn
            // 
            this.ogrenciBolumDataGridViewTextBoxColumn.DataPropertyName = "ogrenciBolum";
            this.ogrenciBolumDataGridViewTextBoxColumn.HeaderText = "BÖLÜM";
            this.ogrenciBolumDataGridViewTextBoxColumn.Name = "ogrenciBolumDataGridViewTextBoxColumn";
            this.ogrenciBolumDataGridViewTextBoxColumn.Width = 130;
            // 
            // ogrenciMailDataGridViewTextBoxColumn
            // 
            this.ogrenciMailDataGridViewTextBoxColumn.DataPropertyName = "ogrenciMail";
            this.ogrenciMailDataGridViewTextBoxColumn.HeaderText = "MAİL";
            this.ogrenciMailDataGridViewTextBoxColumn.Name = "ogrenciMailDataGridViewTextBoxColumn";
            this.ogrenciMailDataGridViewTextBoxColumn.Width = 110;
            // 
            // ogrenciOdaNoDataGridViewTextBoxColumn
            // 
            this.ogrenciOdaNoDataGridViewTextBoxColumn.DataPropertyName = "ogrenciOdaNo";
            this.ogrenciOdaNoDataGridViewTextBoxColumn.HeaderText = "ODA NO";
            this.ogrenciOdaNoDataGridViewTextBoxColumn.Name = "ogrenciOdaNoDataGridViewTextBoxColumn";
            this.ogrenciOdaNoDataGridViewTextBoxColumn.Width = 45;
            // 
            // ogrenciVeliAdSoyadDataGridViewTextBoxColumn
            // 
            this.ogrenciVeliAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "ogrenciVeliAdSoyad";
            this.ogrenciVeliAdSoyadDataGridViewTextBoxColumn.HeaderText = "VELİSİ";
            this.ogrenciVeliAdSoyadDataGridViewTextBoxColumn.Name = "ogrenciVeliAdSoyadDataGridViewTextBoxColumn";
            this.ogrenciVeliAdSoyadDataGridViewTextBoxColumn.Width = 130;
            // 
            // ogrenciVeliTelefonDataGridViewTextBoxColumn
            // 
            this.ogrenciVeliTelefonDataGridViewTextBoxColumn.DataPropertyName = "ogrenciVeliTelefon";
            this.ogrenciVeliTelefonDataGridViewTextBoxColumn.HeaderText = "VELİ TELEFON";
            this.ogrenciVeliTelefonDataGridViewTextBoxColumn.Name = "ogrenciVeliTelefonDataGridViewTextBoxColumn";
            this.ogrenciVeliTelefonDataGridViewTextBoxColumn.Width = 85;
            // 
            // ogrenciAdresDataGridViewTextBoxColumn
            // 
            this.ogrenciAdresDataGridViewTextBoxColumn.DataPropertyName = "ogrenciAdres";
            this.ogrenciAdresDataGridViewTextBoxColumn.HeaderText = "ADRES";
            this.ogrenciAdresDataGridViewTextBoxColumn.Name = "ogrenciAdresDataGridViewTextBoxColumn";
            this.ogrenciAdresDataGridViewTextBoxColumn.Width = 135;
            // 
            // ogrencilerBindingSource
            // 
            this.ogrencilerBindingSource.DataMember = "ogrenciler";
            this.ogrencilerBindingSource.DataSource = this.yurtKayitOtomasyonuDataSet3;
            // 
            // yurtKayitOtomasyonuDataSet3
            // 
            this.yurtKayitOtomasyonuDataSet3.DataSetName = "YurtKayitOtomasyonuDataSet3";
            this.yurtKayitOtomasyonuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrencilerTableAdapter
            // 
            this.ogrencilerTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(412, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Güncelleme İşlemi İçin Alttan Veriyi Seçiniz";
            // 
            // frmOgrenciListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1201, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOgrenciListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Listesi";
            this.Load += new System.EventHandler(this.FrmOgrenciListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitOtomasyonuDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtKayitOtomasyonuDataSet3 yurtKayitOtomasyonuDataSet3;
        private System.Windows.Forms.BindingSource ogrencilerBindingSource;
        private YurtKayitOtomasyonuDataSet3TableAdapters.ogrencilerTableAdapter ogrencilerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciTcNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciDogumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciBolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciOdaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciVeliAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciVeliTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
    }
}