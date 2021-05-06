using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.Tbl_Urun
                                       select new
                                       {
                                           x.Ad,
                                           x.Stok
                                       }).Where(x => x.Stok < 30).ToList();

            gridControl2.DataSource = (from y in db.Tbl_Cari
                                       select new
                                       {
                                           AdSoyad = y.Ad + " " + y.Soyad,
                                           y.Il
                                       }).ToList();
            gridControl4.DataSource = db.ürünkategori().ToList();

            DateTime bugun = DateTime.Today;
            var deger = (from x in db.Tbl_Notlar.OrderBy(y => y.Id)
                         where (x.Tarih == bugun)
                         select new
                         {
                             x.Baslik,
                             x.İcerik
                         });
            gridControl3.DataSource = deger.ToList();

            string konu1, ad1, konu2, ad2, konu3, ad3, konu4, ad4, konu5, ad5;
            string konu6, ad6, konu7, ad7, konu8, ad8, konu9, ad9, konu10, ad10;
            konu1= db.Tbl_İletisim.First(x => x.Id == 1).Konu;
            ad1= db.Tbl_İletisim.First(x => x.Id == 1).AdSoyad;
            labelControl1.Text = ad1 + " - " + konu1;

            konu2 = db.Tbl_İletisim.First(x => x.Id == 4).Konu;
            ad2 = db.Tbl_İletisim.First(x => x.Id == 4).AdSoyad;
            labelControl2.Text = ad2 + " - " + konu2;

            konu3 = db.Tbl_İletisim.First(x => x.Id == 5).Konu;
            ad3 = db.Tbl_İletisim.First(x => x.Id == 5).AdSoyad;
            labelControl3.Text = ad3 + " - " + konu3;

            konu4 = db.Tbl_İletisim.First(x => x.Id == 6).Konu;
            ad4 = db.Tbl_İletisim.First(x => x.Id == 6).AdSoyad;
            labelControl4.Text = ad4 + " - " + konu4;

            konu5 = db.Tbl_İletisim.First(x => x.Id == 7).Konu;
            ad5 = db.Tbl_İletisim.First(x => x.Id == 7).AdSoyad;
            labelControl5.Text = ad5 + " - " + konu5;

            konu6 = db.Tbl_İletisim.First(x => x.Id == 8).Konu;
            ad6 = db.Tbl_İletisim.First(x => x.Id == 8).AdSoyad;
            labelControl6.Text = ad6 + " - " + konu6;

            konu7 = db.Tbl_İletisim.First(x => x.Id == 9).Konu;
            ad7 = db.Tbl_İletisim.First(x => x.Id == 9).AdSoyad;
            labelControl7.Text = ad7 + " - " + konu7;

            konu8 = db.Tbl_İletisim.First(x => x.Id == 10).Konu;
            ad8 = db.Tbl_İletisim.First(x => x.Id == 10).AdSoyad;
            labelControl8.Text = ad8 + " - " + konu8;

            konu9 = db.Tbl_İletisim.First(x => x.Id == 11).Konu;
            ad9 = db.Tbl_İletisim.First(x => x.Id == 11).AdSoyad;
            labelControl9.Text = ad9 + " - " + konu9;

            konu10 = db.Tbl_İletisim.First(x => x.Id == 12).Konu;
            ad10 = db.Tbl_İletisim.First(x => x.Id == 12).AdSoyad;
            labelControl10.Text = ad10 + " - " + konu10;
        }
    }
}
