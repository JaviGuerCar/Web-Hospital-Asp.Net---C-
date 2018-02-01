using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace HospitalFOC
{
    public partial class Citas_Medico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                int medico_id = Convert.ToInt32(Session["Id_medico"]);

                ADOPacientes.DSPacientes.CitasDataTable citasMedico = ADOPacientes.Citas.Obtener_Citas_Medico(medico_id);
                foreach (DataRow row in citasMedico.Rows)
                {
                    txtId_cita.Text = row["id_citas"].ToString();
                    txtFecha_Cita.Text = row["fecha_hora"].ToString();
                    txtAsunto_Cita.Text = row["asunto"].ToString();
                    txtDescripcion_Cita.Text = row["descripción"].ToString();
                    //txt_Medico_Cita.Text = row["id_medico"].ToString();

                    ADOPacientes.DSPacientes.PacienteDataTable nombrePaciente = ADOPacientes.Pacientes.Mis_Datos_Paciente(Int32.Parse(row["id_paciente"].ToString()));
                    foreach (DataRow row2 in nombrePaciente.Rows)
                    {
                        txt_Paciente_Cita.Text = row2["nombre"] + " " + row2["apellidos"].ToString();
                    }

                }

            }
        }
    }
}