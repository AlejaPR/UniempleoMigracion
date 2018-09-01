using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Data;
using Utilitarios;

namespace Logica
{
    public class LAspirante
    {
        public UAspirante VerificarHoja(Int32 idAspirante)
        {
            DAspirante verificarHoja = new DAspirante();
            DataTable datosHoja = verificarHoja.VerificaHV(idAspirante);
            UAspirante verificarH = new UAspirante();

            if (datosHoja.Rows.Count > 0)
            {
                verificarH.Url = "VerOfertas.aspx";
                verificarH.Mensaje = "Hoja de vida llena, si quieres modificar ve a 'MODIFICAR HOJA DE VIDA'";


                return verificarH;
            }
            else
            {

                verificarH.Url = "DatosPersonalesA.aspx";

                return verificarH;
            }
        }

        public UAspirante cerrarSesion(Int32 sesion)
        {
            DAspirante cerrarSesion = new DAspirante();
            DataTable datosSesion = cerrarSesion.cerrarSesion(sesion);
            UAspirante cerrar = new UAspirante();

            if (datosSesion == null)
            {

                cerrar.Url = "Loggin.aspx";// funcion de response redirect 

            }
            return cerrar;
        }


        public DataTable mostrarmisPuntos(Int32 idperfil)
        {

            DataTable muestraP = new DataTable();
            DAspirante mispuntos = new DAspirante();
            muestraP = mispuntos.obtenerPuntos(idperfil);
            return muestraP;
        }

        public DataTable mostrarmisPuntosT(Int32 idperfil)
        {

            DataTable muestraT = new DataTable();
            DAspirante mispuntosT = new DAspirante();
            muestraT = mispuntosT.ObtienePuntosTotales(idperfil);
            return muestraT;
        }

        public UAspirante modificarDatosP(Int32 Idpm)
        {
            DAspirante datosP = new DAspirante();
            DataTable modificarDatos = datosP.modificarPerfil(Idpm);
            UAspirante datosPersonales = new UAspirante();

            datosPersonales.Url = "Modificar_H_Aspi.aspx";
            return datosPersonales;
        }

        public UAspirante modificarDatosP(Int32 Idpm, String Nombre, String Apellido, String Nacimiento, String Direccion, String Celular, String Estado, String documento, String sexo, Int32 id_aspirante,
                                          String nombre_aspirante, String apellido_aspirante, String fecha_nacim, String direccion_asp, String telefono_asp, String estado_civil)
        {
            DAspirante datosP = new DAspirante();
            DataTable modificarDatos = datosP.Editardp(Idpm, Nombre, Apellido, Nacimiento, Direccion, Celular, Estado, documento, sexo, id_aspirante, nombre_aspirante, apellido_aspirante, fecha_nacim, direccion_asp, telefono_asp, estado_civil);
            UAspirante datosPersonales = new UAspirante();

            datosPersonales.Url = "Modificar_H_Aspi.aspx";
            return datosPersonales;
        }

        public UAspirante modificarExperienciaL(Int32 Idex)
        {
            DAspirante datosEL = new DAspirante();
            DataTable modificarExperiencia = datosEL.obtenerExpL(Idex);

            UAspirante experiencia = new UAspirante();



            experiencia.Url = "Modificar_H_Aspi.aspx";
            return experiencia;
        }
        public UAspirante modificarExperienciaL(Int32 Idexp, String nombre, String cargo, String jefe, String telefono, String funcion, Int32 id_experiencia, String nombre_empresa, String funciones)
        {
            DAspirante datosEL = new DAspirante();
            DataTable modificarExperiencia = datosEL.EditarExpl(Idexp, nombre, cargo, jefe, telefono, funcion, id_experiencia, nombre_empresa, funciones);

            UAspirante experiencia = new UAspirante();



            experiencia.Url = "Modificar_H_Aspi.aspx";
            return experiencia;
        }

        public DataTable mostrarOfertaCompleta(Int32 idOferta)
        {

            DataTable muestraO = new DataTable();
            DAspirante oferta = new DAspirante();
            muestraO = oferta.obtenerOferta(idOferta);
            return muestraO;
        }

        public UAspirante RTipoEmpleo(UAspirante tipoEmpleo, Int32 idRegistro, String TerminoCon, String Horario, String TiempoEmpleo, String Hoja, String Sesion)
        {
            DAspirante tipoE = new DAspirante();
            DataTable Tipoempleo = tipoE.TipoE(idRegistro, TerminoCon, Horario, TiempoEmpleo, Hoja, Sesion);

            UAspirante enviarm = new UAspirante();

            //enviarm.Url = @"<script type='text/javascript'>Redir_InicioAspirante();</script>";
            enviarm.Url = "VerOfertas.aspx";
            enviarm.Mensaje = "Registrado correctamente";
            return enviarm;
        }

