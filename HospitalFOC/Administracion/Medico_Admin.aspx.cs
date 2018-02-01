using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace HospitalFOC.Administracion
{
    public partial class Medico_Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultarMedico_Click(object sender, EventArgs e)
        {
            if (txtDNI_Consulta.Text == "")
            {
                lblMensaje_medico.Text = "Debe introducir un DNI del médico que quiere consultar";
                txtDNI_Consulta.Focus();
                return;
            }

            if (!ADOPacientes.Medicos.Existe_Medico(txtDNI_Consulta.Text))
            {
                lblMensaje_medico.Text = "El médico no existe";
                txtDNI_Consulta.Focus();
                txtNombre.Text = "";
                txtApellidos.Text = "";
                txtDNI.Text = "";
                txtEmail.Text = "";
                txtTelefono.Text = "";
                txtEspecialidad.Text = "";
                txtUsuario.Text = "";
                txtPassword.Text = "";
                return;
            }

            ADOPacientes.DSPacientes.MedicoDataTable miMedico = ADOPacientes.Medicos.Consulta_Medicos(txtDNI_Consulta.Text);
            foreach (DataRow row in miMedico.Rows)
            {
                txtNombre.Text = row["nombre"].ToString();
                txtApellidos.Text = row["apellidos"].ToString();
                txtDNI.Text = row["dni"].ToString();
                txtEmail.Text = row["email"].ToString();
                txtTelefono.Text = row["teléfono"].ToString();
                txtEspecialidad.Text = row["especialidad"].ToString();
                txtUsuario.Text = row["usuario"].ToString();
                txtPassword.Text = row["password"].ToString();
            }

            lblMensaje_medico.Text = "Médico consultado";
        }

        protected void btnNuevoMedico_Click(object sender, EventArgs e)
        {
             if (ADOPacientes.Medicos.Existe_Medico(txtDNI.Text))
             {
                 lblMensaje_medico.Text = "El DNI introducido pertenece a otro médico";
                 txtDNI.Focus();
                 return;
             }

             if (txtNombre.Text == "")
             {
                 lblMensaje_medico.Text = "Debe introducir un nombre";
                 txtNombre.Focus();
                 return;
             }

             if (txtApellidos.Text == "")
             {
                 lblMensaje_medico.Text = "Debe introducir los apellidos";
                 txtApellidos.Focus();
                 return;
             }

             if (txtDNI.Text == "")
             {
                 lblMensaje_medico.Text = "Debe introducir el DNI";
                 txtDNI.Focus();
                 return;
             }

             if (txtEmail.Text == "")
             {
                 lblMensaje_medico.Text = "Debe introducir el e-mail";
                 txtEmail.Focus();
                 return;
             }

             if (txtEspecialidad.Text == "")
             {
                 lblMensaje_medico.Text = "Debe introducir la especialidad";
                 txtEspecialidad.Focus();
                 return;
             }

             if (txtUsuario.Text == "")
             {
                 lblMensaje_medico.Text = "Debe introducir un nombre de usuario";
                 txtUsuario.Focus();
                 return;
             }

             if (txtPassword.Text == "")
             {
                 lblMensaje_medico.Text = "Debe introducir una contraseña";
                 txtPassword.Focus();
                 return;
             }

             lblMensaje_medico.Text = ADOPacientes.Medicos.Nuevo_Medico(txtNombre.Text, txtApellidos.Text, txtDNI.Text, txtEmail.Text, txtTelefono.Text,
                 txtEspecialidad.Text, txtUsuario.Text, txtPassword.Text);

             //actualizamos el GridView
             GVMedico.DataBind();
        }

        protected void btnModificarMedico_Click(object sender, EventArgs e)
        {
             if (!ADOPacientes.Medicos.Existe_Medico(txtDNI.Text))
             {
                 lblMensaje_medico.Text = "El DNI introducido pertenece a otro médico";
                 txtDNI.Focus();
                 return;
             }

             if (txtNombre.Text == "")
             {
                 lblMensaje_medico.Text = "Debe introducir un nombre";
                 txtNombre.Focus();
                 return;
             }

             if (txtApellidos.Text == "")
             {
                 lblMensaje_medico.Text = "Debe introducir los apellidos";
                 txtApellidos.Focus();
                 return;
             }

             if (txtDNI.Text == "")
             {
                 lblMensaje_medico.Text = "Debe introducir el DNI";
                 txtDNI.Focus();
                 return;
             }

             if (txtEmail.Text == "")
             {
                 lblMensaje_medico.Text = "Debe introducir el e-mail";
                 txtEmail.Focus();
                 return;
             }

             if (txtEspecialidad.Text == "")
             {
                 lblMensaje_medico.Text = "Debe introducir la especialidad";
                 txtEspecialidad.Focus();
                 return;
             }

             if (txtUsuario.Text == "")
             {
                 lblMensaje_medico.Text = "Debe introducir un nombre de usuario";
                 txtUsuario.Focus();
                 return;
             }

             if (txtPassword.Text == "")
             {
                 lblMensaje_medico.Text = "Debe introducir una contraseña";
                 txtPassword.Focus();
                 return;
             }

             lblMensaje_medico.Text = ADOPacientes.Medicos.ActualizaMedicos(txtNombre.Text, txtApellidos.Text, txtDNI.Text, txtEmail.Text, txtTelefono.Text,
                 txtEspecialidad.Text, txtUsuario.Text, txtPassword.Text);

             //actualizamos el GridView
             GVMedico.DataBind();
        }

        protected void btnEliminarMedico_Click(object sender, EventArgs e)
        {

            if (txtDNI_Consulta.Text == "")
            {
                lblMensaje_medico.Text = "Debe introducir el DNI del médico que quiere eliminar";
                txtDNI_Consulta.Focus();
                return;
            }

            if (!ADOPacientes.Pacientes.Existe_Paciente(txtDNI_Consulta.Text))
            {
                lblMensaje_medico.Text = "El médico no existe";
                txtDNI_Consulta.Focus();
                return;
            }

            lblMensaje_medico.Text = ADOPacientes.Medicos.Eliminar_Medico(txtDNI_Consulta.Text);

            //actualizamos el GridView
            GVMedico.DataBind();

            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtDNI.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtEspecialidad.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";

        }

        protected void btn_LimpiarMedico_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtDNI.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtEspecialidad.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";
            lblMensaje_medico.Text = "";
        }
        }


 }