using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;

public partial class view_VerPerfil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] == null || Session["nombre"] == null || Session["rol"] == null || (int)Session["rol"] != 2)
        {
            Session["id"] = null;
            Session["nombre"] = null;
            Session["rol"] = null;
            Response.Redirect("Loggin.aspx");
            Response.Cache.SetNoStore();
        }

        int idp = (int)Session["id"];
        

        Eperfil perfilcompleto = new Eperfil();
        Dperfil perfil = new Dperfil();
        perfilcompleto.Idperfil = int.Parse(idp.ToString());
        perfil.obtenerPerfil(perfilcompleto);
        DataTable perfilp = perfil.obtenerPerfil(perfilcompleto);
        DL_perfil.DataSource = perfilp;
        DL_perfil.DataBind();

        //GridView para los puntos

        int Idperfil = int.Parse(idp.ToString());
        UAspirante mostrarP = new UAspirante();
        LAspirante mispuntos = new LAspirante();
        GV_puntos.DataBind();

       
        //comentarios
       
       // DataTable perfilgc = perfil.obtenerComentarios(perfilcompleto);
        //GV_comentarios.DataSource = perfilgc;
       // GV_comentarios.DataBind();

        // Muestra los puntos totales
        LB_PuntosVaciosAsp.Visible = true;
        
    }





    protected void GV_puntos_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void DL_PuntosTotalesAsp_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

   

    protected void Lb_cancelar_cita_Command(object sender, CommandEventArgs e)
    {
        if (e.CommandName.Equals("Eliminar"))
        {
            String ida = e.CommandArgument.ToString();
            DAspirantes cancelar = new DAspirantes();
            EAspirantes cosa = new EAspirantes();

            cosa.IdAspirante = int.Parse(ida);
            cancelar.eliminarCita(cosa);

            Response.Redirect("VerPerfilAspirante.aspx");
        }
    }
}