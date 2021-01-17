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
    public partial class frmOgrenciBilgiDuzenleme : Form
    {
        public frmOgrenciBilgiDuzenleme()
        {
            InitializeComponent();
        }
        public string ogrenciId, TcNo, ad, soyad, telefon, dogumTarihi,
            bolum, mail, odaNo, veliAdSoyad, veliTelefon, adres;

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand ogrenciSilKomutu = new SqlCommand("delete from ogrenciler where ogrenciId='" +txtOgrenciId.Text + "'",veritabaniBaglantisi.baglan());
                ogrenciSilKomutu.ExecuteNonQuery();
                veritabaniBaglantisi.baglan().Close();
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Silindi","YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                //Oda kontejanını Azaltma
                SqlCommand odaKontejanAzaltmaKomutu = new SqlCommand("update odalar set odaAktif=odaAktif-1 where odaNo='" +comboOda.Text + "'", veritabaniBaglantisi.baglan());
                odaKontejanAzaltmaKomutu.ExecuteNonQuery();
                veritabaniBaglantisi.baglan().Close();
                sayfayiTemizle();
                frmOgrenciListe.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("HATA LÜTFEN YENİDEN EKLEYİN","YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK,MessageBoxIcon.Error);
                veritabaniBaglantisi.baglan().Close();
            }
        }

        private void FrmOgrenciBilgiDuzenleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmOgrenciListe.Show();
        }

        veritabaniBaglantisi veritabaniBaglantisi = new veritabaniBaglantisi();
        frmOgrenciListe frmOgrenciListe = new frmOgrenciListe();

        private void sayfayiTemizle()
        {
            maskedTcNo.Clear();
            txtOgrenciAd.Clear();
            txtOgrenciSoyad.Clear();
            maskedOgrenciTelefon.Clear();
            maskedDogumTarihi.Clear();
            comboBolum.Text = "";
            txtMail.Clear();
            comboOda.Text = "";
            txtVeliAdSoyad.Clear();
            maskedVeliTelefon.Clear();
            richtxtAdres.Clear();
            txtOgrenciId.Clear();
        }

        private void FrmOgrenciBilgiDuzenleme_Load(object sender, EventArgs e)
        {
            txtOgrenciId.Text = ogrenciId;
            maskedTcNo.Text = TcNo;
            txtOgrenciAd.Text = ad;
            txtOgrenciSoyad.Text = soyad;
            maskedOgrenciTelefon.Text = telefon;
            maskedDogumTarihi.Text = dogumTarihi;
            comboBolum.Text = bolum;
            txtMail.Text = mail;
            comboOda.Text = odaNo;
            txtVeliAdSoyad.Text = veliAdSoyad;
            maskedVeliTelefon.Text = veliTelefon;
            richtxtAdres.Text = adres;

            //bölümleri listeleme komutları

            SqlCommand selectSorgusu = new SqlCommand
                ("select bolumAd from bolumler", 
                veritabaniBaglantisi.baglan());
            SqlDataReader verileriOku = selectSorgusu.ExecuteReader();

            while (verileriOku.Read())
            {
                comboBolum.Items.Add(verileriOku[0].ToString());
            }
            veritabaniBaglantisi.baglan().Close();

            //odaları listeleme komutları

            SqlCommand selectSorgusu2 = new SqlCommand
                ("select odaNo from odalar where odaKapasite!=odaAktif",
                veritabaniBaglantisi.baglan());
            SqlDataReader verileriOku2 = selectSorgusu2.ExecuteReader();

            while (verileriOku2.Read())
            {
                comboOda.Items.Add(verileriOku2[0].ToString());
            }
            veritabaniBaglantisi.baglan().Close();
        }
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand guncellemeKomutu = new SqlCommand
                    ("update ogrenciler set ogrenciTcNo='" +
                    maskedTcNo.Text + "',ogrenciAd='" + txtOgrenciAd.Text + 
                    "',ogrenciSoyad='" + txtOgrenciSoyad.Text +
                    "',ogrenciTelefon='" + maskedOgrenciTelefon.Text +
                    "',ogrenciDogumTarihi='" + maskedDogumTarihi.Text +
                    "',ogrenciBolum='" + comboBolum.Text + "',ogrenciMail='" +
                    txtMail.Text + "',ogrenciOdaNo='" + comboOda.Text + 
                    "',ogrenciVeliAdSoyad='" + txtVeliAdSoyad.Text + 
                    "',ogrenciVeliTelefon='" + maskedVeliTelefon.Text + 
                    "',ogrenciAdres='" + richtxtAdres.Text + "' where ogrenciId='" + txtOgrenciId.Text + "'", veritabaniBaglantisi.baglan());
                guncellemeKomutu.ExecuteNonQuery();
                veritabaniBaglantisi.baglan().Close();
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Güncellendi", "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sayfayiTemizle();                
                frmOgrenciListe.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("HATA LÜTFEN YENİDEN EKLEYİN", "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK, MessageBoxIcon.Error);
                veritabaniBaglantisi.baglan().Close();
            }

            
        }       
    }
}
