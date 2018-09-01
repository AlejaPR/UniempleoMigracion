using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;

public partial class view_ExperienciaL : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      
       /* int idasp = int.Parse(Session["id"].ToString());
        string rol = Session["rol"].ToString();

        
        UAspirante validaLink = new UAspirante();
        LAspirante llevaValidacion = new LAspirante();
        validaLink.Idr = idasp;
       
        validaLink.Idrol = rol;
        validaLink = llevaValidacion.ValidacionUrl(validaLink);

        Session["id"] = validaLink.Idr;
       
        Session["rol"] = validaLink.Idrol;

        ScriptManager.RegisterStartupScript(this, typeof(Page), "invocarfuncion", validaLink.Url, false);
        Page.ClientScript.RegisterStartupScript(Page.GetType(), "Message", validaLink.Url);
        Response.Cache.SetNoStore();
        */

    }




    protected void bt_agregar_Click(object sender, EventArgs e)
    {


        UAspirante control = new UAspirante();
        LAspirante controlar = new LAspirante();

        control.Finicio = DateTime.Parse(tb_inicio.Text);
        control.Ffin = DateTime.Parse(tb_inicio.Text);

        //control = controlar.ValidaHoras(control);

        LB_ErrorFechasAsp.Text = control.MensajeError;
       
        control.Idr = (int)Session["id"];
        control.Nombre = tb_nomemp.Text;
        control.Cargo = tb_cargo.Text;
        control.Jefe = tb_jefe.Text;
        control.TelefonoEmpresa = tb_telefonoE.Text;
        control.Funciones = tb_funcion.Text;
        control.Finicio = DateTime.Parse(tb_inicio.Text);
        control.Ffin = DateTime.Parse(tb_fin.Text);

        control = controlar.ValidaHoras(control);

        ScriptManager.RegisterStartupScript(this, typeof(Page), "invocarfuncion", control.Url, false);
        Page.ClientScript.RegisterStartupScript(Page.GetType(), "Message", control.Url);
    }



    protected void BT_omitirExperienciaL_Click(object sender, EventArgs e)
    {
        Response.Redirect("TipoEmpleo.aspx");
    }
}