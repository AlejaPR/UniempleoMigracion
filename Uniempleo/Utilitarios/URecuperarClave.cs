using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class URecuperarClave
    {
        private String username;
        private int id;
        private String correo;
        private int estado;
        private DateTime fecha;
        private String tokenizado;
        private String mensaje;
        private String mensajerespuesta;
        private String url;
        private String clave;
        private String url2;

        public string Username { get => username; set => username = value; }
        public int Id { get => id; set => id = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Estado { get => estado; set => estado = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Tokenizado { get => tokenizado; set => tokenizado = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }
        public string Mensajerespuesta { get => mensajerespuesta; set => mensajerespuesta = value; }
        public string Url { get => url; set => url = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Url2 { get => url2; set => url2 = value; }
    }
}
