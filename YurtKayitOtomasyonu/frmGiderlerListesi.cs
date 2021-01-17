using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitOtomasyonu
{
    public partial class frmGiderListesi : Form
    {
        public frmGiderListesi()
        {
            InitializeComponent();
        }

        private void FrmGiderListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitOtomasyonuDataSet4.giderler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.giderlerTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet4.giderler);
        }
        int secili;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secili = dataGridView1.SelectedCells[0].RowIndex;
            frmGiderBilgiDüzenleme frmGiderBilgiDüzenleme = new frmGiderBilgiDüzenleme();

            frmGiderBilgiDüzenleme.giderId= dataGridView1.Rows[secili].Cells[0].Value.ToString();
            frmGiderBilgiDüzenleme.elektrik= dataGridView1.Rows[secili].Cells[1].Value.ToString();
            frmGiderBilgiDüzenleme.su= dataGridView1.Rows[secili].Cells[2].Value.ToString();
            frmGiderBilgiDüzenleme.dogalgaz= dataGridView1.Rows[secili].Cells[3].Value.ToString();
            frmGiderBilgiDüzenleme.internet= dataGridView1.Rows[secili].Cells[4].Value.ToString();
            frmGiderBilgiDüzenleme.gida=dataGridView1.Rows[secili].Cells[5].Value.ToString();
            frmGiderBilgiDüzenleme.personel= dataGridView1.Rows[secili].Cells[6].Value.ToString();
            frmGiderBilgiDüzenleme.diger= dataGridView1.Rows[secili].Cells[7].Value.ToString();
            frmGiderBilgiDüzenleme.Show();
            this.Hide();           
        }
    }
}
