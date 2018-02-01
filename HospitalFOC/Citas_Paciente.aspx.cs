using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace HospitalFOC
{
    public partial class Citas_Paciente : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {  

                int paciente_id = Convert.ToInt32(Session["Id_paciente"]);

                ADOPacientes.DSPacientes.CitasDataTable citasPaciente = ADOPacientes.Citas.Obtener_Citas_Paciente(paciente_id);
                foreach (DataRow row in citasPaciente.Rows)
                {
                    txtId_cita.Text = row["id_citas"].ToString();
                    txtFecha_Cita.Text = row["fecha_hora"].ToString();
                    txtAsunto_Cita.Text = row["asunto"].ToString();
                    txtDescripcion_Cita.Text = row["descripción"].ToString();
                    //txt_Medico_Cita.Text = row["id_medico"].ToString();

                    ADOPacientes.DSPacientes.MedicoDataTable nombreMedico = ADOPacientes.Medicos.Mis_Datos_Medico(Int32.Parse(row["id_medico"].ToString()));
                    foreach (DataRow row2 in nombreMedico.Rows)
                    {
                        txt_Medico_Cita.Text = "Dr." + row2["apellidos"].ToString();
                    }
 
                }
  
            }
        }
    }
}
