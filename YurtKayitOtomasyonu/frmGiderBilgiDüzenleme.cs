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
    public partial class frmGiderBilgiDüzenleme : Form
    {
        public frmGiderBilgiDüzenleme()
        {
            InitializeComponent();
        }
        public string giderId,elektrik,su,dogalgaz,gida,internet,personel,diger;

        veritabaniBaglantisi veritabaniBaglantisi = new veritabaniBaglantisi();
        frmGiderListesi frmGiderListesi = new frmGiderListesi();

        private void sayfayiTemizle()
        {
            txtGiderId.Clear();
            txtElektrik.Clear();
            txtSu.Clear();
            txtDogalgaz.Clear();
            txtInternet.Clear();
            txtGıda.Clear();
            txtPersonel.Clear();
            txtDiger.Clear();
        }
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlCommand guncellemeKomutu = new SqlCommand("update giderler set elektrik='" + txtElektrik.Text + "',su='" + txtSu.Text + "' where odemeId='" + txtGiderId.Text + "'", veritabaniBaglantisi.baglan());
                SqlCommand guncellemeKomutu = new SqlCommand("update giderler set elektrik='" + txtElektrik.Text + "',su='" + txtSu.Text + "',dogalgaz='" + txtDogalgaz.Text + "',internet='" + txtInternet.Text + "',gida='" + txtGıda.Text + "',personelMaas='" + txtPersonel.Text + "',diger='" + txtDiger.Text + "' where odemeId='" + txtGiderId.Text + "'", veritabaniBaglantisi.baglan());
                guncellemeKomutu.ExecuteNonQuery();
                veritabaniBaglantisi.baglan().Close();
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Güncellendi", "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sayfayiTemizle();
                frmGiderListesi.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("HATA LÜTFEN YENİDEN EKLEYİN", "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK, MessageBoxIcon.Error);
                veritabaniBaglantisi.baglan().Close();
            }            
        }

        private void FrmGiderBilgiDüzenleme_Load(object sender, EventArgs e)
        {
            txtGiderId.Text = giderId;
            txtElektrik.Text = elektrik;
            txtSu.Text = su;
            txtDogalgaz.Text = dogalgaz;
            txtGıda.Text = gida;
            txtInternet.Text = internet;
            txtPersonel.Text = personel;
            txtDiger.Text = diger;
        }
    }
}
