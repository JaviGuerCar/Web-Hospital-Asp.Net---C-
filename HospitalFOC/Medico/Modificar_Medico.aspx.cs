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
    public partial class Modificar_Medico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int medico_id = Convert.ToInt32(Session["Id_medico"]);

                ADOPacientes.DSPacientes.MedicoDataTable miMedico = ADOPacientes.Medicos.Mis_Datos_Medico(medico_id);
                foreach (DataRow row in miMedico.Rows)
                {
                    txtId_medico.Text = row["id_medico"].ToString();
                    txtNombre_medico.Text = row["nombre"].ToString();
                    txtApellidos_medico.Text = row["apellidos"].ToString();
                    txtDNI_medico.Text = row["dni"].ToString();
                    txtEmail_medico.Text = row["email"].ToString();
                    txtTelefono_medico.Text = row["teléfono"].ToString();
                    txtEspecialidad_medico.Text = row["especialidad"].ToString();
                    txtUsuario_medico.Text = row["usuario"].ToString();
                    txtPassword_medico.Text = row["password"].ToString();
                }
            }
        }

        protected void Modif_Medico_Click(object sender, EventArgs e)
        {

            if (txtNombre_medico.Text == "")
            {
                lblMensaje_modificar_medico.Text = "Debe introducir un nombre";
                txtNombre_medico.Focus();
                return;
            }

            if (txtApellidos_medico.Text == "")
            {
                lblMensaje_modificar_medico.Text = "Debe introducir los apellidos";
                txtApellidos_medico.Focus();
                return;
            }

            if (txtDNI_medico.Text == "")
            {
                lblMensaje_modificar_medico.Text = "Debe introducir el DNI";
                txtDNI_medico.Focus();
                return;
            }

            if (txtEmail_medico.Text == "")
            {
                lblMensaje_modificar_medico.Text = "Debe introducir el e-mail";
                txtEmail_medico.Focus();
                return;
            }

            if (txtEspecialidad_medico.Text == "")
            {
                lblMensaje_modificar_medico.Text = "Debe introducir la especialidad";
                txtEspecialidad_medico.Focus();
                return;
            }

            if (txtUsuario_medico.Text == "")
            {
                lblMensaje_modificar_medico.Text = "Debe introducir un nombre de usuario";
                txtUsuario_medico.Focus();
                return;
            }

            if (txtPassword_medico.Text == "")
            {
                lblMensaje_modificar_medico.Text = "Debe introducir una contraseña";
                txtPassword_medico.Focus();
                return;
            }

            lblMensaje_modificar_medico.Text = ADOPacientes.Medicos.Modificar_Medico(txtNombre_medico.Text, txtApellidos_medico.Text, txtDNI_medico.Text, txtEmail_medico.Text, txtTelefono_medico.Text,
                txtEspecialidad_medico.Text, txtUsuario_medico.Text, txtPassword_medico.Text, Convert.ToInt32(txtId_medico.Text));
        }
    }
}