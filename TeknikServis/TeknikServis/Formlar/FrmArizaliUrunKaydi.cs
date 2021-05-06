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
    public partial class FrmArizaliUrunKaydi : Form
    {
        public FrmArizaliUrunKaydi()
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
           
            Tbl_UrunKabul t = new Tbl_UrunKabul();
            t.Cari = int.Parse(lookUpEdit1.EditValue.ToString());
            t.GelisTarihi = DateTime.Parse(txttarih.Text);
            t.Personel = short.Parse(lookUpEdit2.EditValue.ToString());
            t.UrunSeriNo = txtserino.Text;
            t.UrunDurumDetay = "Ürün Kaydoldu.";
            db.Tbl_UrunKabul.Add(t);
            db.SaveChanges();
            MessageBox.Show("Arızalı Ürün Kaydı Yapıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmArizaliUrunKaydi_Load(object sender, EventArgs e)
        {
            //müşteri
            lookUpEdit1.Properties.NullText = "Bir Değer Seçiniz...";
            lookUpEdit1.Properties.DataSource = (from x in db.Tbl_Cari
                                                 select new
                                                 {
                                                     x.Id,
                                                     Ad = x.Ad + " " + x.Soyad
                                                 }).ToList();
            //personel
            lookUpEdit2.Properties.NullText = "Bir Değer Seçiniz...";
            lookUpEdit2.Properties.DataSource = (from x in db.Tbl_Personel
                                                 select new
                                                 {
                                                     x.Id,
                                                     Ad = x.Ad + " " + x.Soyad
                                                 }).ToList();
        }

        private void txttarih_Click(object sender, EventArgs e)
        {
            txttarih.Text = DateTime.Now.ToShortDateString();
        }
    }
}
