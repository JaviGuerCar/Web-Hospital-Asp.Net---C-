<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Modificar_Medico.aspx.cs" Inherits="HospitalFOC.Modificar_Medico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <h2>Modificar Datos Personales del Médico</h2>
   <table style="float:left; margin-right:10px;">
       <tr>
            <td class="auto-style2">Id Usuario: </td>
            <td>
                <asp:TextBox ID="txtId_medico" runat="server" Enabled="False" width="300px" BackColor="#CCCCCC"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Nombre*: </td>
            <td>
                <asp:TextBox ID="txtNombre_medico" runat="server" width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Apellidos*:</td>
            <td>
                <asp:TextBox ID="txtApellidos_medico" runat="server" width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">DNI*:</td>
            <td>
                <asp:TextBox ID="txtDNI_medico" runat="server" width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">E-mail*:</td>
            <td>
                <asp:TextBox ID="txtEmail_medico" runat="server" width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Teléfono*:</td>
            <td>
                <asp:TextBox ID="txtTelefono_medico" runat="server" width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Especialidad:</td>
            <td>
                <asp:TextBox ID="txtEspecialidad_medico" runat="server" width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Usuario*:</td>
            <td>
                <asp:TextBox ID="txtUsuario_medico" runat="server" width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Password*:</td>
            <td>
                <asp:TextBox ID="txtPassword_medico" runat="server" width="300px"></asp:TextBox>
            </td>
        </tr>
    </table>

    <br />
    <br />
    <div id="mensaje" style="clear:both;">
        <p>* Campos obligatorios</p><asp:Label ID="lblMensaje_modificar_medico" runat="server" Text="" Style="font-weight: 700; font-size: large; color: #000066"></asp:Label><br />
    </div>
    <asp:Button ID="Modif_Medico" runat="server" Text="Modificar" OnClick="Modif_Medico_Click"/>
    <br />
    <br />
</asp:Content>
