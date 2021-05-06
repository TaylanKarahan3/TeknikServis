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
    public partial class FrmFaturaKalemPopUp : Form
    {
        public FrmFaturaKalemPopUp()
        {
            InitializeComponent();
        }
        public int id;
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmFaturaKalemPopUp_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.Tbl_FaturaDetay
                                       select new
                                       {
                                           x.FaturaDetayId,
                                           x.Urun,
                                           x.Adet,
                                           x.Fiyat,
                                           x.Tutar,
                                           x.FaturaId
                                       }).Where(x => x.FaturaId == id).ToList();
            gridControl2.DataSource = (from x in db.Tbl_FaturaBilgi
                                       select new
                                       {
                                           x.Id,
                                           x.Seri,
                                           x.SiraNo,
                                           x.Tarih,
                                           x.Saat,
                                           x.VergiDairesi,
                                           x.Cari,
                                           x.Personel
                                       }).Where(x => x.Id == id).ToList();
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.pdf";
            gridControl1.ExportToPdf(path);
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.xls";
            gridControl1.ExportToXls(path);
        }
    }
}
