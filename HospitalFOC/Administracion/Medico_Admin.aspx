<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Medico_Admin.aspx.cs" Inherits="HospitalFOC.Administracion.Medico_Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style2 {
            width: 135px;
            text-align: right;
        }

    </style>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <h2>Administración de Médicos</h2>
    <div id="consulta_Medico">
            <h4>Introduzca el DNI del médico que desee consultar, modificar o eliminar su información</h4>
        <table>
            <tr>
                <td style="text-align:right; width:122px;"> DNI*:</td>
                <td style="width:100px;">
                    <asp:TextBox ID="txtDNI_Consulta" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
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
            <td class="auto-style2">Especialidad*:</td>
            <td>
                <asp:TextBox ID="txtEspecialidad" runat="server" width="300px"></asp:TextBox>
            </td>
        </tr>
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
        <asp:Label ID="lblMensaje_medico" runat="server" Text="" Style="font-weight: 700; font-size: large; color: #000066"></asp:Label>
    </p>
<p>
        <asp:Button ID="btnNuevoMedico" runat="server" Text="Nuevo" OnClick="btnNuevoMedico_Click" />
        <asp:Button ID="btnConsultarMedico" runat="server" OnClick="btnConsultarMedico_Click" Text="Consultar" />
        <asp:Button ID="btnModificarMedico" runat="server" Text="Modificar" OnClick="btnModificarMedico_Click" />
        <asp:Button ID="btnEliminarMedico" runat="server" Text="Eliminar" OnClick="btnEliminarMedico_Click" />
        <asp:Button ID="btn_LimpiarMedico" runat="server" Text="Limpiar" OnClick="btn_LimpiarMedico_Click" />
    </p>
    <p>

        <asp:GridView ID="GVMedico" runat="server" AutoGenerateColumns="False" DataKeyNames="id_medico" DataSourceID="SqlDataSource1" EmptyDataText="No hay registros de datos para mostrar." AllowPaging="True" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <Columns>
                <asp:BoundField DataField="id_medico" HeaderText="id_medico" ReadOnly="True" SortExpression="id_medico" />
                <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                <asp:BoundField DataField="apellidos" HeaderText="apellidos" SortExpression="apellidos" />
                <asp:BoundField DataField="dni" HeaderText="dni" SortExpression="dni" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:BoundField DataField="teléfono" HeaderText="teléfono" SortExpression="teléfono" />
                <asp:BoundField DataField="especialidad" HeaderText="especialidad" SortExpression="especialidad" />
                <asp:BoundField DataField="usuario" HeaderText="usuario" SortExpression="usuario" />
                <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CitasConnectionString1 %>" DeleteCommand="DELETE FROM [Medico] WHERE [id_medico] = @id_medico" InsertCommand="INSERT INTO [Medico] ([nombre], [apellidos], [dni], [email], [teléfono], [especialidad], [usuario], [password]) VALUES (@nombre, @apellidos, @dni, @email, @teléfono, @especialidad, @usuario, @password)" ProviderName="<%$ ConnectionStrings:CitasConnectionString1.ProviderName %>" SelectCommand="SELECT [id_medico], [nombre], [apellidos], [dni], [email], [teléfono], [especialidad], [usuario], [password] FROM [Medico]" UpdateCommand="UPDATE [Medico] SET [nombre] = @nombre, [apellidos] = @apellidos, [dni] = @dni, [email] = @email, [teléfono] = @teléfono, [especialidad] = @especialidad, [usuario] = @usuario, [password] = @password WHERE [id_medico] = @id_medico">
            <DeleteParameters>
                <asp:Parameter Name="id_medico" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="nombre" Type="String" />
                <asp:Parameter Name="apellidos" Type="String" />
                <asp:Parameter Name="dni" Type="String" />
                <asp:Parameter Name="email" Type="String" />
                <asp:Parameter Name="teléfono" Type="String" />
                <asp:Parameter Name="especialidad" Type="String" />
                <asp:Parameter Name="usuario" Type="String" />
                <asp:Parameter Name="password" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="nombre" Type="String" />
                <asp:Parameter Name="apellidos" Type="String" />
                <asp:Parameter Name="dni" Type="String" />
                <asp:Parameter Name="email" Type="String" />
                <asp:Parameter Name="teléfono" Type="String" />
                <asp:Parameter Name="especialidad" Type="String" />
                <asp:Parameter Name="usuario" Type="String" />
                <asp:Parameter Name="password" Type="String" />
                <asp:Parameter Name="id_medico" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>

    </p>

</asp:Content>