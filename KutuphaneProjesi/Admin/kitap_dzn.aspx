<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="kitap_dzn.aspx.cs" Inherits="KutuphaneProjesi.Admin.kitap_dzn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Kitap Bilgilerini Düzenle</h2>

    <div>
        Kitap Adı:
        <asp:TextBox ID="txtKitapAd" runat="server" Width="300px"></asp:TextBox>
    </div>
    <br />
    <div>
        Yazar Adı:
        <asp:TextBox ID="txtYazarAd" runat="server" Width="300px"></asp:TextBox>
    </div>
    <br />
    <div>
        ISBN:
        <asp:TextBox ID="txtISBN" runat="server" Width="200px"></asp:TextBox>
    </div>
    <br />
    <div>
        Yayınevi:
        <asp:TextBox ID="txtYayinevi" runat="server" Width="200px"></asp:TextBox>
    </div>
    <br />
    <div>
        Türü:
        <asp:TextBox ID="txtTur" runat="server" Width="200px"></asp:TextBox>
    </div>
    <br />
    <div>
        
        <asp:HiddenField ID="hdnKitapID" runat="server" />
        <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" OnClick="btnGuncelle_Click" />
    </div>
    <br />
    <div>
        <asp:Label ID="lblMesaj" runat="server" Text=""></asp:Label>
    </div>
     <p><a href="AdminKitaplar.aspx">Geri Dön</a></p>

</asp:Content>
