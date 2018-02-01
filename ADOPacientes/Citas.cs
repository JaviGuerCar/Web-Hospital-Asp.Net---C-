using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADOPacientes.DSPacientesTableAdapters;

namespace ADOPacientes
{
    public class Citas
    {
        private static CitasTableAdapter adapter = new CitasTableAdapter();

        public static DSPacientes.CitasDataTable Obtener_Citas()
        {
            return adapter.Obtener_Citas();
        }

        public static DSPacientes.CitasDataTable Obtener_Citas_Medico(int id_medico)
        {
            return adapter.Obtener_Citas_Medico(id_medico);
        }

        public static string Insertar_Cita(DateTime fecha_hora, string asunto, string descripcion, int id_paciente, int id_medico)
        {
            int add_cita = adapter.Insertar_Cita(fecha_hora, asunto, descripcion, id_paciente, id_medico);
            if (add_cita == 0)
            {
                return "No se pudo reservar la cita";
            }

            else return "Cita reservada correctamente";
        }

        public static DSPacientes.CitasDataTable Obtener_Citas_Paciente(int id_paciente)
        {
            return adapter.Obtener_Citas_Paciente(id_paciente);
        }

        public static string Eliminar_Cita(int id_citas)
        {
            int elim_cita = adapter.Eliminar_Cita(id_citas);
            if (elim_cita == 0)
            {
                return "No se pudo eliminar la cita";
            }

            else return "Cita eliminada correctamente";
        }

    }
}
