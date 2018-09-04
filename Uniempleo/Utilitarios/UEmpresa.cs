using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class UEmpresa
    {
        private Int32 idE;
        private String nombreE;
        private String forma;
        private String direccionE;
        private String telefonoE;
        private String sector;
        private String empleados;
        private String nit;
        private String tipo;
        private String url;

        public int IdE { get => idE; set => idE = value; }
        public string NombreE { get => nombreE; set => nombreE = value; }
        public string Forma { get => forma; set => forma = value; }
        public string DireccionE { get => direccionE; set => direccionE = value; }
        public string TelefonoE { get => telefonoE; set => telefonoE = value; }
        public string Sector { get => sector; set => sector = value; }
        public string Empleados { get => empleados; set => empleados = value; }
        public string Nit { get => nit; set => nit = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Url { get => url; set => url = value; }
    }
}
