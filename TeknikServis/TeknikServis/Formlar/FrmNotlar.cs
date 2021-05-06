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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void temizle()
        {
            txticerik.Text = "";
            txtnotid.Text = "";
            txtbaslik.Text = "";
        }
        void okunmayan()
        {
            gridControl1.DataSource = db.Tbl_Notlar.Where(x => x.Durum == false).ToList();
        }
        void okunan()
        {
            gridControl2.DataSource = db.Tbl_Notlar.Where(y => y.Durum == true).ToList();
        }
        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            okunan();
            okunmayan();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            Tbl_Notlar t = new Tbl_Notlar();
            t.Baslik = txtbaslik.Text;
            t.İcerik = txticerik.Text;
            t.Durum = false;
            t.Tarih = DateTime.Parse(txttarih.Text);
            db.Tbl_Notlar.Add(t);
            db.SaveChanges();
            MessageBox.Show("Not Başarıyla Keydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            okunan();
            okunmayan();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
            {
                int id = int.Parse(txtnotid.Text);
                var deger = db.Tbl_Notlar.Find(id);
                deger.Durum = true;
                db.SaveChanges();
                MessageBox.Show("Not Durumu Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                okunan();
                okunmayan();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            txtnotid.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            //txtbaslik.Text = gridView1.GetFocusedRowCellValue("Baslik").ToString();
            //txticerik.Text = gridView1.GetFocusedRowCellValue("Icerik").ToString();
        }
    }
}
