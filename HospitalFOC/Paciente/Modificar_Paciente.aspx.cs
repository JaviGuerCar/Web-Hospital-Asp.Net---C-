using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalFOC
{
    public partial class Modificar_Paciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int paciente_id = Convert.ToInt32(Session["Id_paciente"]);

                ADOPacientes.DSPacientes.PacienteDataTable miPaciente = ADOPacientes.Pacientes.Mis_Datos_Paciente(paciente_id);
                foreach (DataRow row in miPaciente.Rows)
                {
                    txtId_paciente.Text = row["id_paciente"].ToString();
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
            }

        }

        protected void Modif_Paciente_Click(object sender, EventArgs e)
        {
           
            if (txtNombre.Text == "")
            {
                lblMensaje_modificar_paciente.Text = "Debe introducir un nombre";
                txtNombre.Focus();
                return;
            }

            if (txtApellidos.Text == "")
            {
                lblMensaje_modificar_paciente.Text = "Debe introducir los apellidos";
                txtApellidos.Focus();
                return;
            }

            if (txtDNI.Text == "")
            {
                lblMensaje_modificar_paciente.Text = "Debe introducir el DNI";
                txtDNI.Focus();
                return;
            }

            if (txtEmail.Text == "")
            {
                lblMensaje_modificar_paciente.Text = "Debe introducir el e-mail";
                txtEmail.Focus();
                return;
            }

            if (txtEdad.Text == "")
            {
                lblMensaje_modificar_paciente.Text = "Debe introducir la edad";
                txtEdad.Focus();
                return;
            }

            if (txtUsuario.Text == "")
            {
                lblMensaje_modificar_paciente.Text = "Debe introducir un nombre de usuario";
                txtUsuario.Focus();
                return;
            }

            if (txtPassword.Text == "")
            {
                lblMensaje_modificar_paciente.Text = "Debe introducir una contraseña";
                txtPassword.Focus();
                return;
            }


            lblMensaje_modificar_paciente.Text = ADOPacientes.Pacientes.Modificar_Paciente(txtNombre.Text, txtApellidos.Text, txtDNI.Text, txtEmail.Text, txtTelefono.Text,
                txtCP.Text, txtDireccion.Text, txtPoblacion.Text, txtProvincia.Text, txtEdad.Text, txtUsuario.Text, txtPassword.Text, Convert.ToInt32(txtId_paciente.Text));


        }

    }
}