<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Citas_Medico.aspx.cs" Inherits="HospitalFOC.Citas_Medico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <h2>Mis Citas Médicas</h2>
<table>
        <tr>
            <td class="auto-style2">ID Cita: </td>
            <td>
                <asp:TextBox ID="txtId_cita"  Text="No tiene ninguna cita asignada" runat="server" width="300px" Enabled="False" BackColor="#CCCCCC"></asp:TextBox>
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
            <td class="auto-style2">Paciente:</td>
            <td>
                <asp:TextBox ID="txt_Paciente_Cita" runat="server" width="300px" Enabled="False" BackColor="#CCCCCC"></asp:TextBox>
            </td>
        </tr>
   
    </table>
  <br /><br />
</asp:Content>
