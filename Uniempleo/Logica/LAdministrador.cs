using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;
using Data;
using System.Data;

namespace Logica
{
    public class LAdministrador
    {
        public UAdministrador RegistrarAdm(String CorreoA, String usuarioA, String ClaveA, Int32 rol)
        {
            DAdministrador regAdm = new DAdministrador();
            DataTable registroAdministrador = regAdm.registroAdminisrador(CorreoA, usuarioA, ClaveA, rol);

            UAdministrador enviarR = new UAdministrador();

            //enviarm.Url = @"<script type='text/javascript'>Redir_VerOfertas();</script>";
            enviarR.Url = "PrincipalAdmi.aspx";
            enviarR.Mensaje = "Registrado correctamente";
            return enviarR;
        }


    }
}
