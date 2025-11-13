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
            // Kullanıcı giriş yapmış mı?
            if (Session["KullaniciAd"] != null)
            {
                lblKullanici.Text = "Hoşgeldin, " + Session["KullaniciAd"].ToString();
                btnLogout.Visible = true;

                // KİLİT NOKTA: Eğer giren kişi ADMIN ise, Panel linkini görünür yap
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
                pnlAdminLink.Visible = false; // Giriş yapmayan admin linkini göremez
            }
        }

        // Çıkış butonuna basılınca çalışacak kod
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon(); // Tüm oturum bilgilerini sil (çıkış yap)
            Response.Redirect("Giris.aspx"); // Giriş sayfasına yönlendir
        }
    }
}