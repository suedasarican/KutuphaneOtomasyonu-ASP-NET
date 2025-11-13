using System;
using System.Data.SqlClient;
using System.Data;

namespace KutuphaneProjesi.Admin
{
    public partial class AdminUyeler : System.Web.UI.Page
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=kutuphane; Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UyeleriGetir();
            }
        }

        void UyeleriGetir()
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM kullanicilar", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            rpUyeler.DataSource = dt;
            rpUyeler.DataBind();
            baglan.Close();
        }
    }
}