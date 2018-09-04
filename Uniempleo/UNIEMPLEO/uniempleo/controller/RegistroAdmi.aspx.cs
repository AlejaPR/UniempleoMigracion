using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;

public partial class view_RegistroAdmi_ : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       

    }

    protected void bt_agregar_Click(object sender, EventArgs e)
    {
        
        UAdministrador registroAd = new UAdministrador();
        LAdministrador registrar = new LAdministrador();
       

        registroAd = registrar.RegistrarAdm(tb_correo.Text.ToString(), tb_usuario.Text.ToString(), tb_clave.Text.ToString(), int.Parse(DDL_rol.SelectedValue.ToString()));
        
        Response.Redirect(registroAd.Url);
    }
}