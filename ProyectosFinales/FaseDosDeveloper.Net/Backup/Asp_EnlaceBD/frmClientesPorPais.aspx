<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmClientesPorPais.aspx.cs" Inherits="Asp_EnlaceBD.frmClientesPorPais" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:DropDownList ID="DdlPaises" runat="server" AutoPostBack="True" 
        onselectedindexchanged="DdlPaises_SelectedIndexChanged">
</asp:DropDownList>
<asp:Label ID="Label1" runat="server" Text="Seleccione Un Pais"></asp:Label>
<br />
<asp:GridView ID="gvClientes" runat="server">
</asp:GridView>
</asp:Content>
