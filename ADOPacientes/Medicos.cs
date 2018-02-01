using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADOPacientes.DSPacientesTableAdapters;

namespace ADOPacientes
{
    public class Medicos
    {
        private static MedicoTableAdapter adapter = new MedicoTableAdapter();

        public static DSPacientes.MedicoDataTable Consulta_Medicos(string dni)
        {
            return adapter.Consulta_Medico(dni);
        }

        //método que devuelve los datos de la Consulta del TableAdapter de Medico
        public static DSPacientes.MedicoDataTable Mis_Datos_Medico(int id_medico)
        {
            return adapter.Consulta_Datos_Medico(id_medico);
        }

        public static bool Existe_Medico(string dni)
        {
            return adapter.Existe_Medico(dni) == 1;
        }

        public static string Nuevo_Medico(string nombre, string apellidos, string dni, string email, string teléfono, string especialidad, string usuario, string password)
        {
            int add_medico = adapter.Nuevo_Medico(nombre, apellidos, dni, email, teléfono, especialidad, usuario, password);
            if (add_medico == 0)
            {
                return "No se pudo insertar el nuevo médico";
            }

            else return "Médico insertado correctamente";
        }

        public static string ActualizaMedicos(string nombre, string apellidos, string dni, string email, string teléfono, string especialidad, string usuario, string password)
        {
            int act_medico = adapter.Actualizar_Medicos(nombre, apellidos, dni, email, teléfono, especialidad, usuario, password);
            if (act_medico == 0)
            {
                return "No se pudo insertar el nuevo médico";
            }

            else return "Médico insertado correctamente";
        }

         public static string Eliminar_Medico(string dni)
         {
             int elim_medico = adapter.Eliminar_Medico(dni);
             if (elim_medico == 0)
             {
                 return "No se pudo borrar el paciente";
             }

             else return "Paciente borrado correctamente";
         }

         public static string Modificar_Medico(string nombre, string apellidos, string dni, string email, string teléfono, string especialidad, string usuario, string password, int id_medico)
         {
             int mod_medico = adapter.Modificar_Medico(nombre, apellidos, dni, email, teléfono, especialidad, usuario, password, id_medico);
             if (mod_medico == 0)
             {
                 return "No se pudo actualizar el nuevo médico";
             }

             else return "Médico actualizado correctamente";
         }

         public static DSPacientes.MedicoDataTable Obtener_Especialidades()
         {
             return adapter.Obtener_Especialidades();
             
         }

         public static DSPacientes.MedicoDataTable Obtener_Medicos()
         {
             return adapter.Obtener_Medicos();

         }
    }
}
