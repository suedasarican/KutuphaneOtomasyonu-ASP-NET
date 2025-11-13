<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AdminUyeler.aspx.cs" Inherits="KutuphaneProjesi.Admin.AdminUyeler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h2>Üye Yönetimi</h2>
    
    <table class="table table-bordered" style="width:100%">
        <tr style="background-color:#333; color:white;">
            <td>ID</td>
            <td>Kullanıcı Adı</td>
            <td>Yetki</td>
            <td>Durum</td>
            <td>İşlemler</td>
        </tr>

        <asp:Repeater ID="rpUyeler" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("ID") %></td>
                    <td><%# Eval("kulad") %></td>
                    <td><%# Eval("yetki") %></td>
                    <td><%# Eval("durum") %></td>
                    <td>
                        <a href="AdminUyeDuzenle.aspx?id=<%# Eval("ID") %>" class="btn btn-sm btn-warning">Düzenle / Engelle</a>
                        | 
                        <a href="AdminUyeSil.aspx?id=<%# Eval("ID") %>" onclick="return confirm('Bu üyeyi tamamen silmek istediğine emin misin?')" style="color:red;">Sil</a>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>

</asp:Content>