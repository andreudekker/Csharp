<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmLeerunXML.aspx.cs" Inherits="Asp_EnlaceBD.frmLeerunXML" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="btnGenerarXML" runat="server" onclick="btnGenerarXML_Click" 
    Text="GenerarXML" />
<asp:Button ID="btnLeerXML" runat="server" Text="LeerXML" 
        onclick="btnLeerXML_Click" />
    <br />
    <asp:GridView ID="gvProductos" runat="server">
    </asp:GridView>
</asp:Content>
