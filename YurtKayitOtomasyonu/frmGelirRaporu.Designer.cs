namespace YurtKayitOtomasyonu
{
    partial class frmGelirRaporu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGelirRaporu));
            this.label1 = new System.Windows.Forms.Label();
            this.lblKasadakiPara = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSecilenAyParaMiktari = new System.Windows.Forms.Label();
            this.comboAySecimi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(344, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kasadaki Toplam Para :";
            // 
            // lblKasadakiPara
            // 
            this.lblKasadakiPara.AutoSize = true;
            this.lblKasadakiPara.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasadakiPara.Location = new System.Drawing.Point(516, 32);
            this.lblKasadakiPara.Name = "lblKasadakiPara";
            this.lblKasadakiPara.Size = new System.Drawing.Size(17, 20);
            this.lblKasadakiPara.TabIndex = 0;
            this.lblKasadakiPara.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(423, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Secilen Ay :";
            // 
            // lblSecilenAyParaMiktari
            // 
            this.lblSecilenAyParaMiktari.AutoSize = true;
            this.lblSecilenAyParaMiktari.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecilenAyParaMiktari.Location = new System.Drawing.Point(516, 68);
            this.lblSecilenAyParaMiktari.Name = "lblSecilenAyParaMiktari";
            this.lblSecilenAyParaMiktari.Size = new System.Drawing.Size(17, 20);
            this.lblSecilenAyParaMiktari.TabIndex = 0;
            this.lblSecilenAyParaMiktari.Text = "0";
            // 
            // comboAySecimi
            // 
            this.comboAySecimi.FormattingEnabled = true;
            this.comboAySecimi.Location = new System.Drawing.Point(50, 67);
            this.comboAySecimi.Name = "comboAySecimi";
            this.comboAySecimi.Size = new System.Drawing.Size(159, 25);
            this.comboAySecimi.TabIndex = 1;
            this.comboAySecimi.SelectedIndexChanged += new System.EventHandler(this.ComboAySecimi_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(66, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ay Secimi Yapın ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboAySecimi);
            this.groupBox2.Controls.Add(this.lblKasadakiPara);
            this.groupBox2.Controls.Add(this.lblSecilenAyParaMiktari);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 122);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gelir Miktarı";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 153);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "AYLIK";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(593, 300);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // frmGelirRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGelirRaporu";
            this.Text = "Gelir Raporları";
            this.Load += new System.EventHandler(this.FrmGelirRaporu_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKasadakiPara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSecilenAyParaMiktari;
        private System.Windows.Forms.ComboBox comboAySecimi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}