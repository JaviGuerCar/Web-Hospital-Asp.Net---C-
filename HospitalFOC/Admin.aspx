<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="HospitalFOC.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Menu" runat="server">
      <ul>
                    <li><a runat="server" href="/Default.aspx">Inicio</a></li>
                    <li><a runat="server" href="~/Administracion/Paciente_Admin.aspx">Pacientes</a></li>
                    <li><a runat="server" href="~/Administracion/Medico_Admin.aspx">Médicos</a></li>
                    <li><a runat="server" href="~/Administracion/Citas_Admin.aspx">Citas</a></li>
                    <li><a runat="server" href="/Contacto.aspx">Contacto</a></li>
                </ul>
                
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
</asp:Content>
