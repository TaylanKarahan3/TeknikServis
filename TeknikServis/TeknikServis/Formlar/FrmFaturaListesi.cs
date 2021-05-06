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
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void listele()
        {
            var degerler = from x in db.Tbl_FaturaBilgi
                           select new
                           {
                               x.Id,
                               x.Seri,
                               x.SiraNo,
                               x.Tarih,
                               x.Saat,
                               x.VergiDairesi,
                               Cari = x.Tbl_Cari.Ad + " " + x.Tbl_Cari.Soyad,
                               Personel = x.Tbl_Personel.Ad + " " + x.Tbl_Personel.Soyad
                           };
            gridControl1.DataSource = degerler.ToList();
            lkupersonel.Properties.DataSource = (from x in db.Tbl_Personel
                                                 select new
                                                 {
                                                     x.Id,
                                                     Ad = x.Ad + " " + x.Soyad
                                                 }).ToList();

            lkucari.Properties.DataSource = (from z in db.Tbl_Cari
                                             select new
                                             {
                                                 z.Id,
                                                 Ad = z.Ad + " " + z.Soyad
                                             }).ToList();
        }
        void temizle()
        {
            txtid.Text = "";
            txtsaat.Text = "";
            txtseri.Text = "";
            txtsirano.Text = "";
            txttarih.Text = "";
            txtvergid.Text = "";
            lkucari.EditValue = null;
            lkupersonel.EditValue = null;
        }
        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
            lkucari.Properties.NullText = "Bir Değer Seçiniz...";
            lkupersonel.Properties.NullText = "Bir Değer Seçiniz...";
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            Tbl_FaturaBilgi t = new Tbl_FaturaBilgi();
            t.Saat = txtsaat.Text;
            t.Tarih = Convert.ToDateTime(txttarih.Text);
            t.VergiDairesi = txtvergid.Text;
            t.SiraNo = txtsirano.Text;
            t.Seri = txtseri.Text;
            t.Cari = int.Parse(lkucari.EditValue.ToString());
            t.Personel = short.Parse(lkupersonel.EditValue.ToString());
            db.Tbl_FaturaBilgi.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaKalemPopUp fr = new FrmFaturaKalemPopUp();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            fr.Show();
        }
    }
}
