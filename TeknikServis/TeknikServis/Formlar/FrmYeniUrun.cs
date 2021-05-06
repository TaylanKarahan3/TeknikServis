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
    public partial class FrmYeniUrun : Form
    {
        public FrmYeniUrun()
        {
            InitializeComponent();
        }
        
        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void btnkaydet_Click(object sender, EventArgs e)
        {
           
            Tbl_Urun t = new Tbl_Urun();
            t.Ad = txturunad.Text;
            t.AlisFiyat = decimal.Parse(txtalisfiyat.Text);
            t.SatisFiyat = decimal.Parse(txtsatisfiyat.Text);
            t.Stok = short.Parse(txtstok.Text);
            t.Marka = txtmarka.Text;
            t.Kategori = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.Tbl_Urun.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txturunad_MouseClick(object sender, MouseEventArgs e)
        {
            txturunad.Text = "";
            txturunad.Focus();
        }

        private void txtmarka_Click(object sender, EventArgs e)
        {
            txtmarka.Text = "";
            txtmarka.Focus();
        }

        private void txtalisfiyat_Click(object sender, EventArgs e)
        {
            txtalisfiyat.Text = "";
            txtalisfiyat.Focus();
        }

        private void txtsatisfiyat_Click(object sender, EventArgs e)
        {
            txtsatisfiyat.Text = "";
            txtsatisfiyat.Focus();
        }

        private void txtstok_Click(object sender, EventArgs e)
        {
            txtstok.Text = "";
            txtstok.Focus();
        }
        private void FrmYeniUrun_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.NullText = "Bir Değer Seçiniz...";
            lookUpEdit1.Properties.DataSource = (from x in db.Tbl_Kategori
                                                 select new
                                                 {
                                                     x.Id,
                                                     x.Ad
                                                 }).ToList();
        }
    }
}
