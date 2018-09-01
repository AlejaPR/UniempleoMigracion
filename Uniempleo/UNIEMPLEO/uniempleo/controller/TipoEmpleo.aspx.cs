using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;



public partial class view_TipoEmpleo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void BTN_agrega_Click(object sender, EventArgs e)
    {
        UAspirante tipoEmpleo = new UAspirante();
        LAspirante registraTipo = new LAspirante();


        
        tipoEmpleo.IdRegistro = (int)Session["id"];
        tipoEmpleo.TerminoC = (RBL_termino.SelectedItem).ToString();
        tipoEmpleo.Horario = (DDL_horario.SelectedItem).ToString();
        tipoEmpleo.TiempoC = (RBL_tiempo.SelectedItem).ToString();
        tipoEmpleo.Hoja = cargarHoja();
        tipoEmpleo.Session = Session.SessionID;

        Response.Redirect(tipoEmpleo.Url);

        //ScriptManager.RegisterStartupScript(this, typeof(Page), "invocarfuncion", tipoEmpleo.Url, false);
        //Page.ClientScript.RegisterStartupScript(Page.GetType(), "Message", tipoEmpleo.Url);


    }
    protected String cargarHoja()
    {
        ClientScriptManager cd = this.ClientScript;
        String nombreArchivo = System.IO.Path.GetFileName(Fu_hoja.PostedFile.FileName);
        String extension = System.IO.Path.GetExtension(Fu_hoja.PostedFile.FileName);
        String saveLocation = "";

        if (!(string.Compare(extension, ".doc", true) == 0 || string.Compare(extension, ".docx", true) == 0 || string.Compare(extension, ".pdf", true) == 0))
        {
            cd.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Solo se admiten documentos .doc .docx .pdf');</script>");
            return null;
        }


        saveLocation = Server.MapPath("~\\Hojas") + "\\" + nombreArchivo;

        Fu_hoja.PostedFile.SaveAs(saveLocation);
        cd.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('El archivo ha sido cargado');</script>");

        return "~\\Hojas" + "\\" + nombreArchivo;
    }

}