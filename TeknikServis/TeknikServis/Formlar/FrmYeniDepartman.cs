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
    public partial class FrmYeniDepartman : Form
    {
        public FrmYeniDepartman()
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
            if (txtad.Text.Length <= 50 && txtad.Text != "")
            {
                Tbl_Departman d = new Tbl_Departman();
                d.Ad = txtad.Text;
                db.Tbl_Departman.Add(d);
                db.SaveChanges();
                MessageBox.Show("Yeni Departman Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Departman Kaydedilemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
