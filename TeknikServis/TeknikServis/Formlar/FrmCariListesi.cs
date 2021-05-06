using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TeknikServis.Formlar
{
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void listele()
        {
            var deglerler = from c in db.Tbl_Cari
                            select new
                            {
                                c.Id,
                                c.Ad,
                                c.Soyad,
                                c.Telefon,
                                c.Mail,
                                c.Il,
                                c.Ilce
                            };
            gridControl1.DataSource = deglerler.ToList();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=PHOENIX;Initial Catalog=DbTeknikServis;Integrated Security=True");
        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            listele();
            labelControl8.Text = db.Tbl_Cari.Count().ToString();
            lueil.Properties.NullText = "Bir Değer Seçiniz...";
            lueilce.Properties.NullText = "Bir Değer Seçiniz...";
            lueil.Properties.DataSource = (from x in db.Tbl_Iller
                                           select new
                                           {
                                               x.id,
                                               x.sehir
                                           }).ToList();
            labelControl14.Text = db.Tbl_Cari.Select(x => x.Il).Distinct().Count().ToString();
            labelControl12.Text = db.Tbl_Cari.Select(x => x.Ilce).Distinct().Count().ToString();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select top 1 Il from Tbl_Cari group by Il order by count(*) desc", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                labelControl10.Text = dr[0].ToString();
            }
            baglanti.Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            Tbl_Cari t = new Tbl_Cari();
            t.Ad = txtcariad.Text;
            t.Soyad = txtsoyad.Text;
            t.Adres = txtadres.Text;
            t.Mail = txtmail.Text;
            t.Statu = txtstatu.Text;
            t.Telefon = txttelefon.Text;
            t.VergiDairesi = txtvergid.Text;
            t.VergiNo = txtvergino.Text;
            t.Il = lueil.Text;
            t.Ilce = lueilce.Text;
            db.Tbl_Cari.Add(t);
            db.SaveChanges();
            MessageBox.Show("Yeni Cari Sisteme Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Cari Silinsin Mi?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                int id = int.Parse(txtcariid.Text);
                var deger = db.Tbl_Cari.Find(id);
                db.Tbl_Cari.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Cari Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
            }
            else
            {
                listele();
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtcariid.Text);
            var deger = db.Tbl_Cari.Find(id);
            deger.Ad = txtcariad.Text;
            deger.Soyad = txtsoyad.Text;
            deger.Adres = txtadres.Text;
            deger.Banka = txtbanka.Text;
            deger.Il = lueil.Text;
            deger.Ilce = lueilce.Text;
            deger.Mail = txtmail.Text;
            deger.Statu = txtstatu.Text;
            deger.Telefon = txttelefon.Text;
            deger.VergiDairesi = txtvergid.Text;
            deger.VergiNo = txtvergino.Text;
            db.SaveChanges();
            MessageBox.Show("Cari Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtcariad.Text = "";
            txtsoyad.Text = "";
            txtadres.Text = "";
            txtmail.Text = "";
            txtstatu.Text = "";
            txttelefon.Text = "";
            txtvergid.Text = "";
            txtvergino.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtcariid.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtcariad.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            txtsoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
           // txttelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
          //  txtmail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
         //   txtbanka.Text = gridView1.GetFocusedRowCellValue("Banka").ToString();
         //   txtvergid.Text = gridView1.GetFocusedRowCellValue("VergiDairesi").ToString();
        //    txtvergino.Text = gridView1.GetFocusedRowCellValue("VergiNo").ToString();
         //   txtstatu.Text = gridView1.GetFocusedRowCellValue("Statu").ToString();
         //   txtadres.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
        }
        int secilen;
        private void lueil_EditValueChanged(object sender, EventArgs e)
        {
            int secilen = int.Parse(lueil.EditValue.ToString());
            lueilce.Properties.DataSource = (from y in db.Tbl_Ilceler
                                             select new
                                             {
                                                 y.id,
                                                 y.ilce,
                                                 y.sehir
                                             }).Where(z=>z.sehir==secilen).ToList();
        }
    }
}

