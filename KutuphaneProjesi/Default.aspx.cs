using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace KutuphaneProjesi
{
    public partial class _Default : Page
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=kutuphane; Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
        
            if (!IsPostBack)
            {
                KitaplariListele();
            }
        }

       
        private void KitaplariListele()
        {
            try
            {
                baglan.Open(); 

         
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM kitap", baglan);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Repeater1.DataSource = dt;
                Repeater1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("Veritabanı bağlantı hatası: " + ex.Message);
            }
            finally
            {
                
                baglan.Close();
            }
        }
    }
}