<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="KutuphaneProjesi._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Kütüphanedeki Kitaplar</h2>
    <table class="table table-bordered" style="width: 80%;">
        <tr style="background-color: #333; color: white;">
            <td><strong>ID</strong></td>
            <td><strong>Kitap Adı</strong></td>
            <td><strong>Yazar Adı</strong></td>
            <td><strong>Kitap Türü</strong></td>
        </tr>
        
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("ID") %></td>
                    <td><%# Eval("kitap") %></td>
                    <td><%# Eval("yazar") %></td>
                    <td><%# Eval("tur") %></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>

</asp:Content>