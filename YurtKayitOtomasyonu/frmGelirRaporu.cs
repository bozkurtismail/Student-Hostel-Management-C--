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
    public partial class frmGelirRaporu : Form
    {
        public frmGelirRaporu()
        {
            InitializeComponent();
        }
        veritabaniBaglantisi veritabaniBaglantisi = new veritabaniBaglantisi();

        private void FrmGelirRaporu_Load(object sender, EventArgs e)
        {
            SqlCommand kasadakiParaToplamaKomutu = new SqlCommand("select sum(odemeMiktari) from kasa",veritabaniBaglantisi.baglan());
            SqlDataReader verileriOku = kasadakiParaToplamaKomutu.ExecuteReader();

            while (verileriOku.Read())
            {
                lblKasadakiPara.Text = verileriOku[0].ToString() + " TL";
            }
            veritabaniBaglantisi.baglan().Close();


            SqlCommand aylariComboyaEkleKomutu = new SqlCommand("select distinct(odemeAyi) from kasa", veritabaniBaglantisi.baglan());
            SqlDataReader verileriOku2 = aylariComboyaEkleKomutu.ExecuteReader();

            while (verileriOku2.Read())
            {
                comboAySecimi.Items.Add(verileriOku2[0].ToString());
            }
            veritabaniBaglantisi.baglan().Close();

            //grafiğe veri alma
            SqlCommand grafigeVeriAlmaKomutu = new SqlCommand("select odemeAyi,sum(odemeMiktari) from kasa group by odemeAyi order by odemeAyi asc", veritabaniBaglantisi.baglan());
            SqlDataReader verileriOku3 = grafigeVeriAlmaKomutu.ExecuteReader();
            while (verileriOku3.Read())
            {
                this.chart1.Series["AYLIK"].Points.AddXY(verileriOku3[0],verileriOku3[1]);
            }
            veritabaniBaglantisi.baglan().Close();

        }

        private void ComboAySecimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand secilenAyParaMiktariKomutu = new SqlCommand("select sum(odemeMiktari) from kasa where odemeAyi='" + comboAySecimi.Text + "'", veritabaniBaglantisi.baglan());
            SqlDataReader verileriOku = secilenAyParaMiktariKomutu.ExecuteReader();
            while (verileriOku.Read())
            {
                lblSecilenAyParaMiktari.Text = verileriOku[0].ToString() + " TL";
            }
            veritabaniBaglantisi.baglan().Close();
        }
    }
}
