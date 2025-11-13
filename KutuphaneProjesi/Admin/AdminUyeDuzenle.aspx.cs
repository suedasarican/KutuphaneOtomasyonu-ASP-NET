using System;
using System.Data.SqlClient;

namespace KutuphaneProjesi.Admin
{
    public partial class AdminUyeDuzenle : System.Web.UI.Page
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=kutuphane; Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"];
                if (id != null)
                {
                    VerileriGetir(id);
                }
            }
        }

        void VerileriGetir(string id)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM kullanicilar WHERE ID=@id", baglan);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtKulad.Text = dr["kulad"].ToString();
                txtSifre.Text = dr["sifre"].ToString();
                ddlYetki.SelectedValue = dr["yetki"].ToString();

              
                if (dr["durum"] != DBNull.Value)
                    ddlDurum.SelectedValue = dr["durum"].ToString();
            }
            baglan.Close();
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            baglan.Open();

            SqlCommand cmd = new SqlCommand("UPDATE kullanicilar SET kulad=@ad, sifre=@sifre, yetki=@yetki, durum=@durum WHERE ID=@id", baglan);

            cmd.Parameters.AddWithValue("@ad", txtKulad.Text);
            cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);
            cmd.Parameters.AddWithValue("@yetki", ddlYetki.SelectedValue);
            cmd.Parameters.AddWithValue("@durum", ddlDurum.SelectedValue); 
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
            baglan.Close();

            Response.Redirect("AdminUyeler.aspx");
        }
    }
}