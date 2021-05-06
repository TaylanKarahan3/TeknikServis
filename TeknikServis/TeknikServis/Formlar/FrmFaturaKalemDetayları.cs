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
    public partial class FrmFaturaKalemDetayları : Form
    {
        public FrmFaturaKalemDetayları()
        {
            InitializeComponent();
        }
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
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void btnara_Click(object sender, EventArgs e)
        {
            //fatura id arama
            if (txtserino.Text == "" && txtsirano.Text == "")
            {
                int id = Convert.ToInt32(txtfaturaid.Text);
                var degerler = (from x in db.Tbl_FaturaDetay
                                select new
                                {
                                    x.FaturaDetayId,
                                    x.Urun,
                                    x.Adet,
                                    x.Fiyat,
                                    x.Tutar,
                                    x.FaturaId
                                }).Where(x => x.FaturaId == id);
                gridControl1.DataSource = degerler.ToList();
            }
            if (txtfaturaid.Text == "" )
            {
                //seri no ve sıra no arama
                var degerler2 = (from x in db.Tbl_FaturaDetay.Where(m => m.Tbl_FaturaBilgi.Seri == txtserino.Text && m.Tbl_FaturaBilgi.SiraNo == txtsirano.Text)
                                 select new
                                 {
                                     x.FaturaDetayId,
                                     x.Urun,
                                     x.Adet,
                                     x.Fiyat,
                                     x.Tutar,
                                     x.FaturaId
                                 });
                gridControl1.DataSource = degerler2.ToList();

            }
            /*if (txtsirano.Text != null)
            {
                //sıra no arama
                var degerler3 = (from x in db.Tbl_FaturaDetay.Where(i => i.Tbl_FaturaBilgi.SiraNo == txtsirano.Text)
                                 select new
                                 {
                                     x.FaturaDetayId,
                                     x.Urun,
                                     x.Adet,
                                     x.Fiyat,
                                     x.Tutar,
                                     x.FaturaId
                                 });
                gridControl1.DataSource = degerler3.ToList();
            }*/
        }
    }
}
