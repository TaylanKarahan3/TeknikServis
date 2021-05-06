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
    public partial class FrmArizaDetaylar : Form
    {
        public FrmArizaDetaylar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        public string id,serino;
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Tbl_UrunTakip t = new Tbl_UrunTakip();
            t.Aciklama = richTextBox1.Text;
            t.SeriNo = txtserino.Text;
            t.Tarih = DateTime.Parse(txttarih.Text);
            db.Tbl_UrunTakip.Add(t);

            //2.güncelleme
            Tbl_UrunKabul tb = new Tbl_UrunKabul();
            int urunid= int.Parse(id.ToString());
            var deger = db.Tbl_UrunKabul.Find(urunid);
            deger.UrunDurumDetay = comboBox1.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün Arıza Detayları Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txttarih_Click(object sender, EventArgs e)
        {
            txttarih.Text = DateTime.Now.ToShortDateString();
        }

        private void txtserino_Click(object sender, EventArgs e)
        {
            txtserino.Text = "";
            txtserino.Focus();
        }

        private void FrmArizaDetaylar_Load(object sender, EventArgs e)
        {
            txtserino.Text = serino;

        }
    }
}
