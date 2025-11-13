using System;
using System.Data.SqlClient;

namespace KutuphaneProjesi.Admin
{
    public partial class kitap_sil : System.Web.UI.Page
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=kutuphane; Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            
            string kitapID = Request.QueryString["id"];

            if (string.IsNullOrEmpty(kitapID))
            {
               
                Response.Redirect("AdminKitaplar.aspx");
                return; 
            }

            try
            {
                baglan.Open();
                
                SqlCommand cmd = new SqlCommand("DELETE FROM kitap WHERE ID = @KitapID", baglan);
                cmd.Parameters.AddWithValue("@KitapID", kitapID); 
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                
                Response.Write("Silme hatası: " + ex.Message);
               
                return;
            }
            finally
            {
                baglan.Close();
            }


            Response.Redirect("AdminKitaplar.aspx?sil=ok"); 
        }
    }
}