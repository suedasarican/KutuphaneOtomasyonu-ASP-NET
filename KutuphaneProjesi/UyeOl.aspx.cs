using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace KutuphaneProjesi
{
    public partial class Uyeol : System.Web.UI.Page
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=kutuphane; Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

  
        protected void btnKaydet_Click(object sender, EventArgs e)
        {
         
            string kullaniciAdi = txtKulAd.Text;
            string sifre = txtSifre.Text;

      
           
            string sorgu = "INSERT INTO kullanicilar (kulad, sifre, yetki) VALUES ('" + kullaniciAdi + "', '" + sifre + "', 'user')";

            try
            {
                baglan.Open(); 

               
                SqlCommand ekle = new SqlCommand(sorgu, baglan);

              
                int sonuc = ekle.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    lblMesaj.Text = "Kayıt başarıyla eklendi.";
                    lblMesaj.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblMesaj.Text = "Kayıt eklenirken bir hata oluştu.";
                    lblMesaj.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                lblMesaj.Text = "HATA: " + ex.Message;
                lblMesaj.ForeColor = System.Drawing.Color.Red;
            }
            finally
            {
                baglan.Close(); 
            }
        }
    }
}
