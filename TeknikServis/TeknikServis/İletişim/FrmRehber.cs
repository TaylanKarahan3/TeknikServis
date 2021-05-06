using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.İletişim
{
    public partial class FrmRehber : Form
    {
        public FrmRehber()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmRehber_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.Tbl_Cari
                                       select new
                                       {
                                           x.Ad,
                                           x.Soyad,
                                           x.Telefon,
                                           x.Mail
                                       }).ToList();
        }
    }
}
