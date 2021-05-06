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
    public partial class FrmCariIller : Form
    {
        public FrmCariIller()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        SqlConnection baglanti = new SqlConnection(@"Data Source=PHOENIX;Initial Catalog=DbTeknikServis;Integrated Security=True");
        private void FrmCariIller_Load(object sender, EventArgs e)
        {
            /*chartControl1.Series["Series 1"].Points.AddPoint("Ankara", 22);
            chartControl1.Series["Series 1"].Points.AddPoint("İstanbul", 12);
            chartControl1.Series["Series 1"].Points.AddPoint("İzmir", 8);
            chartControl1.Series["Series 1"].Points.AddPoint("Bursa", 14);
            */

            gridControl1.DataSource = db.Tbl_Cari.OrderBy(x => x.Il).GroupBy(y => y.Il).Select(z => new
            {
                Il = z.Key,
                Toplam = z.Count()
            }).ToList();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select Il,count(*) from tbl_cari group by Il", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();
                
        }
    }
}
