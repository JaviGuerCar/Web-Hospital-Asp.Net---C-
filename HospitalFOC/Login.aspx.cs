using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace HospitalFOC
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Enviar_Click(object sender, EventArgs e)
        {
            //se declara la variable usuario de tipo string y se le indica que reemplaze los carácteres que sean:

            string usuario = this.txtUsuario.Text;
            string password = this.txtPassword.Text;

            //Se manda llamar al método Autenticar y se le pasan los valores correspondientes.
            if (Login_Usuario.AutenticarPaciente(usuario, password) == true)
            {
                //Se verifica en la base de datos el UsuarioID y se almacena en la variable tblPaciente.
                DataTable tblPaciente = Login_Usuario.loginConsultaPaciente(usuario, password);
                
                //se declara y se le da el valor a la variable de sesión Id_paciente
                Session["Id_paciente"] = tblPaciente.Rows[0]["id_paciente"].ToString();
                Session["Rol"] = tblPaciente.Rows[0]["rol"].ToString();
                //Manda a la principal en caso de ser correcto el login
               
                Response.Redirect("~/Default.aspx");
            }

            else if (Login_Usuario.AutenticarMedico(usuario, password) == true)
            {
                //Se verifica en la base de datos el UsuarioID y se almacena en la variable tblUsuario.
                DataTable tblMedico = Login_Usuario.loginConsultaMedico(usuario, password);

                //se declara y se le da el valor a la variable de sesión id_medico
                Session["Id_medico"] = tblMedico.Rows[0]["id_medico"].ToString();
                Session["Rol"] = tblMedico.Rows[0]["rol"].ToString();
                //Manda a la principal en caso de ser correcto el login

                Response.Redirect("~/Default.aspx");
            }
            else
            {
                //Mensaje de error en caso de no ser usuario registrado
                lblMensaje_login.Text = "Usuario o Contraseña incorrecta, verifique los datos introducidos.";
            }
        }

    }
}