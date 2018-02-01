<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HospitalFOC.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <div id="imagen_bienvenida">
        <img src="/images/home.jpg" />
    </div>
    <h2 style="margin-top:25px;">Login de Usuarios</h2>
    <p>Si ya es usuario de nuestra aplicación, introduzca sus datos para acceder.</p>
    <p>Si todavía no se ha registrado, puede hacerlo en el botón habilitado para ello en la parte superior.</p>
    <table>
        <tr>
            <td>Usuario*:</td>
            <td> <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Contraseña*:</td>
            <td> <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
     </table>
     <p>*Campos obligatorios.</p>
     <asp:Button ID="Enviar" runat="server" Text="Enviar" OnClick="Enviar_Click" />
    <br /><br />
    <asp:Label ID="lblMensaje_login" runat="server" Text="" Style="font-weight: 700; font-size: large; color: #000066"></asp:Label><br />



</asp:Content>
