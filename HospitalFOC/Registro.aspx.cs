using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace HospitalFOC
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {

            if (ADOPacientes.Pacientes.Existe_Paciente(txtDNI.Text))
            {
                lblMensaje_registro.Text = "El DNI introducido pertenece a otro usuario";
                txtDNI.Focus();
                return;
            }

            //Login_Usuario.loginIngresarPaciente(txtNombre.Text, txtApellidos.Text, txtDNI.Text, txtEmail.Text, txtTelefono.Text,
            //txtCP.Text, txtDireccion.Text, txtPoblacion.Text, txtProvincia.Text, txtEdad.Text, txtUsuario.Text, txtPassword.Text);

            lblMensaje_registro.Text = ADOPacientes.Pacientes.NuevoPaciente(txtNombre.Text, txtApellidos.Text, txtDNI.Text, txtEmail.Text, txtTelefono.Text,
                txtCP.Text, txtDireccion.Text, txtPoblacion.Text, txtProvincia.Text, txtEdad.Text, txtUsuario.Text, txtPassword.Text);


        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtDNI.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtCP.Text = "";
            txtDireccion.Text = "";
            txtPoblacion.Text = "";
            txtProvincia.Text = "";
            txtEdad.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";
        }

    }
}