<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SifreDegistir.aspx.cs" Inherits="KutuphaneProjesi.SifreDegistir" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Şifre Değiştir</h2>
    
    <div style="width: 300px; margin: 20px;">
        <label>Eski Şifreniz:</label><br />
        <asp:TextBox ID="txtEskiSifre" runat="server" TextMode="Password" Width="100%"></asp:TextBox>
        <br /><br />
        
        <label>Yeni Şifreniz:</label><br />
        <asp:TextBox ID="txtYeniSifre" runat="server" TextMode="Password" Width="100%"></asp:TextBox>
        <br /><br />
        
        <asp:Button ID="btnDegistir" runat="server" Text="Şifreyi Güncelle" OnClick="btnDegistir_Click" CssClass="aspNetButton" />
        <br /><br />
        
        <asp:Label ID="lblSonuc" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
