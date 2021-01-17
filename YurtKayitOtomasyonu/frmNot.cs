using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YurtKayitOtomasyonu
{
    public partial class frmNot : Form
    {
        public frmNot()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Kayıt Alanını Seçiniz";
            saveFileDialog1.Filter = "Word Dosyası | *.doc";
            saveFileDialog1.InitialDirectory = "‪D:\\NOTLAR";
            saveFileDialog1.ShowDialog();
            StreamWriter kayitEkle = new StreamWriter(saveFileDialog1.FileName);
            kayitEkle.WriteLine(richTextBox1.Text);
            kayitEkle.Close();
            MessageBox.Show("Kayıt Başarılı Bir Şekilde Eklendi", "YILDIZLAR YURT KAYIT OTOMASYONU", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
