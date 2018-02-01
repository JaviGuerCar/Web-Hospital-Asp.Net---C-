using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalFOC
{
    public partial class Paciente_Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {

            if (txtDNI_Consulta.Text == "")
            {
                lblMensaje_paciente.Text = "Debe introducir un DNI del paciente que quiere consultar";
                txtDNI_Consulta.Focus();
                return;
            }

            if (!ADOPacientes.Pacientes.Existe_Paciente(txtDNI_Consulta.Text))
            {
                lblMensaje_paciente.Text = "El paciente no existe";
                txtDNI_Consulta.Focus();
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
                return;
            }

            ADOPacientes.DSPacientes.PacienteDataTable miPaciente = ADOPacientes.Pacientes.Consulta_Pacientes(txtDNI_Consulta.Text);
            foreach (DataRow row in miPaciente.Rows)
            {
                txtNombre.Text = row["nombre"].ToString();
                txtApellidos.Text = row["apellidos"].ToString();
                txtDNI.Text = row["dni"].ToString();
                txtEmail.Text = row["email"].ToString();
                txtTelefono.Text = row["teléfono"].ToString();
                txtCP.Text = row["cp"].ToString();
                txtDireccion.Text = row["dirección"].ToString();
                txtPoblacion.Text = row["población"].ToString();
                txtProvincia.Text = row["provincia"].ToString();
                txtEdad.Text = row["edad"].ToString();
                txtUsuario.Text = row["usuario"].ToString();
                txtPassword.Text = row["password"].ToString();
            }

            lblMensaje_paciente.Text = "Paciente consultado";
        }

 

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (!ADOPacientes.Pacientes.Existe_Paciente(txtDNI.Text))
            {
                lblMensaje_paciente.Text = "El DNI no existe";
                txtDNI.Focus();
                return;
            }

            if (txtNombre.Text == "")
            {
                lblMensaje_paciente.Text = "Debe introducir un nombre";
                txtNombre.Focus();
                return;
            }

            if (txtApellidos.Text == "")
            {
                lblMensaje_paciente.Text = "Debe introducir los apellidos";
                txtApellidos.Focus();
                return;
            }

            if (txtDNI.Text == "")
            {
                lblMensaje_paciente.Text = "Debe introducir el DNI";
                txtDNI.Focus();
                return;
            }

            if (txtEmail.Text == "")
            {
                lblMensaje_paciente.Text = "Debe introducir el e-mail";
                txtEmail.Focus();
                return;
            }

            if (txtEdad.Text == "")
            {
                lblMensaje_paciente.Text = "Debe introducir la edad";
                txtEdad.Focus();
                return;
            }

            if (txtUsuario.Text == "")
            {
                lblMensaje_paciente.Text = "Debe introducir un nombre de usuario";
                txtUsuario.Focus();
                return;
            }

            if (txtPassword.Text == "")
            {
                lblMensaje_paciente.Text = "Debe introducir una contraseña";
                txtPassword.Focus();
                return;
            }

            lblMensaje_paciente.Text = ADOPacientes.Pacientes.ActualizarPaciente(txtNombre.Text, txtApellidos.Text, txtDNI.Text, txtEmail.Text, txtTelefono.Text,
                txtCP.Text, txtDireccion.Text, txtPoblacion.Text, txtProvincia.Text, txtEdad.Text, txtUsuario.Text, txtPassword.Text);

            //actualizamos el GridView
            GVPacientes.DataBind();
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
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

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtDNI_Consulta.Text == "")
            {
                lblMensaje_paciente.Text = "Debe introducir un DNI del paciente que quiere eliminar";
                txtDNI_Consulta.Focus();
                return;
            }

            if (!ADOPacientes.Pacientes.Existe_Paciente(txtDNI_Consulta.Text))
            {
                lblMensaje_paciente.Text = "El paciente no existe";
                txtDNI_Consulta.Focus();
                return;
            }

            lblMensaje_paciente.Text = ADOPacientes.Pacientes.Eliminar_Paciente(txtDNI_Consulta.Text);

            //actualizamos el GridView
            GVPacientes.DataBind();

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