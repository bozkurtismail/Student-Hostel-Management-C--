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
//System.Text.RegularExpressions  (Regex) kütüphanesinin tanımlanması
using System.Text.RegularExpressions;

namespace YurtKayitOtomasyonu
{
    public partial class frmKullaniciBilgiDuzenleme : Form
    {
        public frmKullaniciBilgiDuzenleme()
        {
            InitializeComponent();
        }
        veritabaniBaglantisi veritabaniBaglantisi = new veritabaniBaglantisi();
        private void sayfayiTemizle()
        {
            txtYoneticiId.Clear();
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
        }

        private void FrmKullaniciBilgiDuzenleme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitOtomasyonuDataSet5.admin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.adminTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet5.admin);
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand kullaniciEkleKomutu = new SqlCommand("insert into admin (yoneticiAd,yoneticiSifre) values ('" + txtKullaniciAdi.Text + "','" + txtSifre.Text + "')", veritabaniBaglantisi.baglan());
                kullaniciEkleKomutu.ExecuteNonQuery();
                veritabaniBaglantisi.baglan().Close();
                MessageBox.Show("Kullanıcı Başarı İle Eklendi", "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.adminTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet5.admin);
                sayfayiTemizle(); 
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu Yeniden Deneyin", "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK, MessageBoxIcon.Error);
                veritabaniBaglantisi.baglan().Close();
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili;
            secili = dataGridView1.SelectedCells[0].RowIndex;
            string id, kullaniciAdi, sifre;
            id= dataGridView1.Rows[secili].Cells[0].Value.ToString();
            kullaniciAdi = dataGridView1.Rows[secili].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secili].Cells[2].Value.ToString();

            txtYoneticiId.Text = id;
            txtKullaniciAdi.Text = kullaniciAdi;
            txtSifre.Text = sifre;
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            sayfayiTemizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand kullaniciSilKomutu = new SqlCommand("delete from admin where yoneticiId='" + txtYoneticiId.Text + "'", veritabaniBaglantisi.baglan());
                kullaniciSilKomutu.ExecuteNonQuery();
                veritabaniBaglantisi.baglan().Close();
                MessageBox.Show("Silme İşlemi Başarı İle Gerçekleşti", "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.adminTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet5.admin);
                sayfayiTemizle();
            }
            catch (Exception)
            {
                veritabaniBaglantisi.baglan().Close();
                MessageBox.Show("Hata,Silme İşlemi Gerçekleşmedi", "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand kullaniciBilgiDuzenlemeKomutu = new SqlCommand("update admin set yoneticiAd='" + txtKullaniciAdi.Text + "',yoneticiSifre='" + txtSifre.Text + "' where yoneticiId='" + txtYoneticiId.Text + "' ", veritabaniBaglantisi.baglan());
                kullaniciBilgiDuzenlemeKomutu.ExecuteNonQuery();
                veritabaniBaglantisi.baglan().Close();
                MessageBox.Show("Güncelleme İşlemi Başarı İle Gerçekleşti", "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.adminTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet5.admin);
                sayfayiTemizle();
            }
            catch (Exception)
            {
                veritabaniBaglantisi.baglan().Close();
                MessageBox.Show("Hata,Güncelleme İşlemi Gerçekleşmedi", "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            string sifre = txtSifre.Text;
            //Regex kütüphanesi  ingilizce karakterleri baz aldığından ,Türkçe karakterlerde  sorun 
            //yaşamamak için  sifre string  ifadesindeki Türkçe karakterleri Ingilizce karakterlere dönüştürmemiz gerekiyor
            string duzeltilmis_sifre = "";
            duzeltilmis_sifre = sifre;           
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('İ', 'I');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('ı', 'i');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('Ç', 'C');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('ç', 'c');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('Ş', 'S');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('ş', 's');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('Ğ', 'G');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('ğ', 'g');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('Ü', 'U');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('ü', 'u');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('Ö', 'O');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('ö', 'o');

            if (sifre != duzeltilmis_sifre)
            {
                sifre = duzeltilmis_sifre;
                txtSifre.Text = sifre;
                MessageBox.Show("Paroladaki Türkçe karakterler ingilizce karakterlere donusturulmustur!");
            }

        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text.Length < 4)
            {
                errorProvider1.SetError(txtKullaniciAdi, "Kullanıcı adı en az 4 karakter olmalı!!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
