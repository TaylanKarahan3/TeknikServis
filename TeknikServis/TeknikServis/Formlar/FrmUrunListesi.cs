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
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }
        void listele()
        {
            var degerler = from u in db.Tbl_Urun
                           select new
                           {
                               u.Id,
                               u.Ad,
                               u.Marka,
                               Kategori = u.Tbl_Kategori.Ad,
                               u.Stok,
                               u.AlisFiyat,
                               u.SatisFiyat
                           };
            gridControl1.DataSource = degerler.ToList();
            lookUpEdit1.Properties.DataSource = (from x in db.Tbl_Kategori
                                                 select new
                                                 {
                                                     x.Id,
                                                     x.Ad
                                                 }).ToList();
        }
        void temizle()
        {
            txtalisfiyat.Text = "";
            txtmarka.Text = "";
            txtsatisfiyat.Text = "";
            txtstok.Text = "";
            txturunad.Text = "";
            txturunid.Text = "";
            lookUpEdit1.EditValue = null;
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.NullText = "Bir Değer Seçiniz...";
            listele();
            temizle();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            Tbl_Urun t = new Tbl_Urun();
            t.Ad = txturunad.Text;
            t.Marka = txtmarka.Text;
            t.AlisFiyat = decimal.Parse(txtalisfiyat.Text);
            t.SatisFiyat = decimal.Parse(txtsatisfiyat.Text);
            t.Stok = short.Parse(txtstok.Text);
            t.Durum = false;
            t.Kategori = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.Tbl_Urun.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txturunid.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
                txturunad.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
                txtmarka.Text = gridView1.GetFocusedRowCellValue("Marka").ToString();
                txtalisfiyat.Text = gridView1.GetFocusedRowCellValue("AlisFiyat").ToString();
                txtsatisfiyat.Text = gridView1.GetFocusedRowCellValue("SatisFiyat").ToString();
                txtstok.Text = gridView1.GetFocusedRowCellValue("Stok").ToString();
                lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("Kategori").ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Ürün Silinsin Mi?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                int id = int.Parse(txturunid.Text);
                var deger = db.Tbl_Urun.Find(id);
                db.Tbl_Urun.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Ürün Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
            }
            else
            {
                listele();
            }

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txturunid.Text);
            var deger = db.Tbl_Urun.Find(id);
            deger.Ad = txturunad.Text;
            deger.Stok = short.Parse(txtstok.Text);
            deger.Marka = txtmarka.Text;
            deger.AlisFiyat = decimal.Parse(txtalisfiyat.Text);
            deger.SatisFiyat = decimal.Parse(txtsatisfiyat.Text);
            deger.Kategori = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}
