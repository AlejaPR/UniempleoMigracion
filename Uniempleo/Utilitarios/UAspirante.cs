using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class UAspirante
    {
        private Int32 idRegistro;
        private String terminoC;
        private String horario;
        private String tiempoC;
        private String hoja;
        private String session;
        private Int32 idAspirante;
        private String url;
        private String mensaje;
        private String nombre;
        private String apellido;
        private String FNacimiento;
        private String Direccion;
        private String Celular;
        private String EstadoC;
        private String documento;
        private String sexo;
        private String nombreEmpresa;
        private String cargo;
        private String jefe;
        private String telefonoEmpresa;
        private String funciones;
        private String rol;

	    private int idUser;
        private String userName;
        private int documentoP;
        private int rolId;
	    private DateTime controlTime;
        private DateTime fechaNacimiento;
	    private String direccionP;
        private int celularP;
	    private String estadocivil;
        private String foto;
        private int estado;
        private String sesion;
        private String url2;
        private String busqueda;
        private bool labelVisible;

	 //private String nombre;
      
        private String telefonoF;
        //private String funcion;
        private DateTime finicio;
        private DateTime ffin;
        private Int32 idr;
       
        private String mensajeError;

        private String titulo;
        private String lugar;
        private DateTime fecha;
        private DateTime hoy;
        
        private String documentoF;
        private String habilidad1;
        private String habilidad2;
        private String habilidad3;
       
        


        
        public int Idr { get => idr; set => idr = value; }
        
        public string MensajeError { get => mensajeError; set => mensajeError = value; }
        public DateTime Finicio { get => finicio; set => finicio = value; }
        public DateTime Ffin { get => ffin; set => ffin = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Lugar { get => lugar; set => lugar = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Documento { get => documento; set => documento = value; }
        public string Habilidad1 { get => habilidad1; set => habilidad1 = value; }
        public string Habilidad2 { get => habilidad2; set => habilidad2 = value; }
        public string Habilidad3 { get => habilidad3; set => habilidad3 = value; }
        public DateTime Hoy { get => hoy; set => hoy = value; }
        
    


          

        public int IdRegistro { get => idRegistro; set => idRegistro = value; }
        public string TerminoC { get => terminoC; set => terminoC = value; }
        public string Horario { get => horario; set => horario = value; }
        public string TiempoC { get => tiempoC; set => tiempoC = value; }
        public string Hoja { get => hoja; set => hoja = value; }
        public string Session { get => session; set => session = value; }
        public int IdAspirante { get => idAspirante; set => idAspirante = value; }
        public string Url { get => url; set => url = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Rol { get => rol; set => rol = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string FNacimiento1 { get => FNacimiento; set => FNacimiento = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Celular1 { get => Celular; set => Celular = value; }
        public string EstadoC1 { get => EstadoC; set => EstadoC = value; }
       //public string Documento { get => documento; set => documento = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Jefe { get => jefe; set => jefe = value; }
        public string TelefonoEmpresa { get => telefonoEmpresa; set => telefonoEmpresa = value; }
        public string Funciones { get => funciones; set => funciones = value; }

	    public int IdUser { get => idUser; set => idUser = value; }
        public string UserName { get => userName; set => userName = value; }
        public int RolId { get => rolId; set => rolId = value; }
        public DateTime ControlTime { get => controlTime; set => controlTime = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Mensaje1 { get => mensaje; set => mensaje = value; } 
        public string Estadocivil { get => estadocivil; set => estadocivil = value; }
        public string Foto { get => foto; set => foto = value; }
        public int Estado { get => estado; set => estado = value; }
        public string Sesion { get => sesion; set => sesion = value; }
        public string Url2 { get => url2; set => url2 = value; }
        public string Busqueda { get => busqueda; set => busqueda = value; }
        public bool LabelVisible { get => labelVisible; set => labelVisible = value; }
        public string DireccionP { get => direccionP; set => direccionP = value; }
        public int CelularP { get => celularP; set => celularP = value; }
        public int DocumentoP { get => documentoP; set => documentoP = value; }
        public string TelefonoF { get => telefonoF; set => telefonoF = value; }
        public string DocumentoF { get => documentoF; set => documentoF = value; }
    }
}
