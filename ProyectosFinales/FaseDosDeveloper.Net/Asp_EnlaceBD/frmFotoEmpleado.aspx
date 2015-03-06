<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmFotoEmpleado.aspx.cs" Inherits="Asp_EnlaceBD.frmFotoEmpleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Selecciones Un Empleado"></asp:Label>
    <asp:DropDownList ID="ddlEmpleado" runat="server" AutoPostBack="True" 
        onselectedindexchanged="ddlEmpleado_SelectedIndexChanged">
    </asp:DropDownList>
    <asp:Image ID="imgEmpleado" runat="server" />
</asp:Content>
