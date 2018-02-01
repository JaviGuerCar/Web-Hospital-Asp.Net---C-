<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Medico.aspx.cs" Inherits="HospitalFOC.Medico1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <h2>Datos Personales del Médico</h2>
    <table>
        <tr>
            <td class="auto-style2">ID Usuario: </td>
            <td>
                <asp:TextBox ID="txtId_medico_datos" runat="server" width="300px" Enabled="False" BackColor="#CCCCCC"></asp:TextBox>
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
            <td class="auto-style2">Especialidad*:</td>
            <td>
                <asp:TextBox ID="txtEspecialidad_datos" runat="server" width="300px" Enabled="False" BackColor="#CCCCCC"></asp:TextBox>
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
