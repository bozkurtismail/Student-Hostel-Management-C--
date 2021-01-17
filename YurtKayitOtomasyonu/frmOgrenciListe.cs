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
    public partial class frmOgrenciListe : Form
    {
        public frmOgrenciListe()
        {
            InitializeComponent();
        }

        private void FrmOgrenciListe_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitOtomasyonuDataSet3.ogrenciler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrencilerTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet3.ogrenciler);

        }
        int secili;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secili = dataGridView1.SelectedCells[0].RowIndex;
            frmOgrenciBilgiDuzenleme frmOgrenciBilgiDuzenleme = new frmOgrenciBilgiDuzenleme();

            frmOgrenciBilgiDuzenleme.ogrenciId = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            frmOgrenciBilgiDuzenleme.TcNo= dataGridView1.Rows[secili].Cells[1].Value.ToString();
            frmOgrenciBilgiDuzenleme.ad= dataGridView1.Rows[secili].Cells[2].Value.ToString();
            frmOgrenciBilgiDuzenleme.soyad= dataGridView1.Rows[secili].Cells[3].Value.ToString();
            frmOgrenciBilgiDuzenleme.telefon= dataGridView1.Rows[secili].Cells[4].Value.ToString();
            frmOgrenciBilgiDuzenleme.dogumTarihi= dataGridView1.Rows[secili].Cells[5].Value.ToString();
            frmOgrenciBilgiDuzenleme.bolum= dataGridView1.Rows[secili].Cells[6].Value.ToString();
            frmOgrenciBilgiDuzenleme.mail= dataGridView1.Rows[secili].Cells[7].Value.ToString();
            frmOgrenciBilgiDuzenleme.odaNo= dataGridView1.Rows[secili].Cells[8].Value.ToString();
            frmOgrenciBilgiDuzenleme.veliAdSoyad= dataGridView1.Rows[secili].Cells[9].Value.ToString();
            frmOgrenciBilgiDuzenleme.veliTelefon= dataGridView1.Rows[secili].Cells[10].Value.ToString();
            frmOgrenciBilgiDuzenleme.adres= dataGridView1.Rows[secili].Cells[11].Value.ToString();
            frmOgrenciBilgiDuzenleme.Show();
            this.Hide();

            
        }
    }
}
