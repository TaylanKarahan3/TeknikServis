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
    public partial class FrmYeniKategori : Form
    {
        public FrmYeniKategori()
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
            if (txtkategoriad.Text != "" && txtkategoriad.Text.Length <= 30)
            {
                Tbl_Kategori k = new Tbl_Kategori();
                k.Ad = txtkategoriad.Text;
                db.Tbl_Kategori.Add(k);
                db.SaveChanges();
                MessageBox.Show("Kategori Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kategori ad boş geçilemez ve 30 karakterden fazla olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}
