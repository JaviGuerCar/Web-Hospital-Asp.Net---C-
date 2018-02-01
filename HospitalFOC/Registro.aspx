<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="HospitalFOC.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipal" runat="server">


        <h2>Registro de nuevo usuario</h2>
    <table>
        <tr>
            <td class="auto-style2">Nombre*: </td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server" width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Apellidos*:</td>
            <td>
                <asp:TextBox ID="txtApellidos" runat="server" width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">DNI*:</td>
            <td>
                <asp:TextBox ID="txtDNI" runat="server" width="300px"></asp:TextBox>
            </td>   
        </tr>
        <tr>
            <td class="auto-style2">E-mail*:</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Teléfono*:</td>
            <td>
                <asp:TextBox ID="txtTelefono" runat="server" width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">CP:</td>
            <td>
                <asp:TextBox ID="txtCP" runat="server" width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Dirección:</td>
            <td>
                <asp:TextBox ID="txtDireccion" runat="server" width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Población:</td>
            <td>
                <asp:TextBox ID="txtPoblacion" runat="server" width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Provincia:</td>
            <td>
                <asp:TextBox ID="txtProvincia" runat="server" width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Edad*:</td>
            <td>
                <asp:TextBox ID="txtEdad" runat="server" width="300px"></asp:TextBox>
            </td>           
        </tr>
        <tr>
            <td class="auto-style2">Usuario*:</td>
            <td>
                <asp:TextBox ID="txtUsuario" runat="server" width="300px"></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td class="auto-style2">Password*:</td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" width="300px"></asp:TextBox>
            </td>
            
        </tr>

    </table>
    <p>
        *Campos obligatorios.&nbsp&nbsp
        <asp:Label ID="lblMensaje_registro" runat="server" Text="" Style="font-weight: 700; font-size: large; color: #000066"></asp:Label><br />
    </p>
    <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click"/>
    <asp:Button ID="btnBorrar" runat="server" Text="Borrar" OnClick="btnBorrar_Click"/><br /><br />

</asp:Content>
