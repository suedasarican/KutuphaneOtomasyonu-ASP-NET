<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UyeOl.aspx.cs" Inherits="KutuphaneProjesi.Uyeol" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Yeni Kullanıcı Kaydı</h2>
    
    <div>
        Kullanıcı Adı:
        <asp:TextBox ID="txtKulAd" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        Şifre:
        <asp:TextBox ID="txtSifre" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" OnClick="btnKaydet_Click" />
    </div>
    <br />
    <div>
        <asp:Label ID="lblMesaj" runat="server" Text=""></asp:Label>
    </div>

</asp:Content>
