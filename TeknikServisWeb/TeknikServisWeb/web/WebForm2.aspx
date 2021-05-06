<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="TeknikServisWeb.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Ürün Seri No" Font-Bold="True"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Ara" CssClass="btn-danger" OnClick="Button1_Click" />

    <table class="table table-bordered"; style="margin-top:15px">
        <tr>
            <th>Açıklama</th>
            <th>Tarih</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
        <tr>
            <td><%#Eval("Aciklama")%></td>
            <td><%#Eval("Tarih") %></td>
        </tr>
        </ItemTemplate>
        </asp:Repeater>
    </table>

</asp:Content>
