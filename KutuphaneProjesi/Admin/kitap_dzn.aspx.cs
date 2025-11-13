using System;
using System.Data.SqlClient;
using System.Web.UI; 

namespace KutuphaneProjesi.Admin
{
    public partial class kitap_dzn : System.Web.UI.Page
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=kutuphane; Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                
                string kitapID = Request.QueryString["id"];

                if (string.IsNullOrEmpty(kitapID))
                {
                    
                    Response.Redirect("AdminKitaplar.aspx");
                    return;
                }

                
                hdnKitapID.Value = kitapID;

    
                KitapBilgileriniYukle(kitapID);
            }
        }

        private void KitapBilgileriniYukle(string id)
        {
            try
            {
                baglan.Open();
                
                SqlCommand cmd = new SqlCommand("SELECT * FROM kitap WHERE ID = @KitapID", baglan);
                cmd.Parameters.AddWithValue("@KitapID", id);
                SqlDataReader dr = cmd.ExecuteReader();

                 if (dr.Read())
                {
                    
                    txtKitapAd.Text = dr["kitap"].ToString();
                    txtYazarAd.Text = dr["yazar"].ToString();
                    txtISBN.Text = dr["ISBN"].ToString();
                    txtYayinevi.Text = dr["yayinevi"].ToString();
                    txtTur.Text = dr["tur"].ToString();
                }
                else
                {
                   
                    lblMesaj.Text = "Kitap bulunamadı.";
                    lblMesaj.ForeColor = System.Drawing.Color.Red;
                    btnGuncelle.Enabled = false;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                lblMesaj.Text = "Veri yüklenirken hata: " + ex.Message;
                lblMesaj.ForeColor = System.Drawing.Color.Red;
            }
            finally
            {
                baglan.Close();
            }
        }

        
        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            
            string kitapID = hdnKitapID.Value;

          
            string kitapAdi = txtKitapAd.Text;
            string yazarAdi = txtYazarAd.Text;
            string isbn = txtISBN.Text;
            string yayinevi = txtYayinevi.Text;
            string tur = txtTur.Text;

            
            string sorgu = "UPDATE kitap SET kitap = @KitapAd, yazar = @YazarAd, ISBN = @ISBN, yayinevi = @Yayinevi, tur = @Tur WHERE ID = @KitapID";

            try
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand(sorgu, baglan);

                
                cmd.Parameters.AddWithValue("@KitapAd", kitapAdi);
                cmd.Parameters.AddWithValue("@YazarAd", yazarAdi);
                cmd.Parameters.AddWithValue("@ISBN", isbn);
                cmd.Parameters.AddWithValue("@Yayinevi", yayinevi);
                cmd.Parameters.AddWithValue("@Tur", tur);
                cmd.Parameters.AddWithValue("@KitapID", kitapID);

               
                int sonuc = cmd.ExecuteNonQuery(); 

                if (sonuc > 0)
                {
                    lblMesaj.Text = "Kitap bilgileri başarıyla güncellendi.";
                    lblMesaj.ForeColor = System.Drawing.Color.Green;
                    
                    Response.AddHeader("REFRESH", "2;URL=AdminKitaplar.aspx");
                }
                else
                {
                    lblMesaj.Text = "Güncelleme sırasında bir hata oluştu veya hiçbir bilgi değiştirilmedi.";
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