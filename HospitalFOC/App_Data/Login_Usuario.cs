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
    public static class Login_Usuario
    {
        public static bool AutenticarPaciente(string usuario, string password)
        {
            //Declaramos la sentencia SQL
            string sql = @"SELECT COUNT(*)
                       FROM Paciente
                       WHERE usuario = @usuario AND password = @password";

            //utilizamos using para indicarle al compilador que dentro de este bloque se llame al Método Dispose.
            //para así liberar recursos cuanto antes mejor. en este caso no ocupamos decirle que cierre la conexión a la base de datos.
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital_FocConnectionString1"].ToString()))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@usuario", usuario);
                //codificamos la contraseña
               // string hash = Helper.EncodePassword(string.Concat(usuario, password));
                command.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count == 0)
                    return false;
                else
                    return true;

            }
        }

        public static DataTable loginConsultaPaciente(string usuario, string password)
        {
            string sql = @"SELECT id_paciente,rol
                            FROM Paciente
                            WHERE usuario = @usuario AND password = @password";


            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital_FocConnectionString1"].ToString()))
            {
                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.AddWithValue("@usuario", usuario);
                //codificamos la contraseña
                //string hash = Helper.EncodePassword(string.Concat(usuario, password));
                command.Parameters.AddWithValue("@password", password);

                conn.Open();
                SqlDataAdapter daAdaptador = new SqlDataAdapter(command);
                DataTable dtDatos = new DataTable();
                daAdaptador.Fill(dtDatos);
                return dtDatos;
            }
        }

        public static bool AutenticarMedico(string usuario, string password)
        {
            //Declaramos la sentencia SQL
            string sql = @"SELECT COUNT(*)
                       FROM Medico
                       WHERE usuario = @usuario AND password = @password";

            //utilizamos using para indicarle al compilador que dentro de este bloque se llame al Método Dispose.
            //para así liberar recursos cuanto antes mejor. en este caso no ocupamos decirle que cierre la conexión a la base de datos.
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital_FocConnectionString1"].ToString()))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@usuario", usuario);
                //codificamos la contraseña
                // string hash = Helper.EncodePassword(string.Concat(usuario, password));
                command.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count == 0)
                    return false;
                else
                    return true;

            }
        }

        public static DataTable loginConsultaMedico(string usuario, string password)
        {
            string sql = @"SELECT id_medico,rol
                            FROM Medico
                            WHERE usuario = @usuario AND password = @password";


            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital_FocConnectionString1"].ToString()))
            {
                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.AddWithValue("@usuario", usuario);
                //codificamos la contraseña
                //string hash = Helper.EncodePassword(string.Concat(usuario, password));
                command.Parameters.AddWithValue("@password", password);

                conn.Open();
                SqlDataAdapter daAdaptador = new SqlDataAdapter(command);
                DataTable dtDatos = new DataTable();
                daAdaptador.Fill(dtDatos);
                return dtDatos;
            }
        }

//        public static int loginIngresarPaciente(string nombre, string apellidos, string dni, string email, string teléfono, string cp, string dirección,
//            string población, string provincia, string edad, string usuario, string password)
//        {
//            int resultado = -1;

//            string sql = string.Format(@"INSERT INTO [Paciente]
//                        ([nombre],[apellidos],[dni],[email],[teléfono],[cp],[dirección],[población],[provincia],[edad],[usuario],[password])
//                        VALUES (@nombre, @apellidos, @dni, @email, @teléfono, @cp, @dirección, @población, @provincia, @edad, @usuario, @password)");

//            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital_FocConnectionString1"].ToString()))
//            {
 
//                SqlCommand command = new SqlCommand(sql, conn);
//                command.Parameters.AddWithValue("@nombre", nombre);
//                command.Parameters.AddWithValue("@apellidos", apellidos);
//                command.Parameters.AddWithValue("@dni", dni);
//                command.Parameters.AddWithValue("@email", email);
//                command.Parameters.AddWithValue("@teléfono", teléfono);
//                command.Parameters.AddWithValue("@cp", cp);
//                command.Parameters.AddWithValue("@dirección", dirección);
//                command.Parameters.AddWithValue("@población", población);
//                command.Parameters.AddWithValue("@provincia", provincia);
//                command.Parameters.AddWithValue("@edad", edad);
//                command.Parameters.AddWithValue("@usuario", usuario);
//                codificamos la contraseña
//                string hash = Helper.EncodePassword(string.Concat(usuario, password));
//                command.Parameters.AddWithValue("@password", hash);

//                conn.Open();

//               resultado = Convert.ToInt32(command.ExecuteScalar());

//            }

//            return resultado;
                    
//        }
    }
}