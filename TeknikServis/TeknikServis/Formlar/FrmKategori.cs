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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }
        void listele()
        {
            var degerler = from k in db.Tbl_Kategori
                           select new
                           {
                               k.Id,
                               k.Ad
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        void temizle()
        {
            txtkategoriad.Text = "";
            txtkategoriid.Text = "";
        }
        Random rast = new Random();
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmKategori_Load(object sender, EventArgs e)
        {
            ımageSlider1.CurrentImageIndex = rast.Next(0, 24);
            ımageSlider2.CurrentImageIndex = rast.Next(0, 24);
            ımageSlider3.CurrentImageIndex = rast.Next(0, 24);
            listele();
            temizle();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtkategoriad.Text != "" && txtkategoriad.Text.Length <= 30)
            {
            Tbl_Kategori k = new Tbl_Kategori();
            k.Ad = txtkategoriad.Text;
            db.Tbl_Kategori.Add(k);
            db.SaveChanges();
            MessageBox.Show("Kategori Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            }
            else
            {
                MessageBox.Show("Kategori ad boş geçilemez ve 30 karakterden fazla olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtkategoriid.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtkategoriad.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Kategori Silinsin Mi?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                int id = int.Parse(txtkategoriid.Text);
                var deger = db.Tbl_Kategori.Find(id);
                db.Tbl_Kategori.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Kategori Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
            }
            else
            {
                listele();
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtkategoriid.Text);
            var deger = db.Tbl_Kategori.Find(id);
            deger.Ad = txtkategoriad.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}
