<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AdminUyeDuzenle.aspx.cs" Inherits="KutuphaneProjesi.Admin.AdminUyeDuzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h3>Üye Bilgilerini Düzenle</h3>
    
    <div style="width:300px;">
        <label>Kullanıcı Adı:</label>
        <asp:TextBox ID="txtKulad" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        
        <label>Şifre:</label>
        <asp:TextBox ID="txtSifre" runat="server" CssClass="form-control"></asp:TextBox>
        <br />

        <label>Yetki:</label>
        <asp:DropDownList ID="ddlYetki" runat="server" Height="30px" Width="100%">
            <asp:ListItem Value="user">Normal Üye</asp:ListItem>
            <asp:ListItem Value="admin">Yönetici</asp:ListItem>
        </asp:DropDownList>
        <br /><br />

        <label>Hesap Durumu (Engelleme):</label>
        <asp:DropDownList ID="ddlDurum" runat="server" Height="30px" Width="100%">
            <asp:ListItem Value="Aktif">Aktif</asp:ListItem>
            <asp:ListItem Value="Pasif">Pasif (Dondurulmuş)</asp:ListItem>
            <asp:ListItem Value="Engelli">Engelli (Giriş Yapamaz)</asp:ListItem>
        </asp:DropDownList>
        <br /><br />

        <asp:Button ID="btnGuncelle" runat="server" Text="Bilgileri Güncelle" OnClick="btnGuncelle_Click" BackColor="#627D98" ForeColor="White" Height="40px" Width="100%" />
        <br />
        <asp:Label ID="lblMesaj" runat="server" Text=""></asp:Label>
    </div>

</asp:Content>