using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class FrmAnaModul : Form
    {
        public FrmAnaModul()
        {
            InitializeComponent();
        }
        Formlar.FrmUrunListesi fr1;
        private void btnurunlistesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr1==null || fr1.IsDisposed)
            {
                fr1 = new Formlar.FrmUrunListesi();
                fr1.MdiParent = this;
                fr1.Show();
            }
        }
        Formlar.FrmYeniUrun frr2;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frr2 == null || frr2.IsDisposed)
            {
                frr2 = new Formlar.FrmYeniUrun();
                frr2.Show();
            }
        }
        Formlar.FrmKategori fr2;
        private void btnkategoriliste_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null || fr2.IsDisposed)
            {
                fr2 = new Formlar.FrmKategori();
                fr2.MdiParent = this;
                fr2.Show();
            }
        }
        Formlar.FrmYeniKategori frr;
        private void btnkategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frr == null || frr.IsDisposed)
            {
                frr = new Formlar.FrmYeniKategori();
                frr.Show();
            }
        }
        Formlar.FrmUrunIstatistik fr3;
        private void btnurunistatistikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null || fr3.IsDisposed)
            {
                fr3 = new Formlar.FrmUrunIstatistik();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }
        Formlar.FrmMarkalar fr4;
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr4==null || fr4.IsDisposed)
            {
                fr4 = new Formlar.FrmMarkalar();
                fr4.MdiParent = this;
                fr4.Show();
            }
        }
        Formlar.FrmCariListesi fr5;
        private void btncarilistesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5 == null || fr5.IsDisposed)
            {
                fr5 = new Formlar.FrmCariListesi();
                fr5.MdiParent = this;
                fr5.Show();
            }
        }
        Formlar.FrmCariIller fr6;
        private void btncariiller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr6 == null || fr6.IsDisposed)
            {
                fr6 = new Formlar.FrmCariIller();
                fr6.MdiParent = this;
                fr6.Show();
            }
        }
        Formlar.FrmCariEkle frr3;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frr3 == null || frr3.IsDisposed)
            {
                frr3 = new Formlar.FrmCariEkle();
                frr3.Show();
            }
        }
        Formlar.FrmDepartman fr7;
        private void btndepartmanlistesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr7 == null || fr7.IsDisposed)
            {
                fr7 = new Formlar.FrmDepartman();
                fr7.MdiParent = this;
                fr7.Show();
            }
        }
        Formlar.FrmYeniDepartman frr4;
        private void btnyenidepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frr4 == null || frr4.IsDisposed)
            {
                frr4 = new Formlar.FrmYeniDepartman();
                frr4.Show();
            }
        }
        Formlar.FrmPersonel fr8;
        private void btnpersonellistesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr8 == null || fr8.IsDisposed)
            {
                fr8 = new Formlar.FrmPersonel();
                fr8.MdiParent = this;
                fr8.Show();
            }
        }
        private void btnhesapmakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }
        Formlar.FrmKurlar fr9;
        private void btndovizkurları_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr9 == null || fr9.IsDisposed)
            {
                fr9 = new Formlar.FrmKurlar();
                fr9.MdiParent = this;
                fr9.Show();
            }
        }

        private void btnword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void btnexcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }
        Formlar.FrmYoutube fr10;
        private void btnyoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr10 == null || fr10.IsDisposed)
            {
                fr10 = new Formlar.FrmYoutube();
                fr10.MdiParent = this;
                fr10.Show();
            }
        }
        Formlar.FrmNotlar fr11;
        private void btnnotlistesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr11 == null || fr11.IsDisposed)
            {
                fr11 = new Formlar.FrmNotlar();
                fr11.MdiParent = this;
                fr11.Show();
            }
        }
        Formlar.FrmArizaListesi fr12;
        private void btnarizaliurunlistesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr12 == null || fr12.IsDisposed)
            {
                fr12 = new Formlar.FrmArizaListesi();
                fr12.MdiParent = this;
                fr12.Show();
            }
        }
        Formlar.FrmUrunSatis frr5;
        private void btnurunsatisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frr5 == null || frr5.IsDisposed)
            {
                frr5 = new Formlar.FrmUrunSatis();
                frr5.Show();
            }
        }
        Formlar.FrmSatislar fr13;
        private void btnsatislistesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr13 == null || fr13.IsDisposed)
            {
                fr13 = new Formlar.FrmSatislar();
                fr13.MdiParent = this;
                fr13.Show();
            }
        }
        Formlar.FrmArizaliUrunKaydi frr8;
        private void btnyeniarizaliurun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frr8 == null || frr8.IsDisposed)
            {
                frr8 = new Formlar.FrmArizaliUrunKaydi();
                frr8.Show();
            }
        }
        Formlar.FrmArizaDetaylar frr6;
        private void btnurunaciklama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frr6 == null || frr6.IsDisposed)
            {
                frr6 = new Formlar.FrmArizaDetaylar();
                frr6.Show();
            }
        }
        Formlar.FrmArizaliUrunDetayListesi fr14;
        private void btnarizaliurundetaylari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr14 == null || fr14.IsDisposed)
            {
                fr14 = new Formlar.FrmArizaliUrunDetayListesi();
                fr14.MdiParent = this;
                fr14.Show();
            }
        }
        Formlar.FrmQrKod frr7;
        private void btnqrkod_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frr7 == null || frr7.IsDisposed)
            {
                frr7 = new Formlar.FrmQrKod();
                frr7.Show();
            }
        }
        Formlar.FrmFaturaListesi fr15;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr15 == null || fr15.IsDisposed)
            {
                fr15 = new Formlar.FrmFaturaListesi();
                fr15.MdiParent = this;
                fr15.Show();
            }
        }
        Formlar.FrmFaturaKalem fr16;
        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr16 == null || fr16.IsDisposed)
            {
                fr16 = new Formlar.FrmFaturaKalem();
                fr16.MdiParent = this;
                fr16.Show();
            }
        }
        Formlar.FrmFaturaKalemDetayları fr17;
        private void btndetaylifaturasorgulama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr17 == null || fr17.IsDisposed)
            {
                fr17 = new Formlar.FrmFaturaKalemDetayları();
                fr17.MdiParent = this;
                fr17.Show();
            }
        }

        Formlar.FrmGauge fr18;
        private void btnhakkimizda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr18 == null || fr18.IsDisposed)
            {
                fr18 = new Formlar.FrmGauge();
                fr18.MdiParent = this;
                fr18.Show();
            }
        }
        Formlar.FrmHarita fr19;
        private void btnharitalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr19 == null || fr19.IsDisposed)
            {
                fr19 = new Formlar.FrmHarita();
                fr19.MdiParent = this;
                fr19.Show();
            }
        }

        private void btnraporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmRapor frm = new Formlar.FrmRapor();
            frm.Show();
        }
        Formlar.FrmAnaSayfa frm;
        private void FrmAnaModul_Load(object sender, EventArgs e)
        {
            if (frm == null || frm.IsDisposed)
            {
                frm = new Formlar.FrmAnaSayfa();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barButtonItem3_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm == null || frm.IsDisposed)
            {
                frm = new Formlar.FrmAnaSayfa();
                frm.MdiParent = this;
                frm.Show();
            }
        }
        İletişim.FrmRehber fr20;
        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr20 == null || fr20.IsDisposed)
            {
                fr20 = new İletişim.FrmRehber();
                fr20.MdiParent = this;
                fr20.Show();
            }
        }
        İletişim.FrmGelenMesajlar fr21;

        private void btnmesajlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr21 == null || fr21.IsDisposed)
            {
                fr21 = new İletişim.FrmGelenMesajlar();
                fr21.MdiParent = this;
                fr21.Show();
            }
        }
        İletişim.FrmMail fr22;

        private void btnyenimail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr22 == null || fr22.IsDisposed)
            {
                fr22 = new İletişim.FrmMail();
                fr22.Show();
            }
        }
    }
}
