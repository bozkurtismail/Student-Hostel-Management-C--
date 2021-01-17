using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitOtomasyonu
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitOtomasyonuDataSet1.ogrenciler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrencilerTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet1.ogrenciler);
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void HesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void PaintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");
        }

        private void Radyo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://37.247.98.8/stream/166/";
        }

        private void Radyo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = " http://radyo.yayin.com.tr:4012/";
        }

        private void Radyo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = " http://kralpopwmp.radyotvonline.com:80/";
        }

        private void OgrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrenciKayit frmOgrenciKayit = new frmOgrenciKayit();

            frmOgrenciKayit.Show();
        }

        private void ÖğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrenciListe frmOgrenciListe = new frmOgrenciListe();
            frmOgrenciListe.Show();
        }

        private void ÖğrenciDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrenciListe frmOgrenciListe = new frmOgrenciListe();
            frmOgrenciListe.Show();
        }

        private void BölümEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBolumler frmBolumler = new frmBolumler();
            frmBolumler.Show();
        }

        private void BölümDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBolumler frmBolumler = new frmBolumler();
            frmBolumler.Show();
        }

        private void ÖdemeDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOdemeler frmOdemeler = new frmOdemeler();
            frmOdemeler.Show();
        }

        private void GiderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiderler frmGiderler = new frmGiderler();
            frmGiderler.Show();
        }

        private void GiderListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiderListesi frmGiderListesi = new frmGiderListesi();
            frmGiderListesi.Show();
        }

        private void GelirRaporlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGelirRaporu frmGelirRaporu = new frmGelirRaporu();
            frmGelirRaporu.Show();
        }

        private void ŞifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullaniciBilgiDuzenleme frmKullaniciBilgiDuzenleme = new frmKullaniciBilgiDuzenleme();
            frmKullaniciBilgiDuzenleme.Show();
        }

        private void PersonelDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonel frmPersonel = new frmPersonel();
            frmPersonel.Show();
        }

        private void NotEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNot frmNot = new frmNot();
            frmNot.Show();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu program İsmail BOZKURT tarafından yapılmıştır", "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
