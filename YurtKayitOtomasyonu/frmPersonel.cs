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
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }

        veritabaniBaglantisi veritabaniBaglantisi = new veritabaniBaglantisi();

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitOtomasyonuDataSet6.personeller' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personellerTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet6.personeller);

        }
        private void sayfayiTemizle()
        {
            txtPersonelId.Clear();
            txtAdSoyad.Clear();
            txtGorevYeri.Clear();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand personelEkleKomutu = new SqlCommand("insert into personeller (personelAdSoyad,personelBirim) values ('" + txtAdSoyad.Text + "','" + txtGorevYeri.Text + "')", veritabaniBaglantisi.baglan());
                personelEkleKomutu.ExecuteNonQuery();
                veritabaniBaglantisi.baglan().Close();
                MessageBox.Show("Personel Başarı İle Eklendi", "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.personellerTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet6.personeller);
                sayfayiTemizle();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu Yeniden Deneyin", "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK, MessageBoxIcon.Error);
                veritabaniBaglantisi.baglan().Close();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand personelSilKomutu = new SqlCommand("delete from personeller where personelId='" + txtPersonelId.Text + "'", veritabaniBaglantisi.baglan());
                personelSilKomutu.ExecuteNonQuery();
                veritabaniBaglantisi.baglan().Close();
                MessageBox.Show("Silme İşlemi Başarı İle Gerçekleşti", "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.personellerTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet6.personeller);
                sayfayiTemizle();
            }
            catch (Exception)
            {
                veritabaniBaglantisi.baglan().Close();
                MessageBox.Show("Hata,Silme İşlemi Gerçekleşmedi", "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            sayfayiTemizle();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili;
            secili = dataGridView1.SelectedCells[0].RowIndex;
            string id, personelAdSoyad, gorevYeri;
            id = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            personelAdSoyad = dataGridView1.Rows[secili].Cells[1].Value.ToString();
            gorevYeri = dataGridView1.Rows[secili].Cells[2].Value.ToString();

            txtPersonelId.Text = id;
            txtAdSoyad.Text = personelAdSoyad;
            txtGorevYeri.Text = gorevYeri;

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand personelBilgiDuzenlemeKomutu = new SqlCommand("update personeller set personelAdSoyad='" + txtAdSoyad.Text + "',personelBirim='" + txtGorevYeri.Text + "' where personelId='" +txtPersonelId.Text+"' ", veritabaniBaglantisi.baglan());
                personelBilgiDuzenlemeKomutu.ExecuteNonQuery();
                veritabaniBaglantisi.baglan().Close();
                MessageBox.Show("Güncelleme İşlemi Başarı İle Gerçekleşti", "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.personellerTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet6.personeller);
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
