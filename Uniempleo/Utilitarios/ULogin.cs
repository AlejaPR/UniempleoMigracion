using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class ULogin
    {
        private String Username;
        private String Clave;
        private int idRol;
        private String ip;
        private String mac;
        private String sesion;
        private int idRegistro;
        private String nombre;
        private int estado;
        private String script;
        private String errorInicio;

        public string Username1 { get => Username; set => Username = value; }
        public string Clave1 { get => Clave; set => Clave = value; }
        public int IdRol { get => idRol; set => idRol = value; }
        public string Ip { get => ip; set => ip = value; }
        public string Mac { get => mac; set => mac = value; }
        public string Sesion { get => sesion; set => sesion = value; }
        public int IdRegistro { get => idRegistro; set => idRegistro = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Estado { get => estado; set => estado = value; }
        public string Script { get => script; set => script = value; }
        public string ErrorInicio { get => errorInicio; set => errorInicio = value; }
    }
}
