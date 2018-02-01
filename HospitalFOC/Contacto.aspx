<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HospitalFOC.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    
    <div id="imagen_bienvenida">
        <img src="/images/home.jpg" />
    </div>
    <h2 style="margin-top:25px;">Contacto</h2>

        <section class="contact">
        <header>
            <h3>Teléfono:</h3>
        </header>
        <p>
            <span class="label">Principal:</span>
            <span>425.555.0100</span>
        </p>
        <p>
            <span class="label">Fuera del horario laboral:</span>
            <span>425.555.0199</span>
        </p>
    </section>

    <section class="contact">
        <header>
            <h3>Correo electrónico:</h3>
        </header>
        <p>
            <span class="label">Soporte técnico:</span>
            <span><a href="mailto:Support@example.com">Support@example.com</a></span>
        </p>

        <p>
            <span class="label">General:</span>
            <span><a href="mailto:General@example.com">General@example.com</a></span>
        </p>
    </section>

    <section class="contact">
        <header>
            <h3>Dirección:</h3>
        </header>
        <p>
            One Microsoft Way<br />
            Redmond, WA 98052-6399
        </p>
    </section>
</asp:Content>
