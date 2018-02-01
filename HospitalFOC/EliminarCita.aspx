<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="EliminarCita.aspx.cs" Inherits="HospitalFOC.EliminarCita" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <h2>Mis Citas Médicas</h2>
<table>
        <tr>
            <td class="auto-style2">ID Cita: </td>
            <td>
                <asp:TextBox ID="txtId_cita" runat="server" width="300px" Enabled="False" BackColor="#CCCCCC"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Fecha: </td>
            <td>
                <asp:TextBox ID="txtFecha_Cita" runat="server" width="300px" Enabled="False" BackColor="#CCCCCC"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Asunto:</td>
            <td>
                <asp:TextBox ID="txtAsunto_Cita" runat="server" width="300px" Enabled="False" BackColor="#CCCCCC"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Descripción:</td>
            <td>
                <asp:TextBox ID="txtDescripcion_Cita" runat="server" width="300px" Enabled="False" BackColor="#CCCCCC" Height="87px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
    <tr>
            <td class="auto-style2">Médico:</td>
            <td>
                <asp:TextBox ID="txt_Medico_Cita" runat="server" width="300px" Enabled="False" BackColor="#CCCCCC"></asp:TextBox>
            </td>
        </tr>
    </table>
  <br /><br />
    <asp:Button ID="btnEliminar_Cita" runat="server" Text="Eliminar Cita"  OnClientClick="return confirm ('¿Está seguro de que desea borrar la cita?')" OnClick="btnEliminar_Cita_Click" />
    <br /><br />
    <asp:Label ID="lblMensaje_eliminar_cita" runat="server" Text="" Style="font-weight: 700; font-size: large; color: #000066"></asp:Label><br />
    <br /><br />
</asp:Content>
