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
    public partial class frmOdemeler : Form
    {
        public frmOdemeler()
        {
            InitializeComponent();
        }
        veritabaniBaglantisi veritabaniBaglantisi = new veritabaniBaglantisi();

        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitOtomasyonuDataSet2.borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet2.borclar);

        }
        private void sayfayiTemizle()
        {
            txtOgrenciId.Clear();
            txtOgrenciAd.Clear();
            txtOgrenciSoyad.Clear();
            txtOdenenMiktar.Clear();
            txtKalanBorc.Clear();
            txtOdenenAy.Clear();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili;
            string ogrenciId, ogrenciAd, ogrenciSoyad, kalanBorc;

            secili = dataGridView1.SelectedCells[0].RowIndex;
            ogrenciId = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            ogrenciAd= dataGridView1.Rows[secili].Cells[1].Value.ToString();
            ogrenciSoyad= dataGridView1.Rows[secili].Cells[2].Value.ToString();
            kalanBorc= dataGridView1.Rows[secili].Cells[3].Value.ToString();

            txtOgrenciId.Text = ogrenciId;
            txtOgrenciAd.Text = ogrenciAd;
            txtOgrenciSoyad.Text = ogrenciSoyad;
            txtKalanBorc.Text = kalanBorc;
        }

        private void BtnOdemeYap_Click(object sender, EventArgs e)
        {
            int odenenMiktar, kalanBorc, yeniBorc;
            odenenMiktar = Convert.ToInt16(txtOdenenMiktar.Text);
            kalanBorc = Convert.ToInt16(txtKalanBorc.Text);
            yeniBorc = kalanBorc - odenenMiktar;
            txtKalanBorc.Text = yeniBorc.ToString();

            SqlCommand guncellemeKomutu = new SqlCommand("update borclar set ogrenciKalanBorc='"+txtKalanBorc.Text+"' where ogrenciId='"+txtOgrenciId.Text+"'",veritabaniBaglantisi.baglan());
            guncellemeKomutu.ExecuteNonQuery();
            veritabaniBaglantisi.baglan().Close();
            MessageBox.Show("Ücret Ödemesi Başarı İle Gerçekleştirildi", "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.borclarTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet2.borclar);
           

            SqlCommand kasayaEkle = new SqlCommand("insert into kasa (odemeAyi,odemeMiktari) values ('"+txtOdenenAy.Text+"','"+txtOdenenMiktar.Text+"')",veritabaniBaglantisi.baglan());
            kasayaEkle.ExecuteNonQuery();
            veritabaniBaglantisi.baglan().Close();
            sayfayiTemizle();
        }
    }
}
