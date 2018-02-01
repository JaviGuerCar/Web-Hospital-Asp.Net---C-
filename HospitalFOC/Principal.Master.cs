using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalFOC
{
    public partial class Principal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string roles = (string)Session["Rol"];

                switch (roles)
                {
                    //Usuario paciente
                    case ("paciente"): MenuPaciente();
                        break;
                    //Usuario médico
                    case ("medico"): MenuMedico();
                        break;
                    //Usuario admin
                    case ("admin"): MenuAdmin();
                        break;

                    default:
                        break;

                }
            }
        }

        protected void MenuPaciente()
        {
            string menu_html = string.Format(@"
            <ul class='nav'>
                <li><a runat='server' href='/Default.aspx'><span>Inicio</span></a></li>
                <li><a runat='server' href='#'>Mis Datos</a>
                    <ul>
                        <li><a runat='server' href='/Paciente/Paciente.aspx'>Consultar Datos</a></li>
                        <li><a runat='server' href='/Paciente/Modificar_Paciente.aspx'>Modificar Datos</a></li>
                    </ul>
                </li>
                <li><a runat='server' href='#'>Mis Citas</a>
                    <ul>
                        <li><a runat='server' href='/Administracion/Citas_Admin.aspx'>Pedir Cita</a></li>
                        <li><a runat='server' href='/Citas_Paciente.aspx'>Consultar Cita</a></li>
                        <li><a runat='server' href='/EliminarCita.aspx'>Eliminar Cita</a></li>
                    </ul>
                </li>
                <li><a runat='server' href='/Contacto.aspx'>Contacto</a></li>
            </ul>
          
            ");

            this.Menu_Web.Text = menu_html;
        }

        protected void MenuMedico()
        {
            string menu_html = string.Format(@"
            <ul class='nav'>
                <li><a runat='server' href='/Default.aspx'><span>Inicio</span></a></li>
                <li><a runat='server' href='#'>Mis Datos</a>
                    <ul>
                        <li><a runat='server' href='/Medico/Medico.aspx'>Consultar Datos</a></li>
                        <li><a runat='server' href='/Medico/Modificar_Medico.aspx'>Modificar Datos</a></li>
                    </ul>
                </li>
                <li><a runat='server' href='#'>Mis Citas</a>
                    <ul>
                        <li><a runat='server' href='/Citas_Medico.aspx'>Consultar Cita</a></li>
                    </ul>
                </li>
                <li><a runat='server' href='/Contacto.aspx'>Contacto</a></li>
            </ul>
            ");

            this.Menu_Web.Text = menu_html;
        }

        protected void MenuAdmin()
        {
            string menu_html = string.Format(@"
            <ul class='nav'>
                <li><a runat='server' href='/Default.aspx'><span>Inicio</span></a></li>
                <li><a runat='server' href='/Administracion/Paciente_Admin.aspx'>Pacientes</a></li>  
                <li><a runat='server' href='/Administracion/Medico_Admin.aspx'>Médicos</a></li>
                <li><a runat='server' href='/Administracion/Citas_Admin.aspx'>Citas</a></li>
                <li><a runat='server' href='/Contacto.aspx'>Contacto</a></li>
            </ul>
            ");

            this.Menu_Web.Text = menu_html;
        }

    }
}