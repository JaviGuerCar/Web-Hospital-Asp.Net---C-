<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Paciente_Admin.aspx.cs" Inherits="HospitalFOC.Paciente_Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style2 {
            width: 135px;
            text-align: right;
        }

    </style>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <h2>Administración de Pacientes</h2>
    <div id="consulta_Paciente">
            <h4>Introduzca el DNI del paciente que desee consultar, modificar o eliminar su información</h4>
        <table>
            <tr>
                <td style="text-align:right; width:122px;"> DNI*:</td>
                <td style="width:100px;">
                    <asp:TextBox ID="txtDNI_Consulta" runat="server" Width="185px"></asp:TextBox>
                </td>
            </tr>
        </table>
    </div>
    <br />
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
                <asp:TextBox ID="txtPassword" runat="server" width="300px"></asp:TextBox>
            </td>
        </tr>

    </table>
    <p>
        *Campos obligatorios.&nbsp&nbsp
        <asp:Label ID="lblMensaje_paciente" runat="server" Text="" Style="font-weight: 700; font-size: large; color: #000066"></asp:Label><br />
    </p>

    <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
    <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClientClick="return confirm ('¿Está seguro de que desea borrar el cliente?')" OnClick="btnEliminar_Click" />
    <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" OnClick="btnLimpiar_Click" /><br />
    <br />
    <asp:GridView ID="GVPacientes" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" EmptyDataText="No hay registros de datos para mostrar." AllowPaging="True" AllowSorting="True" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4">
        <Columns>
            <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
            <asp:BoundField DataField="apellidos" HeaderText="Apellidos" SortExpression="apellidos" />
            <asp:BoundField DataField="dni" HeaderText="Dni" SortExpression="dni" />
            <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
            <asp:BoundField DataField="teléfono" HeaderText="Teléfono" SortExpression="teléfono" />
            <asp:BoundField DataField="cp" HeaderText="Cp" SortExpression="cp" />
            <asp:BoundField DataField="dirección" HeaderText="Dirección" SortExpression="dirección" />
            <asp:BoundField DataField="población" HeaderText="Población" SortExpression="población" />
            <asp:BoundField DataField="provincia" HeaderText="Provincia" SortExpression="provincia" />
            <asp:BoundField DataField="edad" HeaderText="Edad" SortExpression="edad" />
        </Columns>
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <SortedAscendingCellStyle BackColor="#FEFCEB" />
        <SortedAscendingHeaderStyle BackColor="#AF0101" />
        <SortedDescendingCellStyle BackColor="#F6F0C0" />
        <SortedDescendingHeaderStyle BackColor="#7E0000" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CitasConnectionString1 %>" SelectCommand="SELECT [nombre], [apellidos],[dni], [email], [teléfono], [cp], [dirección], [población], [provincia], [edad], [usuario],[password] FROM [Paciente]"></asp:SqlDataSource>
    <br />
</asp:Content>
