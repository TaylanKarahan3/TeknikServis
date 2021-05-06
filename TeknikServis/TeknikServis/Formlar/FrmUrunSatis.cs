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
    public partial class FrmUrunSatis : Form
    {
        public FrmUrunSatis()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsatisyap_Click(object sender, EventArgs e)
        {
            Tbl_UrunHareket u = new Tbl_UrunHareket();
            u.Adet = short.Parse(txtadet.Text);
            u.Fiyat = decimal.Parse(txtsatisfiyat.Text);
            u.Musteri = int.Parse(luecari.EditValue.ToString());
            u.Personel = short.Parse(luepersonel.EditValue.ToString());
            u.Tarih = DateTime.Parse(txttarih.Text);
            u.Urun = int.Parse(lueuruid.EditValue.ToString());
            u.UrunSeriNo = txtserino.Text;
            db.Tbl_UrunHareket.Add(u);
            db.SaveChanges();
            MessageBox.Show("Ürün Satışı Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmUrunSatis_Load(object sender, EventArgs e)
        {
            luecari.Properties.NullText = "Cari...";
            luepersonel.Properties.NullText = "Personel...";
            lueuruid.Properties.NullText = "Ürün Id...";
            lueuruid.Properties.DataSource = (from x in db.Tbl_Urun
                                              select new
                                              {
                                                  x.Id,
                                                  x.Ad
                                              }).ToList();

            luepersonel.Properties.DataSource = (from y in db.Tbl_Personel
                                                 select new
                                                 {
                                                     y.Id,
                                                     Ad = y.Ad + " " + y.Soyad
                                                 }).ToList();
            luecari.Properties.DataSource = (from i in db.Tbl_Cari
                                             select new
                                             {
                                                 i.Id,
                                                 Ad = i.Ad + " " + i.Soyad
                                             }).ToList();
        }

        private void txttarih_Click(object sender, EventArgs e)
        {
            txttarih.Text = DateTime.Now.ToShortDateString();
        }

        private void txtadet_Click(object sender, EventArgs e)
        {
            txtadet.Text = "";
            txtadet.Focus();
        }

        private void txtsatisfiyat_Click(object sender, EventArgs e)
        {
            txtsatisfiyat.Text = "";
            txtsatisfiyat.Focus();
        }

        private void txtserino_Click(object sender, EventArgs e)
        {
            txtserino.Text = "";
            txtserino.Focus();
        }
    }
}
