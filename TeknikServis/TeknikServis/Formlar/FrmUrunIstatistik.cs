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
    public partial class FrmUrunIstatistik : Form
    {
        public FrmUrunIstatistik()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmUrunIstatistik_Load(object sender, EventArgs e)
        {
            labelControl2.Text = db.Tbl_Urun.Count().ToString();
            labelControl3.Text = db.Tbl_Kategori.Count().ToString();
            labelControl5.Text = db.Tbl_Urun.Sum(x => x.Stok).ToString();
            labelControl19.Text = (from x in db.Tbl_Urun
                                   orderby x.Stok descending
                                   select x.Ad).FirstOrDefault();
            labelControl17.Text = (from x in db.Tbl_Urun
                                   orderby x.Stok ascending
                                   select x.Ad).FirstOrDefault();
            labelControl7.Text = "10";
            labelControl13.Text = (from x in db.Tbl_Urun
                                   orderby x.SatisFiyat descending
                                   select x.Ad).FirstOrDefault();
            labelControl11.Text = (from x in db.Tbl_Urun
                                   orderby x.SatisFiyat ascending
                                   select x.Ad).FirstOrDefault();
            labelControl35.Text = db.Tbl_Urun.Count(x => x.Kategori == 4).ToString();
            labelControl33.Text = db.Tbl_Urun.Count(x => x.Kategori == 1).ToString();
            labelControl31.Text = db.Tbl_Urun.Count(x => x.Kategori == 3).ToString();
            labelControl29.Text = (from x in db.Tbl_Urun
                                   select
             x.Marka).Distinct().Count().ToString();
            labelControl5.Text= "Arçelik";
            labelControl25.Text = db.Tbl_UrunKabul.Count().ToString();
            labelControl15.Text = db.makskategoriurun().FirstOrDefault();
        }
    }
}
