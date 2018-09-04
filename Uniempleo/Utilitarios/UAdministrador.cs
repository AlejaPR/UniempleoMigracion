using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class UAdministrador
    {
        private String url;
        private String mensaje;
        private String correoAdm;
        private String usuarioAdm;
        private String claveAdm;
        private Int32 rol;





        public string Url { get => url; set => url = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }
        public string CorreoAdm { get => correoAdm; set => correoAdm = value; }
        public string UsuarioAdm { get => usuarioAdm; set => usuarioAdm = value; }
        public string ClaveAdm { get => claveAdm; set => claveAdm = value; }
        public int Rol { get => rol; set => rol = value; }

    }
}
