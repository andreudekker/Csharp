

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmCaptcha.aspx.cs" Inherits="Asp_EnlaceBD.frmCaptcha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .style1
    {
        width: 100%;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table class="style1">
    <tr>
        <td>
            <asp:Image ID="imgCaptcha" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="btnRefrescarImagen" runat="server" 
                onclick="btnRefrescarImagen_Click" Text="Refrescar Imagen" />
            <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
            <asp:HiddenField ID="hiddenLetra" runat="server" />
            <asp:Button ID="btnValidar" runat="server" onclick="btnValidar_Click" 
                Text="Validar" />
        </td>
      
    </tr>
</table>
</asp:Content>
