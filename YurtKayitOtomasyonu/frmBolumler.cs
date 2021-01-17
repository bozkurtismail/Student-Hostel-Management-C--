using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtKayitOtomasyonu
{
    public partial class frmBolumler : Form
    {
        public frmBolumler()
        {
            InitializeComponent();
        }
        veritabaniBaglantisi veritabaniBaglantisi = new veritabaniBaglantisi();

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitOtomasyonuDataSet.bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet.bolumler);

        }
        private void sayfayiTemizle()
        {
            txtBolumId.Clear();
            txtBolumAd.Clear();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand eklemeKomutu = new SqlCommand("insert into bolumler (bolumAd) values ('" + txtBolumAd.Text + "') ", veritabaniBaglantisi.baglan());
                eklemeKomutu.ExecuteNonQuery();
                veritabaniBaglantisi.baglan().Close();
                MessageBox.Show("Bölüm Başarı İle Eklendi", "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.bolumlerTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet.bolumler);
                sayfayiTemizle();
            }
            catch
            {
                MessageBox.Show("Hata Oluştu Yeniden Deneyin", "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK, MessageBoxIcon.Error);
                veritabaniBaglantisi.baglan().Close();
            }            

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand silmeKomutu = new SqlCommand("delete from bolumler where bolumId='" + txtBolumId.Text + "' ", veritabaniBaglantisi.baglan());
                silmeKomutu.ExecuteNonQuery();
                veritabaniBaglantisi.baglan().Close();
                MessageBox.Show("Silme İşlemi Başarı İle Gerçekleşti", "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.bolumlerTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet.bolumler);
                sayfayiTemizle();
            }
            catch (Exception)
            {
                veritabaniBaglantisi.baglan().Close();
                MessageBox.Show("Hata,Silme İşlemi Gerçekleşmedi", "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        } 
        
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBolumId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtBolumAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            sayfayiTemizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand guncellemeKomutu = new SqlCommand("update bolumler set bolumAd='" + txtBolumAd.Text + "' where bolumId='" + txtBolumId.Text + "'", veritabaniBaglantisi.baglan());
                guncellemeKomutu.ExecuteNonQuery();
                veritabaniBaglantisi.baglan().Close();
                MessageBox.Show("Güncelleme İşlemi Başarı İle Gerçekleşti", "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.bolumlerTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet.bolumler);
                sayfayiTemizle();
            }
            catch (Exception)
            {
                veritabaniBaglantisi.baglan().Close();
                MessageBox.Show("Hata,Güncelleme İşlemi Gerçekleşmedi", "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