	public UAspirante ValidacionUrl(UAspirante link)
        {
            if (link.IdUser.Equals(null) ||  link.UserName.Equals(null) || link.RolId.Equals(null) || link.RolId != 2)
            {
                link.IdUser.Equals(null);
                link.UserName.Equals(null);
                link.RolId.Equals(null);
                link.Url = @"<script type='text/javascript'>Redir_Login();</script>";
                
            }

            return link;
        }
        public UAspirante ValidacionHora(UAspirante hora)
        {
            UAspirante ValFecha = new UAspirante();
            if (hora.FechaNacimiento > hora.ControlTime)
            {
                ValFecha.Mensaje = "No puede seleeccionar una fecha anterior";
            }
            else
            {
                DAspirante llenaDatosP = new DAspirante();
                llenaDatosP.RegistraAspirante(hora);
                ValFecha.Url2= @"<script type='text/javascript'>Redir_FormacionA();</script>";
                ValFecha.Url = "FormacionA.aspx";

            }
            return ValFecha;
        }
        public UAspirante ValiUrlVO(UAspirante linksito)
        {
            UAspirante deusoVO = new UAspirante();
            if (linksito.IdUser.Equals(null) || linksito.UserName.Equals(null) || linksito.RolId.Equals(null) || linksito.RolId != 2)
            {
                deusoVO.IdUser.Equals(null);
                deusoVO.UserName.Equals(null);
                deusoVO.RolId.Equals(null);
                deusoVO.Url = @"<script type='text/javascript'>Redir_Login();</script>";
                
            }

            return deusoVO;
        }
        public DataTable BusquedaOferta(UAspirante buscar)
        {
            UAspirante buscarO = new UAspirante();
            DAspirante busqueda = new DAspirante();
            DataTable busquedaOferta = busqueda.BuscarOfertas(buscar);

            if (busquedaOferta.Rows.Count > 0)
            {
                buscarO.LabelVisible = false;
            }
            else
            {
                buscarO.LabelVisible = true;
                buscarO.Mensaje = "¡Ops! no hemos encontrado una oferta similar a '" + buscar + "', prueba quizá con otras palabras";
            }

            return busquedaOferta;
        }
        public DataTable obtenerPerfil(UAspirante perfilsito)
        {

            DAspirante llevaIdAsp = new DAspirante();
            DataTable llevarPerfilAsp = llevaIdAsp.obtenerPerfil(perfilsito);
            return llevarPerfilAsp;
        }

	public UAspirante EnviarFacade(UAspirante faspi)
        
	{


            
	   DAspirante formacion = new DAspirante();
            
	   DataTable academica = formacion.FormacionA(faspi);

            UAspirante enviarm = new UAspirante();
            enviarm.Url = @"<script type='text/javascript'>Dire_expl();</script>";
            enviarm.Mensaje = "Registrado correctamente";
            enviarm.MensajeError = "NO SE PUEDE REGISTRAR UNA FECHA ANTERIOR A ESTA";
            return enviarm;


        }
	
	public DataTable mostrar(Int32 idc)
        {

           
            DAspirante datos = new DAspirante();
            DataTable muestra = datos.obtenerComentarios(idc);
            UAspirante capturar = new UAspirante();

            




            capturar.Url = "VerPerfilAspirante.aspx";
            return muestra;


        }

	

   
	 public DataTable mostrarFacae(Int32 idf)
        {


            DAspirante datos = new DAspirante();
            DataTable muestra = datos.obtenerFacae(idf);
            UAspirante capturar = new UAspirante();






            capturar.Url = "Modificar_H_Aspi.aspx";
            return muestra;


        }

        public DataTable editarFacae(Int32 Idf, String titulo, String Lugar, String Telefono, String Habi1, String Habi2, String Habi3, Int32 id_formacion, String habilidad1, String habilidad2, String habilidad3, String lugar_grado, String telefono_lugar)
        {


            DAspirante datos = new DAspirante();
            DataTable muestra = datos.EditarFacae( Idf,  titulo,  Lugar,  Telefono,  Habi1,  Habi2,  Habi3,  id_formacion,  habilidad1, habilidad2, habilidad3, lugar_grado, telefono_lugar);
            UAspirante capturar = new UAspirante();






            capturar.Url = "Modificar_H_Aspi.aspx";
            return muestra;


        }
        public UAspirante ValidaHoras(UAspirante control)
        {
            UAspirante validacion = new UAspirante();


            if (control.Finicio > control.Ffin)
            {
                validacion.MensajeError = "NO SE PUEDE REGISTRAR UNA FECHA";
            }
            else
            {
                DAspirante registrar = new DAspirante();
                registrar.Exlaboral(control);
                validacion.Url = @"<script type = 'text/javascript'>Dire_expl();</script>";

            }
            return validacion;
        }



        /*public UAspirante ValidacionUrl(UAspirante link)
        {
            if (link.Idr.Equals(null)  || link.Idr.Equals(null) || link.Idr != 2)
            {
                link.Idr.Equals(null);
                
                link.Idrol.Equals(null);
                link.Url = @"<script type='text/javascript'>Dire_log();</script>";

            }

            return link;
        }
        */

        public UAspirante ValidaHoy(UAspirante control)
        {
            UAspirante validacion = new UAspirante();


            if (control.Fecha > control.Hoy)
            {
                validacion.MensajeError = "NO SE PUEDE REGISTRAR UNA FECHA";
            }
            else
            {
                DAspirante registrar = new DAspirante();
                registrar.FormacionA(control);
                validacion.Url2 = "ExperienciaL.aspx";
                validacion.Url = @"<script type = 'text/javascript'>Dire_expl();</script>";

            }
            return validacion;
        }

        public DataTable mostrartipoe(Int32 idf)
        {


            DAspirante datos = new DAspirante();
            DataTable muestratipo = datos.obtenerTipoe(idf);
            UAspirante capturar = new UAspirante();






            capturar.Url = "Modificar_H_Aspi.aspx";
            return muestratipo;


        }

        public DataTable editartipoe(Int32 Idf, String terminoc, String horarioT, String TiempoC, Int32 id_tipo_empleo, String termino_empleo, String horario_empleo, String tiempo_empleo)
        {


            DAspirante datos = new DAspirante();
            DataTable muestra = datos.EditarTipoe( Idf,  terminoc,  horarioT,  TiempoC, id_tipo_empleo, termino_empleo, horario_empleo, tiempo_empleo);
            UAspirante capturar = new UAspirante();






            capturar.Url = "Modificar_H_Aspi.aspx";
            return muestra;


        }

    }
}
