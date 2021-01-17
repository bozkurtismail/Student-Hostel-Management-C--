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
    public partial class frmKullaniciGiris : Form
    {
        public frmKullaniciGiris()
        {
            InitializeComponent();
        }
        veritabaniBaglantisi veritabaniBaglantisi = new veritabaniBaglantisi();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand secmeSorgusu = new SqlCommand
                ("select * from admin where yoneticiAd='"+txtKullaniciAdi.Text+"' " +
                "and yoneticiSifre='"+txtParola.Text+"' ",veritabaniBaglantisi.baglan());
            SqlDataReader verileriOku = secmeSorgusu.ExecuteReader();
            if (verileriOku.Read())
            {
                frmAnaSayfa frmAnaSayfa = new frmAnaSayfa();
                frmAnaSayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Yada Şifre", 
                    "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtKullaniciAdi.Clear();
                txtParola.Clear();
                txtKullaniciAdi.Focus();
            }
            veritabaniBaglantisi.baglan().Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
