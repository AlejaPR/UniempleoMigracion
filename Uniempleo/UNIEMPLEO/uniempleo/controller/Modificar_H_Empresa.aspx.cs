using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;

public partial class view_Modificar_H_Empresa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int idp = (int)Session["id"];
        int Idperfil = int.Parse(idp.ToString());
        UEmpresa mostrarE = new UEmpresa();
        LEmpresa datosE = new LEmpresa();




    }

}