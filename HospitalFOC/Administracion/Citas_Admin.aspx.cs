using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;


namespace HospitalFOC.Administracion
{
    public partial class Citas_Admin : System.Web.UI.Page
    {
        protected ADOPacientes.DSPacientes.CitasDataTable citas;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // CARGAMOS EL LISTBOX DE LAS ESPECIALIDADES
                ADOPacientes.DSPacientes.MedicoDataTable medicos = ADOPacientes.Medicos.Obtener_Medicos();

                List<string> especialidades = new List<string>();

                foreach (DataRow row in medicos.Rows)
                {
                    string especialidad = row["especialidad"].ToString();
                    string medico = "Dr. " + row["apellidos"].ToString();
                    string id = row["id_medico"].ToString();

                    //string especialidad = row["especialidad"].ToString();

                    if (!especialidades.Contains(especialidad))
                    {
                        especialidades.Add(especialidad);
                        lbSelect_Medico.Items.Add(new ListItem(especialidad + " - " + medico, id));
                    }
                }
            }
            // CARGAMOS TODAS LAS CITAS DESDE LA FECHA ACTUAL
        }

        protected void Calendar1_DayRender1(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date < DateTime.Today)
            {
                e.Day.IsSelectable = false;
                e.Cell.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                e.Cell.ForeColor = System.Drawing.Color.Black;
            }


            if (lbSelect_Medico.SelectedValue != "")
            {
                int id_medico = Int32.Parse(lbSelect_Medico.SelectedValue);
                //TextDescripcion.Text = ListBox1.SelectedValue;
                citas = ADOPacientes.Citas.Obtener_Citas_Medico(id_medico);
            }

            if (citas != null)
            {
                foreach (DataRow row in citas.Rows)
                {
                    DateTime fechaCita = (DateTime)row["fecha_hora"];
                   

                    if ((fechaCita == e.Day.Date) )
                    {
                        e.Day.IsSelectable = false;
                        e.Cell.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }             
        }

        // EVENTO BOTON COMPROBAR DISPONIBILIDAD
        protected void btnDisponibilidad_Click(object sender, EventArgs e)
        {
            int id_medico = Int32.Parse(lbSelect_Medico.SelectedValue);
            ADOPacientes.DSPacientes.CitasDataTable citas = ADOPacientes.Citas.Obtener_Citas_Medico(id_medico);
        }

        // EVENTO EFECTUAR RESERVA
        protected void btnInsertarCita_Click(object sender, EventArgs e)
        {
            string idPaciente = (string)Session["Id_paciente"];
            lblMensaje_citas.Text = ADOPacientes.Citas.Insertar_Cita(Calendario.SelectedDate, txtAsunto.Text, txtDescripcion.Text, Int32.Parse(idPaciente), Int32.Parse(lbSelect_Medico.SelectedValue));
        }
    }
}