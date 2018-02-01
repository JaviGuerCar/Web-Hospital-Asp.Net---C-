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
    public partial class Paciente1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                int paciente_id = Convert.ToInt32(Session["Id_paciente"]);

                ADOPacientes.DSPacientes.PacienteDataTable miPaciente = ADOPacientes.Pacientes.Mis_Datos_Paciente(paciente_id);
                foreach (DataRow row in miPaciente.Rows)
                {
                    txtId_paciente_datos.Text = row["id_paciente"].ToString();
                    txtNombre_datos.Text = row["nombre"].ToString();
                    txtApellidos_datos.Text = row["apellidos"].ToString();
                    txtDNI_datos.Text = row["dni"].ToString();
                    txtEmail_datos.Text = row["email"].ToString();
                    txtTelefono_datos.Text = row["teléfono"].ToString();
                    txtCP_datos.Text = row["cp"].ToString();
                    txtDireccion_datos.Text = row["dirección"].ToString();
                    txtPoblacion_datos.Text = row["población"].ToString();
                    txtProvincia_datos.Text = row["provincia"].ToString();
                    txtEdad_datos.Text = row["edad"].ToString();
                    txtUsuario_datos.Text = row["usuario"].ToString();
                    txtPassword_datos.Text = row["password"].ToString();
                }
            }

        }

    }
}