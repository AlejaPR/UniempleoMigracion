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

        /*UAspirante csesion = new UAspirante();
        LAspirante captura = new LAspirante();
        int idasp = int.Parse(Session["id"].ToString());
        string nom = Session["nombre"].ToString();
        string rol = Session["rol"].ToString();

        csesion = captura.ValidacionUrl(csesion);

        Response.Cache.SetNoStore();

       */
    }
    protected void BTN_guarda_Click(object sender, EventArgs e)
    {

        UAspirante control = new UAspirante();
        LAspirante controlar = new LAspirante();
        String hoy = DateTime.Now.ToString("dd/MM/yyyy");
        control.Fecha = DateTime.Parse(TB_fecha.Text);
        control.Hoy = DateTime.Parse(hoy);





        control.Idr = (int)Session["id"];
        control.Titulo = TB_titulo.Text;
        control.Lugar = TB_lugar.Text;
        control.Fecha = DateTime.Parse(TB_fecha.Text);
        control.TelefonoF= TB_telefono.Text;
        control.DocumentoF= cargarimagen();
        control.Habilidad1 = TB_Hab1.Text;
        control.Habilidad2 = TB_Hab2.Text;
        control.Habilidad3 = TB_Hab3.Text;
        control = controlar.ValidaHoy(control);


        L_CalendarioError.Text = control.MensajeError;
        Response.Redirect(control.Url);
        

        ScriptManager.RegisterStartupScript(this, typeof(Page), "invocarfuncion", control.Url, false);
        Page.ClientScript.RegisterStartupScript(Page.GetType(), "Message", control.Url);
    
    }


    protected  String cargarimagen()
    {
        ClientScriptManager cd = this.ClientScript;
        String nombreArchivo = System.IO.Path.GetFileName(FU_certificado.PostedFile.FileName);
        String extension = System.IO.Path.GetExtension(FU_certificado.PostedFile.FileName);
        String saveLocation = "";

        if (!(string.Compare(extension, ".doc", true) == 0 || string.Compare(extension, ".docx", true) == 0 || string.Compare(extension, ".pdf", true) == 0))
        {
            cd.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Solo se admiten documentos .doc .docx .pdf');</script>");
            return null;
        }
        saveLocation = Server.MapPath("~\\CertificacionesA") + "\\" + nombreArchivo;

        FU_certificado.PostedFile.SaveAs(saveLocation);
        cd.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('El archivo ha sido cargado');</script>");

        return "~\\CertificacionesA" + "\\" + nombreArchivo;
 
    
   }







    protected void BT_omiteFormacionA_Click(object sender, EventArgs e)
    {
        UAspirante redireccion = new UAspirante();
        redireccion.Url = "ExperienciaL.aspx";
    }

}
