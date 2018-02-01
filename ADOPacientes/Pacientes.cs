using ADOPacientes.DSPacientesTableAdapters;
using HospitalFOC;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;


namespace ADOPacientes
{
    public class Pacientes
    {
        private static PacienteTableAdapter adapter = new PacienteTableAdapter();

        public static DSPacientes.PacienteDataTable Consulta_Pacientes(string dni)
        {
            return adapter.Consulta_Pacientes(dni);
        }


        public static bool Existe_Paciente(string dni)
        {
            return adapter.Existe_Paciente(dni) == 1;
        }


        public static string NuevoPaciente(string nombre, string apellidos, string dni, string email, string teléfono, string cp, string dirección, string población, string provincia, string edad, string usuario, string password)
        {
            //string hash = Helper.EncodePassword(string.Concat(usuario, password));
            int add_paciente = adapter.NuevoPaciente(nombre, apellidos, dni, email, teléfono, cp, dirección, población, provincia, edad, usuario, password);
            if (add_paciente == 0)
            {
                return "No se pudo insertar el nuevo paciente";
            }

            else return "Paciente insertado correctamente";
            


        }

        public static string ActualizarPaciente(string nombre, string apellidos, string dni, string email, string teléfono, string cp, string dirección, string población, string provincia, string edad, string usuario, string password)
        {
            int act_paciente = adapter.Actualizar_Pacientes(nombre, apellidos, dni, email, teléfono, cp, dirección, población, provincia, edad, usuario, password);
            if (act_paciente == 0)
            {
                return "No se pudo actualizar el paciente";
            }

            else return "Paciente actualizado correctamente";

        }

        public static string Eliminar_Paciente(string dni)
        {
            int elim_paciente = adapter.Eliminar_Paciente(dni);
            if (elim_paciente == 0)
            {
                return "No se pudo borrar el paciente";
            }

            else return "Paciente borrado correctamente";
        }

        public static string Modificar_Paciente(string nombre, string apellidos, string dni, string email, string teléfono, string cp, string dirección, string población, string provincia, string edad, string usuario, string password, int id_paciente)
        {
            int modif_paciente = adapter.Modificar_Paciente(nombre, apellidos, dni, email, teléfono, cp, dirección, población, provincia, edad, usuario, password, id_paciente);
            if (modif_paciente == 0)
            {
                return "No se pudo actualizar el paciente";
            }

            else return "Paciente actualizado correctamente";

        }

        //método que devuelve los datos de la Consulta del TableAdapter de Paciente
        public static DSPacientes.PacienteDataTable Mis_Datos_Paciente(int id_paciente)
        {
            return adapter.Consulta_Datos_Paciente(id_paciente);
        }

    }

}

