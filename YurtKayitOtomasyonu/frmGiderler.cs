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
    public partial class frmGiderler : Form
    {
        public frmGiderler()
        {
            InitializeComponent();
        }

        private void sayfayiTemizle()
        {
            txtDiğer.Clear();
            txtDoğalgaz.Clear();
            txtElektrik.Clear();
            txtGıda.Clear();
            txtPersonel.Clear();
            txtSu.Clear();
            txtİnternet.Clear();
        }

        veritabaniBaglantisi veritabaniBaglantisi = new veritabaniBaglantisi();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand eklemeKomutu = new SqlCommand("insert into giderler (elektrik,su,dogalgaz,internet,gida,personelMaas,diger) values('" + txtElektrik.Text + "','" + txtSu.Text + "','" + txtDoğalgaz.Text + "','" + txtİnternet.Text + "','" + txtGıda.Text + "','" + txtPersonel.Text + "','" + txtDiğer.Text + "')", veritabaniBaglantisi.baglan());
                eklemeKomutu.ExecuteNonQuery();
                veritabaniBaglantisi.baglan().Close();
                MessageBox.Show("Kayıtlar başarıyla eklendi","YILDIZLAR YURT KAYIT OTOMASYONU",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                sayfayiTemizle();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu lütfen tekrar deneyin!!", "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }
    }
}
