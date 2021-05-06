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
    public partial class FrmFaturaKalem : Form
    {
        public FrmFaturaKalem()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void listele()
        {
            var degerler = (from x in db.Tbl_FaturaDetay
                            select new
                            {
                                x.FaturaDetayId,
                                x.Urun,
                                x.Adet,
                                x.Fiyat,
                                x.Tutar,
                                x.FaturaId
                            });
            gridControl1.DataSource = degerler.ToList();
        }
        void temizle()
        {
            txtadet.Text = "";
            txtdetayid.Text = "";
            txtfaturaid.Text = "";
            txtfiyat.Text = "";
            txttutar.Text = "";
            txturun.Text = "";
        }

        private void btntemizle_Click_1(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            Tbl_FaturaDetay t = new Tbl_FaturaDetay();
            t.Adet = short.Parse(txtadet.Text);
            t.Fiyat = decimal.Parse(txtfiyat.Text);
            t.Tutar = decimal.Parse(txttutar.Text);
            t.Urun = txturun.Text;
            t.FaturaId = int.Parse(txtfaturaid.Text);
            db.Tbl_FaturaDetay.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Kalem İşlemi Gerçekleştirildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void FrmFaturaKalem_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }
    }
}
