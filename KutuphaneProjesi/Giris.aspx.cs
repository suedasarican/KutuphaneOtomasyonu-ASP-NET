using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace KutuphaneProjesi
{
    public partial class Giris : System.Web.UI.Page
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=kutuphane; Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                   
                SqlCommand cmd = new SqlCommand("SELECT * FROM kullanicilar WHERE kulad=@kulad AND sifre=@sifre", baglan);

                
                cmd.Parameters.AddWithValue("@kulad", txtKulAd.Text);
                cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);

                
                SqlDataReader dr = cmd.ExecuteReader();

                
                if (dr.Read())
                {
                    string durum = dr["durum"].ToString();

                    if (durum == "Engelli" || durum == "Pasif")
                    {
                        lblMesaj.Text = "Hesabınız askıya alınmıştır. Yöneticinizle görüşün.";
                        return;
                    }

                    Session["KullaniciID"] = dr["ID"].ToString();
                    Session["KullaniciYetki"] = dr["yetki"].ToString();
                    Session["KullaniciAd"] = dr["kulad"].ToString();

                    
                    if (dr["yetki"].ToString() == "admin")
                    {
                        
                         Response.Redirect("Admin/AdminAnasayfa.aspx");  
                }
                    else
                    {
                        
                        Response.Redirect("Default.aspx");
                    }
                }
                else
                {
                    
                     lblMesaj.Text = "Kullanıcı adı veya şifre hatalı!"; 
            }

                dr.Close(); 
            }
            catch (Exception ex)
            {
                lblMesaj.Text = "Hata: " + ex.Message;
            }
            finally
            {
                baglan.Close();
            }
        }
    }
}
