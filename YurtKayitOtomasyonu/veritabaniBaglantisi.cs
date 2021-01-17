using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace YurtKayitOtomasyonu
{
    public class veritabaniBaglantisi
    {
        public SqlConnection baglan()
        {
            SqlConnection baglantim = new SqlConnection(@"Data Source=CASPER;Initial Catalog=YurtKayitOtomasyonu;Integrated Security=True");
            baglantim.Open();
            return baglantim;
        }
    }
}
