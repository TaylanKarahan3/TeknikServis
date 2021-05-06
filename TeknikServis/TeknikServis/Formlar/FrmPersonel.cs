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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void listele()
        {
            var degerler = from p in db.Tbl_Personel
                           select new
                           {
                               p.Id,
                               p.Ad,
                               p.Soyad,
                               p.Mail,
                               p.Telefon
                           };
            gridControl1.DataSource = degerler.ToList();

            lookUpEdit1.Properties.DataSource = (from x in db.Tbl_Departman
                                                 select new
                                                 {
                                                     x.Id,
                                                     x.Ad
                                                 }).ToList();
        }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.NullText = "Bir Değer Seçiniz...";
            listele();
            string ad1, soyad1, ad2, soyad2, ad3, soyad3, ad4, soyad4;
            //1.personel
            ad1 = db.Tbl_Personel.First(x => x.Id == 1).Ad;
            soyad1 = db.Tbl_Personel.First(x => x.Id == 1).Soyad;
            labelControl5.Text = db.Tbl_Personel.First(x => x.Id == 1).Tbl_Departman.Ad;
            labelControl7.Text = db.Tbl_Personel.First(x => x.Id == 1).Mail;
            labelControl4.Text = ad1 + " " + soyad1;
            //2.personel
            ad2 = db.Tbl_Personel.First(x => x.Id == 2).Ad;
            soyad2 = db.Tbl_Personel.First(x => x.Id == 2).Soyad;
            labelControl12.Text = db.Tbl_Personel.First(x => x.Id == 2).Tbl_Departman.Ad;
            labelControl10.Text = db.Tbl_Personel.First(x => x.Id == 2).Mail;
            labelControl14.Text = ad2 + " " + soyad2;
            //3.personel
            ad3 = db.Tbl_Personel.First(x => x.Id == 3).Ad;
            soyad3 = db.Tbl_Personel.First(x => x.Id == 3).Soyad;
            labelControl18.Text = db.Tbl_Personel.First(x => x.Id == 3).Tbl_Departman.Ad;
            labelControl16.Text = db.Tbl_Personel.First(x => x.Id == 3).Mail;
            labelControl20.Text = ad3 + " " + soyad3;
            //4.personel
            ad4 = db.Tbl_Personel.First(x => x.Id == 4).Ad;
            soyad4 = db.Tbl_Personel.First(x => x.Id == 4).Soyad;
            labelControl24.Text = db.Tbl_Personel.First(x => x.Id == 4).Tbl_Departman.Ad;
            labelControl22.Text = db.Tbl_Personel.First(x => x.Id == 4).Mail;
            labelControl26.Text = ad4 + " " + soyad4;
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            Tbl_Personel t = new Tbl_Personel();
            t.Ad = txtad.Text;
            t.Soyad = txtsoyad.Text;
            t.Departman = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.Tbl_Personel.Add(t);
            db.SaveChanges();
            MessageBox.Show("Personel Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}
