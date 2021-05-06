using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TeknikServisWeb.Entity;

namespace TeknikServisWeb
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
           /* var degerler = db.Tbl_UrunTakip.ToList();
            Repeater1.DataSource = degerler;
            Repeater1.DataBind();*/
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var degerler = db.Tbl_UrunTakip.Where(x => x.SeriNo == TextBox1.Text);
            Repeater1.DataSource = degerler.ToList();
            Repeater1.DataBind();
        }
    }
}