using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TeknikServisWeb.Entity;
namespace TeknikServisWeb.Entity
{
    public partial class Default : System.Web.UI.Page
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.Tbl_Hakkimizda.ToList();
            Repeater1.DataBind();

            Repeater2.DataSource = db.Tbl_Urun.ToList();
            Repeater2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Tbl_İletisim t = new Tbl_İletisim();
            t.AdSoyad = TextBox1.Text;
            t.Mail = TextBox2.Text;
            t.Konu = TextBox3.Text;
            t.Mesaj = TextBox4.Text;
            db.Tbl_İletisim.Add(t);
            db.SaveChanges();

        }
    }
}