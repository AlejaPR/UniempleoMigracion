using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;


public partial class view_VerOfertas : System.Web.UI.Page
{

    
    protected void Page_Load(object sender, EventArgs e)
    {
        UAspirante validaLinkc = new UAspirante();
        LAspirante validaLinkVO = new LAspirante();
        validaLinkc.IdUser = int.Parse(Session["id"].ToString());
        validaLinkc.UserName = Session["nombre"].ToString();
        validaLinkc.RolId = int.Parse(Session["rol"].ToString());
        validaLinkc = validaLinkVO.ValiUrlVO(validaLinkc);

        ScriptManager.RegisterStartupScript(this, typeof(Page), "invocarfuncion", validaLinkc.Url, false);
        Page.ClientScript.RegisterStartupScript(Page.GetType(), "Message", validaLinkc.Url);
        Response.Cache.SetNoStore();
    }


    protected void TB_BuscaOferta_TextChanged(object sender, EventArgs e)
    {

    }


    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        UAspirante llevaBusqueda = new UAspirante();
        LAspirante conBusq = new LAspirante();

        llevaBusqueda.Busqueda = TB_BuscaOferta.Text;
        DataTable llevar = conBusq.BusquedaOferta(llevaBusqueda);
        DL_Ofertas.DataSource = llevar;
        DL_Ofertas.DataBind();



        L_ErrorBuscarOferta.Visible = llevaBusqueda.LabelVisible;

         L_ErrorBuscarOferta.Text = llevaBusqueda.Mensaje;
    }




    protected void DL_ofertas_itemComand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "ver mas")
        {
            String id = e.CommandArgument.ToString();
            Response.Redirect("OfertaIndividual.aspx?valor=" + id);
        }
        if (e.CommandName == "ver empresa")
        {
            String idEm = e.CommandArgument.ToString();
            Response.Redirect("PerfilEmpresa.aspx?valor=" + idEm);
        }
    }
    


}