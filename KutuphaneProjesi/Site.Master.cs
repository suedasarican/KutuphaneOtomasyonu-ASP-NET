using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KutuphaneProjesi
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (Session["KullaniciAd"] != null)
            {
                
                lblKullanici.Text = "Hoşgeldin, " + Session["KullaniciAd"].ToString();

                btnLogout.Visible = true;          
                lnkGiris.Visible = false;          
                lnkSifreDegistir.Visible = true;   

          
                if (Session["KullaniciYetki"] != null && Session["KullaniciYetki"].ToString() == "admin")
                {
                    pnlAdminLink.Visible = true;
                }
                else
                {
                    pnlAdminLink.Visible = false;
                }
            }
            else
            {
        
                lblKullanici.Text = "Hoşgeldin, Misafir";

                btnLogout.Visible = false;        
                lnkGiris.Visible = true;           
                lnkSifreDegistir.Visible = false;  
                pnlAdminLink.Visible = false;      
            }
        }


        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Giris.aspx"); 
        }
    }
}