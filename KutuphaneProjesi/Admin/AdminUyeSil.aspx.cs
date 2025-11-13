using System;
using System.Data.SqlClient;

namespace KutuphaneProjesi.Admin
{
    public partial class AdminUyeSil : System.Web.UI.Page
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=kutuphane; Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            if (id != null)
            {
                baglan.Open();
              

                SqlCommand cmd = new SqlCommand("DELETE FROM kullanicilar WHERE ID=@id", baglan);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                baglan.Close();
            }
            Response.Redirect("AdminUyeler.aspx");
        }
    }
}