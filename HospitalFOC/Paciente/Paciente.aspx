<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Paciente.aspx.cs" Inherits="HospitalFOC.Paciente1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <h2>Mis Datos Personales</h2>
    <table>
        <tr>
            <td class="auto-style2">ID Usuario*: </td>
            <td>
                <asp:TextBox ID="txtId_paciente_datos" runat="server" width="300px" Enabled="False" BackColor="#CCCCCC"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Nombre*: </td>
            <td>
                <asp:TextBox ID="txtNombre_datos" runat="server" width="300px" Enabled="False" BackColor="#CCCCCC"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Apellidos*:</td>
            <td>
                <asp:TextBox ID="txtApellidos_datos" runat="server" width="300px" Enabled="False" BackColor="#CCCCCC"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">DNI*:</td>
            <td>
                <asp:TextBox ID="txtDNI_datos" runat="server" width="300px" Enabled="False" BackColor="#CCCCCC"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">E-mail*:</td>
            <td>
                <asp:TextBox ID="txtEmail_datos" runat="server" width="300px" Enabled="False" BackColor="#CCCCCC"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Teléfono*:</td>
            <td>
                <asp:TextBox ID="txtTelefono_datos" runat="server" width="300px" Enabled="False" BackColor="#CCCCCC"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">CP:</td>
            <td>
                <asp:TextBox ID="txtCP_datos" runat="server" width="300px" Enabled="False" BackColor="#CCCCCC"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Dirección:</td>
            <td>
                <asp:TextBox ID="txtDireccion_datos" runat="server" width="300px" Enabled="False" BackColor="#CCCCCC"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Población:</td>
            <td>
                <asp:TextBox ID="txtPoblacion_datos" runat="server" width="300px" Enabled="False" BackColor="#CCCCCC"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Provincia:</td>
            <td>
                <asp:TextBox ID="txtProvincia_datos" runat="server" width="300px" Enabled="False" BackColor="#CCCCCC"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Edad*:</td>
            <td>
                <asp:TextBox ID="txtEdad_datos" runat="server" width="300px" Enabled="False" BackColor="#CCCCCC"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Usuario*:</td>
            <td>
                <asp:TextBox ID="txtUsuario_datos" runat="server" width="300px" Enabled="False" BackColor="#CCCCCC"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Password*:</td>
            <td>
                <asp:TextBox ID="txtPassword_datos" runat="server" width="300px" Enabled="False" BackColor="#CCCCCC"></asp:TextBox>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
