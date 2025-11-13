<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AdminKitaplar.aspx.cs" Inherits="KutuphaneProjesi.Admin.AdminKitaplar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Kitap Yönetimi</h2>

    <p><a href="AdminKitapEkle.aspx">Yeni Kitap Ekle</a></p>

    <table class="table table-bordered" style="width: 100%;">
        <tr style="background-color: #333; color: white;">
            <td><strong>ID</strong></td>
            <td><strong>Kitap Adı</strong></td>
            <td><strong>Yazar Adı</strong></td>
            <td><strong>Sil</strong></td>
            <td><strong>Düzenle</strong></td>
        </tr>
        
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("ID") %></td>
                    <td><%# Eval("kitap") %></td>
                    <td><%# Eval("yazar") %></td>
                    
                   
                    <td><a href='kitap_sil.aspx?id=<%# Eval("ID") %>' onclick="return confirm('Bu kitabı silmek istediğinizden emin misiniz?');">Sil</a></td>
                    
                 
                    <td><a href='kitap_dzn.aspx?id=<%# Eval("ID") %>'>Düzenle</a></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>

</asp:Content>