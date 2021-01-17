using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//veritabanından bilgileri alabilmek için sql kütüphanesini tanımlıyoruz
using System.Data.SqlClient;

namespace YurtKayitOtomasyonu
{
    public partial class frmOgrenciKayit : Form
    {
        public frmOgrenciKayit()
        {
            InitializeComponent();
        }
        veritabaniBaglantisi veritabaniBaglantisi = new veritabaniBaglantisi();

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
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.maskedTcNo, "TC Kimlik Numarası 11 Karakter Olmalı!!");
            txtOgrenciAd.MaxLength = 11;
            txtOgrenciSoyad.MaxLength = 11;
            txtVeliAdSoyad.MaxLength = 22;
            txtMail.MaxLength = 33;
            richtxtAdres.MaxLength = 220;
            txtOgrenciAd.CharacterCasing = CharacterCasing.Upper;
            txtOgrenciSoyad.CharacterCasing = CharacterCasing.Upper;

            //bölümleri listeleme komutları
            
            SqlCommand selectSorgusu = new SqlCommand("select bolumAd from bolumler",
                veritabaniBaglantisi.baglan());
            SqlDataReader verileriOku = selectSorgusu.ExecuteReader();

            while (verileriOku.Read())
            {
                comboBolum.Items.Add(verileriOku[0].ToString());
            }
            veritabaniBaglantisi.baglan().Close();

            //odaları listeleme komutları
            
            SqlCommand selectSorgusu2 = new SqlCommand("select odaNo from odalar where" +
                " odaKapasite!=odaAktif", veritabaniBaglantisi.baglan());
            SqlDataReader verileriOku2 = selectSorgusu2.ExecuteReader();

            while (verileriOku2.Read())
            {
                comboOda.Items.Add(verileriOku2[0].ToString());
            }
            veritabaniBaglantisi.baglan().Close();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            bool kayitKontrol = false;

            SqlCommand selectSorgu= new SqlCommand("select * from ogrenciler where ogrenciTcNo='" + maskedTcNo.Text + "'", veritabaniBaglantisi.baglan());
            SqlDataReader kayitOkuma = selectSorgu.ExecuteReader();
            while (kayitOkuma.Read())
            {
                kayitKontrol = true;
                break;
            }
            veritabaniBaglantisi.baglan().Close();

            if (kayitKontrol == false)
            {
                if (maskedTcNo.Text.Length < 11 || maskedTcNo.Text == "")
                {
                    lblTc.ForeColor = Color.Red;
                }
                else
                {
                    lblTc.ForeColor = Color.Black;
                }

                if (txtOgrenciAd.Text.Length < 2 || txtOgrenciAd.Text == "")
                {
                    lblOgrenciAd.ForeColor = Color.Red;
                }
                else
                {
                    lblOgrenciAd.ForeColor = Color.Black;
                }
                if (txtOgrenciSoyad.Text.Length < 2 || txtOgrenciSoyad.Text == "")
                {
                    lblOgrenciSoyad.ForeColor = Color.Red;
                }
                else
                {
                    lblOgrenciSoyad.ForeColor = Color.Black;
                }
                if(maskedTcNo.Text.Length==11 && txtOgrenciAd.Text!="" && txtOgrenciAd.Text.Length>1 && txtOgrenciSoyad.Text!="" && txtOgrenciSoyad.Text.Length > 1)
                {
                    try
                    {
                        //ogrenci kayıt işlemi
                        SqlCommand eklemeSorgusu = new SqlCommand("insert into ogrenciler " +
                            "(ogrenciTcNo,ogrenciAd,ogrenciSoyad,ogrenciTelefon,ogrenciDogumTarihi," +
                            "ogrenciBolum,ogrenciMail,ogrenciOdaNo,ogrenciVeliAdSoyad," +
                            "ogrenciVeliTelefon,ogrenciAdres) values('" + maskedTcNo.Text + "','" +
                            txtOgrenciAd.Text + "','" + txtOgrenciSoyad.Text + "','" +
                            maskedOgrenciTelefon.Text + "','" + maskedDogumTarihi.Text +
                            "','" + comboBolum.Text + "','" + txtMail.Text + "','" +
                            comboOda.Text + "','" + txtVeliAdSoyad.Text + "','" +
                            maskedVeliTelefon.Text + "','" + richtxtAdres.Text +
                            "') ", veritabaniBaglantisi.baglan());
                        eklemeSorgusu.ExecuteNonQuery();
                        veritabaniBaglantisi.baglan().Close();
                        MessageBox.Show("Kayıt Başarılı Bir Şekilde Eklendi",
                            "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);

                        //ogrenci ıd labele aktarımı
                        SqlCommand idAlKomutu = new SqlCommand("select ogrenciId " +
                            "from ogrenciler", veritabaniBaglantisi.baglan());
                        SqlDataReader idleriOku = idAlKomutu.ExecuteReader();
                        while (idleriOku.Read())
                        {
                            lblOgrenciId.Text = idleriOku[0].ToString();
                        }
                        veritabaniBaglantisi.baglan().Close();

                        //ogrenci borç oluşturma
                        SqlCommand borclaraEklemeSorgusu = new SqlCommand("insert into borclar " +
                            "(ogrenciId,ogrenciAd,ogrenciSoyad) values ('" + lblOgrenciId.Text +
                            "','" + txtOgrenciAd.Text + "','" + txtOgrenciSoyad.Text + "')",
                            veritabaniBaglantisi.baglan());
                        borclaraEklemeSorgusu.ExecuteNonQuery();
                        veritabaniBaglantisi.baglan().Close();


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("HATA LÜTFEN YENİDEN EKLEYİN",
                            "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        veritabaniBaglantisi.baglan().Close();
                    }

                    //Oda kontejanını Artırma

                    SqlCommand odaKontejanArtırmaKomutu = new SqlCommand("update odalar " +
                        "set odaAktif=odaAktif+1 where odaNo='" + comboOda.Text + "'",
                        veritabaniBaglantisi.baglan());
                    odaKontejanArtırmaKomutu.ExecuteNonQuery();
                    veritabaniBaglantisi.baglan().Close();
                    sayfayiTemizle();

                }
                else
                {
                    MessageBox.Show("Yazı Rengi Kırmızı Olan Alanları Tekrar Gözden Geçiriniz!","YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Girilen TC Kimlik Numarası Daha Önceden Kayıtlıdır!", "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }


            

            
        }

        private void maskedTcNo_TextChanged(object sender, EventArgs e)
        {
            if (maskedTcNo.Text.Length < 11)
            {
                errorProvider1.SetError(maskedTcNo, "TC Kimlik No 11 Karakter Olmalı!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void maskedTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar>=48 && (int)e.KeyChar<=57) || (int)e.KeyChar==8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtOgrenciAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar)==true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtOgrenciSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtVeliAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
