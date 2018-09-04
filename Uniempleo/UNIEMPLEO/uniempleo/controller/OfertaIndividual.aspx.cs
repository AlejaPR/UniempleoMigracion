using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;


public partial class view_OfertaIndividual : System.Web.UI.Page
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
        
        UAspirante oferta = new UAspirante();
        LAspirante ofertacompleta = new LAspirante();

        int id = Int32.Parse(Convert.ToString(Request.QueryString["valor"]));
        DataTable datos = ofertacompleta.mostrarOfertaCompleta(id);
        DL_oferta.DataSource = datos;
        DL_oferta.DataBind();

    }



    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {   
        //valida si ya tiene peticion de citas
        int idp = (int)Session["id"];
        UAspirante validar = new UAspirante();
        LAspirante validarsoli = new LAspirante();
        validar = validarsoli.Validaragenda(int.Parse(idp.ToString()));
        
        //envia mensaje a empresa
        UAspirante enviaM = new UAspirante();
        LAspirante validarmsj = new LAspirante();
        String Mensaje = "Quiero agendar una cita";

        enviaM = validarmsj.MensajeCita( Mensaje.ToString(), (int)Session["id"], Int32.Parse(Convert.ToString(Request.QueryString["valor"])),
        DateTime.Now, Session.SessionID);

        Page.Response.Write("<script language='JavaScript'>window.alert('Tu mensaje ha sido enviado, en unos dias la empresa te contactará ');</script>");
        Response.Redirect(enviaM.Url);
        

    }


}