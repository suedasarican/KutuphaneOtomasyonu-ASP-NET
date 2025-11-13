<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="KutuphaneProjesi.Giris" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Kullanıcı Girişi</h2>
    
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
        <asp:Button ID="btnGiris" runat="server" Text="Giriş Yap" OnClick="btnGiris_Click" CssClass="aspNetButton" />
    </div>
    <br />
    <div>
        <asp:Label ID="lblMesaj" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>

</asp:Content>