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
    public partial class Medico1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int medico_id = Convert.ToInt32(Session["Id_medico"]);

            ADOPacientes.DSPacientes.MedicoDataTable miMedico = ADOPacientes.Medicos.Mis_Datos_Medico(medico_id);
            foreach (DataRow row in miMedico.Rows)
            {
                txtId_medico_datos.Text = row["id_medico"].ToString();
                txtNombre_datos.Text = row["nombre"].ToString();
                txtApellidos_datos.Text = row["apellidos"].ToString();
                txtDNI_datos.Text = row["dni"].ToString();
                txtEmail_datos.Text = row["email"].ToString();
                txtTelefono_datos.Text = row["teléfono"].ToString();
                txtEspecialidad_datos.Text = row["especialidad"].ToString();
                txtUsuario_datos.Text = row["usuario"].ToString();
                txtPassword_datos.Text = row["password"].ToString();
            }

        }
    }
}