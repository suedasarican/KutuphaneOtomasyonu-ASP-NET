<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Iletisim.aspx.cs" Inherits="KutuphaneProjesi.Iletisim" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2>İletişim Bilgileri</h2>
    <p>Bizimle aşağıdaki bilgiler aracılığıyla iletişime geçebilirsiniz:</p>
    <address>
        <strong>Adres:</strong> İstanbul Medeniyet Üniversitesi Kütüphanesi, Güney Kampüs, Üsküdar/İstanbul<br />
        <strong>Telefon:</strong> 0216 280 XXXX<br />
        <strong>E-posta:</strong> kutuphane@medeniyet.edu.tr
    </address>
    <hr /> 
    <h2>İletişim Formu</h2>
    <p>Görüş ve önerileriniz için aşağıdaki formu kullanabilirsiniz (Bu form şu an sadece tasarımdır, gönderim yapmaz):</p>
    
    <div>
        <label for="<%=txtAdSoyad.ClientID %>">Ad Soyad:</label><br />
        <asp:TextBox ID="txtAdSoyad" runat="server" Width="300px"></asp:TextBox>
    </div>
    <br />
    <div>
        <label for="<%=txtEmail.ClientID %>">E-posta:</label><br />
        <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" Width="300px"></asp:TextBox>
    </div>
    <br />
    <div>
        <label for="<%=txtMesaj.ClientID %>">Mesajınız:</label><br />
        <asp:TextBox ID="txtMesaj" runat="server" TextMode="MultiLine" Rows="5" Width="300px"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Button ID="btnGonder" runat="server" Text="Gönder" /> 
     
    </div>

</asp:Content>
