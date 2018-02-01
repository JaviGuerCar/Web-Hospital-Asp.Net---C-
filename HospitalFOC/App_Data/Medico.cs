using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalFOC
{
    public class Medico
    {
        public int id_medico { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string dni { get; set; }
        public string email { get; set; }
        public string teléfono { get; set; }
        public string especialidad { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }

        public Medico(int id_medico, string nombre, string apellidos, string dni, string email, string teléfono, string especialidad, string usuario, string password)
        {
            this.id_medico = id_medico;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.email = email;
            this.teléfono = teléfono;
            this.especialidad = especialidad;
            this.usuario = usuario;
            this.password = password;
        }

    }
}