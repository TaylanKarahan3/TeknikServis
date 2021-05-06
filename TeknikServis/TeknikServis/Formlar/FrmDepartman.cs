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
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        SqlConnection baglanti = new SqlConnection("Data Source=PHOENIX;Initial Catalog=DbTeknikServis;Integrated Security=True");

        void listele()
        {
            var degerler = from d in db.Tbl_Departman
                           select new
                           {
                               d.Id,
                               d.Ad,
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            listele();
            labelControl8.Text = db.Tbl_Departman.Count().ToString();
            labelControl10.Text = db.Tbl_Personel.Count().ToString();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select top 1 Departman from tbl_personel group by Tbl_Personel.Departman order by count(*) desc", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                labelControl12.Text = dr[0].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select top 1 Departman from tbl_personel group by Tbl_Personel.Departman order by count(*) asc", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                labelControl14.Text = dr2[0].ToString();
            }
            baglanti.Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtad.Text.Length <= 50 && txtad.Text != "")
            {
                Tbl_Departman d = new Tbl_Departman();
                d.Ad = txtad.Text;
                db.Tbl_Departman.Add(d);
                db.SaveChanges();
                MessageBox.Show("Departman Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            else
            {
                MessageBox.Show("Kayıt Yapılamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Cari Silinsin Mi?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                int id = int.Parse(txtid.Text);
                var deger = db.Tbl_Departman.Find(id);
                db.Tbl_Departman.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Departman Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
            }
            else
            {
                listele();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtid.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtad.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            var deger = db.Tbl_Departman.Find(id);
            deger.Ad = txtad.Text;
            db.SaveChanges();
            MessageBox.Show("Departman Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}
