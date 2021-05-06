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
namespace TeknikServis.Formlar
{
    public partial class FrmMarkalar : Form
    {
        public FrmMarkalar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        SqlConnection baglanti = new SqlConnection("Data Source=PHOENIX;Initial Catalog=DbTeknikServis;Integrated Security=True");

        private void FrmMarkalar_Load_1(object sender, EventArgs e)
        {
            var degerler = db.Tbl_Urun.OrderBy(x => x.Marka).GroupBy(y => y.Marka).Select(z => new
            {
                Marka = z.Key,
                Toplam = z.Count()
            });
            gridControl1.DataSource = degerler.ToList();
            labelControl2.Text = db.Tbl_Urun.Count().ToString();
            labelControl3.Text = (from x in db.Tbl_Urun
                                  select
            x.Marka).Distinct().Count().ToString();
            labelControl7.Text = (from x in db.Tbl_Urun
                                  orderby x.SatisFiyat descending
                                  select x.Marka).FirstOrDefault();
            labelControl5.Text = db.maksurunmarka().FirstOrDefault();
            //chart1
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select Marka,count(*) from Tbl_Urun group by Marka", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(dr[0].ToString(), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();
            //chart2
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select tbl_kategori.Ad,count(*) as 'Sayı' from Tbl_Urun inner join Tbl_Kategori on Tbl_Kategori.Id=Tbl_Urun.Kategori group by Tbl_Kategori.Ad ", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Kategoriler"].Points.AddPoint(dr2[0].ToString(), int.Parse(dr2[1].ToString()));
            }
            baglanti.Close();
        }
    }
}
