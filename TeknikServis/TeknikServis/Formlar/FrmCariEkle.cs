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
    public partial class FrmCariEkle : Form
    {
        public FrmCariEkle()
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
            try
            {
                Tbl_Cari t = new Tbl_Cari();
                t.Ad = txtad.Text;
                t.Soyad = txtsoyad.Text;
                t.Banka = txtbanka.Text;
                t.Il = lookUpEdit2.Text;
                t.Ilce = lookUpEdit1.Text;
                t.Mail = txtmail.Text;
                t.Statu = txtstatu.Text;
                t.Telefon = txttel.Text;
                t.VergiDairesi = txtvergidaire.Text;
                t.VergiNo = txtvergino.Text;
                t.Adres = txtadres.Text;
                db.Tbl_Cari.Add(t);
                db.SaveChanges();
                MessageBox.Show("Yeni Cari Sisteme Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }

        }

        private void FrmCariEkle_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.NullText = "Bir Değer Seçiniz...";
            lookUpEdit2.Properties.NullText = "Bir Değer Seçiniz...";
            lookUpEdit2.Properties.DataSource = (from x in db.Tbl_Iller
                                           select new
                                           {
                                               x.id,
                                               x.sehir
                                           }).ToList();
        }
        int secilen;
        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            int secilen = int.Parse(lookUpEdit2.EditValue.ToString());
            lookUpEdit1.Properties.DataSource = (from y in db.Tbl_Ilceler
                                             select new
                                             {
                                                 y.id,
                                                 y.ilce,
                                                 y.sehir
                                             }).Where(z => z.sehir == secilen).ToList();
        }

        private void txtad_Click(object sender, EventArgs e)
        {
            txtad.Text = "";
            txtad.Focus();
        }

        private void txtsoyad_Click(object sender, EventArgs e)
        {
            txtsoyad.Text = "";
            txtsoyad.Focus();
        }

        private void txttel_Click(object sender, EventArgs e)
        {
            txttel.Text = "";
            txttel.Focus();
        }

        private void txtmail_Click(object sender, EventArgs e)
        {
            txtmail.Text = "";
            txtmail.Focus();
        }

        private void txtbanka_Click(object sender, EventArgs e)
        {
            txtbanka.Text = "";
            txtbanka.Focus();
        }

        private void txtvergidaire_Click(object sender, EventArgs e)
        {
            txtvergidaire.Text = "";
            txtvergidaire.Focus();
        }

        private void txtvergino_Click(object sender, EventArgs e)
        {
            txtvergino.Text = "";
            txtvergino.Focus();
        }

        private void txtstatu_Click(object sender, EventArgs e)
        {
            txtstatu.Text = "";
            txtstatu.Focus();
        }

        private void txtadres_Click(object sender, EventArgs e)
        {
            txtadres.Text = "";
            txtadres.Focus();
        }
    }
}
