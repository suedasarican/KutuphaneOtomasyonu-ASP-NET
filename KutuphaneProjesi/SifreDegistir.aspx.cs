using System;
using System.Data.SqlClient; // SQL kütüphanesini unutma

namespace KutuphaneProjesi
{
    public partial class SifreDegistir : System.Web.UI.Page
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=kutuphane; Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            // Giriş yapmamış kişi şifre değiştiremez
            if (Session["KullaniciID"] == null)
            {
                Response.Redirect("Giris.aspx");
            }
        }

        protected void btnDegistir_Click(object sender, EventArgs e)
        {
            string kullaniciID = Session["KullaniciID"].ToString();
            string eskiSifre = txtEskiSifre.Text;
            string yeniSifre = txtYeniSifre.Text;

            try
            {
                baglan.Open();

                // 1. ADIM: Eski şifre doğru mu kontrol et
                SqlCommand komutKontrol = new SqlCommand("SELECT * FROM kullanicilar WHERE ID=@id AND sifre=@eski", baglan);
                komutKontrol.Parameters.AddWithValue("@id", kullaniciID);
                komutKontrol.Parameters.AddWithValue("@eski", eskiSifre);

                SqlDataReader dr = komutKontrol.ExecuteReader();

                if (dr.Read()) // Eğer kayıt varsa eski şifre doğrudur
                {
                    dr.Close(); // Okuyucuyu kapat ki yeni sorgu yazabilelim

                    // 2. ADIM: Şifreyi Güncelle (UPDATE)
                    SqlCommand komutGuncelle = new SqlCommand("UPDATE kullanicilar SET sifre=@yeni WHERE ID=@id", baglan);
                    komutGuncelle.Parameters.AddWithValue("@yeni", yeniSifre);
                    komutGuncelle.Parameters.AddWithValue("@id", kullaniciID);

                    komutGuncelle.ExecuteNonQuery();

                    lblSonuc.Text = "Şifreniz başarıyla değiştirildi!";
                    lblSonuc.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblSonuc.Text = "Eski şifrenizi yanlış girdiniz.";
                    lblSonuc.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                lblSonuc.Text = "Hata: " + ex.Message;
            }
            finally
            {
                baglan.Close();
            }
        }
    }
}