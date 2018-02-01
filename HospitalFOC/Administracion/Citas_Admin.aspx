<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Citas_Admin.aspx.cs" Inherits="HospitalFOC.Administracion.Citas_Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <h2>Solicitar Citas Médicas</h2>
    Médico:
    <br />
    <asp:ListBox ID="lbSelect_Medico" runat="server" Width="306px"></asp:ListBox>
    <br />
    <asp:Button ID="btnDisponibilidad" runat="server" OnClick="btnDisponibilidad_Click" Text="Comprobar disponibilidad" />
    <br /><br />
    Calendario:<asp:Calendar ID="Calendario" runat="server" OnDayRender="Calendar1_DayRender1"></asp:Calendar>
    <br />
    Asunto:<br />
    <asp:TextBox ID="txtAsunto" runat="server" Width="522px"></asp:TextBox>
    <br /><br />
    Descripción:<br />
    <asp:TextBox ID="txtDescripcion" runat="server" Height="97px" Width="522px" TextMode="MultiLine"></asp:TextBox>
    <br /><br />
    <asp:Button ID="btnInsertarCita" runat="server" OnClick="btnInsertarCita_Click" Text="Enviar" />
    <asp:Label ID="lblMensaje_citas" runat="server" Text="" Style="font-weight: 700; font-size: large; color: #000066"></asp:Label>
    <br />
    <br /><br />
</asp:Content>
