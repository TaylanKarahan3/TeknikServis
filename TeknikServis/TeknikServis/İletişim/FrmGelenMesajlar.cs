using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.İletişim
{
    public partial class FrmGelenMesajlar : Form
    {
        public FrmGelenMesajlar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmGelenMesajlar_Load(object sender, EventArgs e)
        {
            labelControl8.Text = db.Tbl_İletisim.Count().ToString();
            labelControl10.Text = db.Tbl_İletisim.Where(z => z.Konu == "Teşekkür").Count().ToString();
            labelControl14.Text = db.Tbl_İletisim.Where(z => z.Konu == "Rica").Count().ToString();
            labelControl12.Text = db.Tbl_İletisim.Where(z => z.Konu == "Şikayet").Count().ToString();
            labelControl1.Text = db.Tbl_Personel.Count().ToString();
            labelControl3.Text = db.Tbl_Cari.Count().ToString();
            labelControl5.Text = db.Tbl_Kategori.Count().ToString();
            labelControl7.Text = db.Tbl_Urun.Count().ToString();
            gridControl1.DataSource = (from x in db.Tbl_İletisim
                                       select new
                                       {
                                           x.Id,
                                           x.AdSoyad,
                                           x.Konu,
                                           x.Mail,
                                           x.Mesaj
                                       }).ToList();
        }
    }
}
