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
    public partial class FrmArizaListesi : Form
    {
        public FrmArizaListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        SqlConnection baglanti = new SqlConnection("Data Source=PHOENIX;Initial Catalog=DbTeknikServis;Integrated Security=True");
        void listele()
        {
            var degeler = from x in db.Tbl_UrunKabul
                          select new
                          {
                              x.İslemId,
                              Cari = x.Tbl_Cari.Ad + " " + x.Tbl_Cari.Soyad,
                              Personel = x.Tbl_Personel.Ad + " " + x.Tbl_Personel.Soyad,
                              x.GelisTarihi,
                              x.CikisTarihi,
                              x.UrunSeriNo,
                              x.UrunDurumDetay
                          };
            gridControl1.DataSource = degeler.ToList();
        }
        private void FrmArizaListesi_Load(object sender, EventArgs e)
        {
            listele();
            labelControl3.Text = db.Tbl_UrunKabul.Count(x=>x.UrunDurum==true).ToString();
            labelControl5.Text = db.Tbl_UrunKabul.Count(x=>x.UrunDurum==false).ToString();
            labelControl13.Text = db.Tbl_Urun.Count().ToString();
            labelControl7.Text = db.Tbl_UrunKabul.Count(x => x.UrunDurumDetay == "Parça Bekliyor.").ToString();
            labelControl15.Text = db.Tbl_UrunKabul.Count(x => x.UrunDurumDetay == "Mesaj Bekliyor.").ToString();
            labelControl11.Text = db.Tbl_UrunKabul.Count(x => x.UrunDurumDetay == "İptal Bekliyor.").ToString();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select UrunDurumDetay,count(*) from Tbl_UrunKabul group by UrunDurumDetay", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(dr[0].ToString(), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmArizaDetaylar fr = new FrmArizaDetaylar();
            fr.id = gridView1.GetFocusedRowCellValue("İslemId").ToString();
            fr.serino = gridView1.GetFocusedRowCellValue("UrunSeriNo").ToString();
            fr.Show();
        }
    }
}
