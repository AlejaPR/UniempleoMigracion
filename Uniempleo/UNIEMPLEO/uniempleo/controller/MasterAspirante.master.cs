using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;

public partial class view_MasterAspirante : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        
    }





    protected void bt_hoja_Click(object sender, EventArgs e)
    {

        int id = (int)Session["id"];
        UAspirante verificar = new UAspirante();
        LAspirante verificarHV = new LAspirante();

        verificar = verificarHV.VerificarHoja(int.Parse(id.ToString()));

        Response.Redirect(verificar.Url);
    }

    protected void BT_verofertas_Click(object sender, EventArgs e)
    {
        Response.Redirect("VerOfertas.aspx");
    }

    

    

    protected void BT_miperfil_Click(object sender, EventArgs e)
    {
        Response.Redirect("VerPerfilAspirante.aspx");
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("VerOfertas.aspx");
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Session["id"] = null;
        Session["nombre"] = null;
        Session["rol"] = null;
        //Session.Clear();
        //Session.RemoveAll();
        //Session.Abandon();
        Response.Cache.SetNoStore();
        Response.Redirect("Loggin.aspx");
    }

    protected void bt_modificar_hoja_Click(object sender, EventArgs e)
    {
        Response.Redirect("Modificar_H_Aspi.aspx");
    }
}
