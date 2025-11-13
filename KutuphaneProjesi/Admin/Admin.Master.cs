using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KutuphaneProjesi.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Session["KullaniciYetki"] == null || Session["KullaniciYetki"].ToString() != "admin")
            {
              
                Response.Redirect("~/Giris.aspx");
            }
            else
            {
               
                if (!IsPostBack)
                {
                    lblAdminAdi.Text = "Hoşgeldin, " + Session["KullaniciAd"].ToString();
                }
            }
        }
        // btnAdminCikis_Click eventi
        protected void btnAdminCikis_Click(object sender, EventArgs e)
        {
            Session.Abandon(); // Oturumu öldür
            Response.Redirect("~/Giris.aspx"); // Giriş sayfasına at
        }
    }
}