using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalFOC
{
    public partial class Paciente
    {
        public int id_paciente { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string dni { get; set; }
        public string email { get; set; }
        public string teléfono { get; set; }
        public string cp { get; set; }
        public string dirección { get; set; }
        public string población { get; set; }
        public string provincia { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }

        public Paciente(int id_paciente, string nombre, string apellidos, string dni, string email, string teléfono, string cp, string dirección, string población, string provincia, DateTime fecha_nacimiento, string usuario, string password)
        {
            this.id_paciente = id_paciente;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.email = email;
            this.teléfono = teléfono;
            this.cp = cp;
            this.dirección = dirección;
            this.población = población;
            this.provincia = provincia;
            this.fecha_nacimiento = fecha_nacimiento;
            this.usuario = usuario;
            this.password = password;
        }
    }
}