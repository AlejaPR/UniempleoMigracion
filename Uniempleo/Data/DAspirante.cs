using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using System.Configuration;
using System.Data;
using Utilitarios;

namespace Data
{
    public class DAspirante
    {
        

       public DataTable VerificaHV(int id)
        {
            DataTable datosE = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("uniempleo.f_verificar_hoja_aspirante", conection);
                dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id;
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                conection.Open();
                dataAdapter.Fill(datosE);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return datosE;
        }

        public DataTable cerrarSesion(Int32 sesion)//
        {
            DataTable user = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("seguridad.f_cerrar_session", conectar);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                dataAdapter.SelectCommand.Parameters.Add("_session", NpgsqlDbType.Text).Value = sesion;
                conectar.Open();
                dataAdapter.Fill(user);

            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conectar != null)
                {
                    conectar.Close();//
                }
            }
            return user;
        }
        public DataTable obtenerPuntos(Int32 idperfil) //Int32 _id_asp
        {
            DataTable perfil = new DataTable();
            NpgsqlConnection conexion = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("uniempleo.f_obtener_puntaje_asp_emp", conexion);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_asp", NpgsqlDbType.Integer).Value = idperfil;
                //dataAdapter.SelectCommand.Parameters.Add("_estado", NpgsqlDbType.Integer).Value = estado;

                conexion.Open();
                dataAdapter.Fill(perfil);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }
            return perfil;
        }

        public DataTable ObtienePuntosTotales(Int32 idc) //Int32 _id_asp
        {
            DataTable perfil = new DataTable();
            NpgsqlConnection conexion = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("uniempleo.f_obtener_puntos_totales_aspirante", conexion);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_asp", NpgsqlDbType.Integer).Value = idc;

                conexion.Open();
                dataAdapter.Fill(perfil);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }
            return perfil;
        }
        public DataTable modificarPerfil(Int32 idper) //Int32 _id_asp
        {
            DataTable perfil = new DataTable();
            NpgsqlConnection conexion = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("uniempleo.f_obtener_datosp", conexion);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_asp", NpgsqlDbType.Integer).Value = idper;

                conexion.Open();
                dataAdapter.Fill(perfil);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }
            return perfil;
        }

        public DataTable Editardp(Int32 Idpm, String Nombre, String Apellido, String Nacimiento, String Direccion, String Celular, String Estado, String documento, String sexo, Int32 id_aspirante, String nombre_aspirante, String apellido_aspirante, String fecha_nacim, String direccion_asp, String telefono_asp, String estado_civil)
        {
            DataTable datosE = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("uniempleo.f_modificar_datos_personales", conection);

                dataAdapter.SelectCommand.Parameters.Add("_id_aspi", NpgsqlDbType.Integer).Value = id_aspirante;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = nombre_aspirante;
                dataAdapter.SelectCommand.Parameters.Add("_apellido", NpgsqlDbType.Text).Value = apellido_aspirante;
                dataAdapter.SelectCommand.Parameters.Add("_fecha", NpgsqlDbType.Date).Value = fecha_nacim;
                dataAdapter.SelectCommand.Parameters.Add("_direccion", NpgsqlDbType.Text).Value = direccion_asp;
                dataAdapter.SelectCommand.Parameters.Add("_telefono", NpgsqlDbType.Text).Value = telefono_asp;
                dataAdapter.SelectCommand.Parameters.Add("_estadoc", NpgsqlDbType.Text).Value = estado_civil;
                dataAdapter.SelectCommand.Parameters.Add("_documento", NpgsqlDbType.Text).Value = documento;
                dataAdapter.SelectCommand.Parameters.Add("_sexo", NpgsqlDbType.Text).Value = sexo;

                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                conection.Open();
                dataAdapter.Fill(datosE);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return datosE;

        }
        public DataTable obtenerExpL(Int32 idper) //Int32 _id_asp
        {
            DataTable perfil = new DataTable();
            NpgsqlConnection conexion = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("uniempleo.f_obtener_expl", conexion);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_asp", NpgsqlDbType.Integer).Value = idper;

                conexion.Open();
                dataAdapter.Fill(perfil);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }
            return perfil;
        }

        public DataTable EditarExpl(Int32 Idexp, String nombre, String cargo, String jefe, String telefono, String funcion, Int32 id_experiencia, String nombre_empresa, String funciones)
        {
            DataTable datosE = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("uniempleo.f_modificar_expl", conection);

                dataAdapter.SelectCommand.Parameters.Add("_id_exp", NpgsqlDbType.Integer).Value = id_experiencia;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = nombre_empresa;
                dataAdapter.SelectCommand.Parameters.Add("_cargo", NpgsqlDbType.Text).Value = cargo;
                dataAdapter.SelectCommand.Parameters.Add("_jefe", NpgsqlDbType.Text).Value = jefe;
                dataAdapter.SelectCommand.Parameters.Add("_telefono", NpgsqlDbType.Text).Value = telefono;
                dataAdapter.SelectCommand.Parameters.Add("_funcion", NpgsqlDbType.Text).Value = funciones;



                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                conection.Open();
                dataAdapter.Fill(datosE);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return datosE;

        }

        public DataTable obtenerOferta(Int32 idOferta)
        {
            DataTable datosE = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("uniempleo.obtener_datosoferta", conection);
                dataAdapter.SelectCommand.Parameters.Add("_idofertas", NpgsqlDbType.Integer).Value = idOferta;
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                conection.Open();
                dataAdapter.Fill(datosE);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return datosE;
        }

        public DataTable TipoE(Int32 idRegistro, String TerminoCon, String Horario, String TiempoEmpleo, String Hoja, String Sesion)//
        {
            DataTable datosT = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("uniempleo.f_tipo_empleo", conectar);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                dataAdapter.SelectCommand.Parameters.Add("_id_registro", NpgsqlDbType.Integer).Value = idRegistro;
                dataAdapter.SelectCommand.Parameters.Add("_terminoe", NpgsqlDbType.Text).Value = TerminoCon;
                dataAdapter.SelectCommand.Parameters.Add("_horarioe", NpgsqlDbType.Text).Value = Horario;
                dataAdapter.SelectCommand.Parameters.Add("_tiempoe", NpgsqlDbType.Text).Value = TiempoEmpleo;
                dataAdapter.SelectCommand.Parameters.Add("_hoja", NpgsqlDbType.Varchar).Value = Hoja;
                dataAdapter.SelectCommand.Parameters.Add("_sesion", NpgsqlDbType.Text).Value = Sesion;


                conectar.Open();
                dataAdapter.Fill(datosT);

            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conectar != null)
                {
                    conectar.Close();
                }
            }
            return datosT;
        }

	public DataTable RegistraAspirante(UAspirante enviarR1)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("uniempleo.f_registrar_aspirante", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Varchar).Value = enviarR1.Nombre;
                dataAdapter.SelectCommand.Parameters.Add("_apellido", NpgsqlDbType.Varchar).Value = enviarR1.Apellido;
                dataAdapter.SelectCommand.Parameters.Add("_nacimiento", NpgsqlDbType.Date).Value = enviarR1.FechaNacimiento;
                dataAdapter.SelectCommand.Parameters.Add("_direccion", NpgsqlDbType.Varchar).Value = enviarR1.DireccionP;
                dataAdapter.SelectCommand.Parameters.Add("_celular", NpgsqlDbType.Varchar).Value = enviarR1.CelularP;
                dataAdapter.SelectCommand.Parameters.Add("_documento", NpgsqlDbType.Varchar).Value = enviarR1.DocumentoP;
                dataAdapter.SelectCommand.Parameters.Add("_estado", NpgsqlDbType.Varchar).Value = enviarR1.Estadocivil;
                dataAdapter.SelectCommand.Parameters.Add("_sexo", NpgsqlDbType.Varchar).Value = enviarR1.Sexo;
                dataAdapter.SelectCommand.Parameters.Add("_foto", NpgsqlDbType.Varchar).Value = enviarR1.Foto;
                dataAdapter.SelectCommand.Parameters.Add("_sesion", NpgsqlDbType.Varchar).Value = enviarR1.Sesion;
                dataAdapter.SelectCommand.Parameters.Add("_idaspirante", NpgsqlDbType.Integer).Value = enviarR1.IdUser;
                dataAdapter.SelectCommand.Parameters.Add("_e_stado", NpgsqlDbType.Integer).Value = enviarR1.Estado;
                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }
        public DataTable BuscarOfertas(UAspirante buscare)
        {
            DataTable user = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("uniempleo.f_buscar_ofertas", conectar);
                dataAdapter.SelectCommand.Parameters.Add("_buscar", NpgsqlDbType.Text).Value = buscare.Busqueda;
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                dataAdapter.Fill(user);

            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            finally
            {
                if (conectar != null)
                {
                    conectar.Close();//
                }
            }
            return user;
        }
        public DataTable obtenerPerfil(UAspirante idper) //Int32 _id_asp
        {
            DataTable perfil = new DataTable();
            NpgsqlConnection conexion = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("uniempleo.f_obtener_perfil", conexion);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_asp", NpgsqlDbType.Integer).Value = idper.IdUser;

                conexion.Open();
                dataAdapter.Fill(perfil);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }
            return perfil;
        }

	public DataTable Exlaboral(UAspirante expl )//
        {
            DataTable datosR = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("uniempleo.f_exp_laboral", conectar);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                dataAdapter.SelectCommand.Parameters.Add("_nombreemp", NpgsqlDbType.Text).Value = expl.Nombre;
                dataAdapter.SelectCommand.Parameters.Add("_cargo", NpgsqlDbType.Text).Value = expl.Cargo;
                dataAdapter.SelectCommand.Parameters.Add("_jefe", NpgsqlDbType.Text).Value = expl.Jefe;
                dataAdapter.SelectCommand.Parameters.Add("_telefono", NpgsqlDbType.Text).Value = expl.TelefonoEmpresa;
                dataAdapter.SelectCommand.Parameters.Add("_funcionesd", NpgsqlDbType.Text).Value = expl.Funciones;
                dataAdapter.SelectCommand.Parameters.Add("_id_registro", NpgsqlDbType.Integer).Value = expl.Idr;
                dataAdapter.SelectCommand.Parameters.Add("_fechainicio", NpgsqlDbType.Date).Value = expl.Finicio;
                dataAdapter.SelectCommand.Parameters.Add("_fechafin", NpgsqlDbType.Date).Value = expl.Ffin;



                conectar.Open();
                dataAdapter.Fill(datosR);

            }
            catch (Exception Ex)
            {
                throw Ex;
            }

            return datosR;
 
        }

        public DataTable FormacionA(UAspirante aspif)
        {
            DataTable documentos = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("uniempleo.formacion", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                dataAdapter.SelectCommand.Parameters.Add("_titulo", NpgsqlDbType.Text).Value = aspif.Titulo ;
                dataAdapter.SelectCommand.Parameters.Add("_lugarg", NpgsqlDbType.Text).Value = aspif.Lugar;
                dataAdapter.SelectCommand.Parameters.Add("_fechag", NpgsqlDbType.Timestamp).Value = aspif.Fecha;
                dataAdapter.SelectCommand.Parameters.Add("_telefonog", NpgsqlDbType.Text).Value = aspif.TelefonoF;
                dataAdapter.SelectCommand.Parameters.Add("_documentos", NpgsqlDbType.Varchar).Value = aspif.Documento;
                dataAdapter.SelectCommand.Parameters.Add("_habilidad1", NpgsqlDbType.Text).Value = aspif.Habilidad1;
                dataAdapter.SelectCommand.Parameters.Add("_habilidad2", NpgsqlDbType.Text).Value = aspif.Habilidad2;
                dataAdapter.SelectCommand.Parameters.Add("_habilidad3", NpgsqlDbType.Text).Value = aspif.Habilidad3;
                dataAdapter.SelectCommand.Parameters.Add("_idregistro", NpgsqlDbType.Integer).Value = aspif.Idr;



                conection.Open();
                dataAdapter.Fill(documentos);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }

            return documentos;

        }

	 public DataTable obtenerComentarios(Int32 idc) 
        {
            DataTable perfil = new DataTable();
            NpgsqlConnection conexion = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("uniempleo.f_obtener_comentarioaspirante", conexion);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_asp", NpgsqlDbType.Integer).Value = idc;

                conexion.Open();
                dataAdapter.Fill(perfil);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
           
            return perfil;
        }
	
	

        
	public DataTable obtenerFacae(Int32 idper) 
        {
            DataTable perfil = new DataTable();
            NpgsqlConnection conexion = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("uniempleo.f_obtener_facae", conexion);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_asp", NpgsqlDbType.Integer).Value = idper;

                conexion.Open();
                dataAdapter.Fill(perfil);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }
            return perfil;
        }

        public DataTable EditarFacae(Int32 Idf, String titulo, String Lugar, String Telefono, String Habi1, String Habi2, String Habi3, Int32 id_formacion, String habilidad1, String habilidad2, String habilidad3, String lugar_grado, String telefono_lugar)
        {
            DataTable datosE = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("uniempleo.f_modificar_facae", conection);

                dataAdapter.SelectCommand.Parameters.Add("_id_for", NpgsqlDbType.Integer).Value = id_formacion;
                dataAdapter.SelectCommand.Parameters.Add("_titulo", NpgsqlDbType.Text).Value = titulo;
                dataAdapter.SelectCommand.Parameters.Add("_lugar", NpgsqlDbType.Text).Value = lugar_grado;
                dataAdapter.SelectCommand.Parameters.Add("_telefono", NpgsqlDbType.Text).Value = telefono_lugar;
                dataAdapter.SelectCommand.Parameters.Add("_habi1", NpgsqlDbType.Text).Value = habilidad1;
                dataAdapter.SelectCommand.Parameters.Add("_habi2", NpgsqlDbType.Text).Value = habilidad2;
                dataAdapter.SelectCommand.Parameters.Add("_habi3", NpgsqlDbType.Text).Value = habilidad3;


                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                conection.Open();
                dataAdapter.Fill(datosE);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return datosE;

        }

    }
}
