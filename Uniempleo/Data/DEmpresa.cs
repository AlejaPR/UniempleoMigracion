using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;

namespace Data
{
    public class DEmpresa
    {
        public DataTable obtenerEmpresa(Int32 idemp) //Int32 _id_asp
        {
            DataTable perfil = new DataTable();
            NpgsqlConnection conexion = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("uniempleo.f_obtener_empresag", conexion);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_asp", NpgsqlDbType.Integer).Value = idemp;

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

        public DataTable EditarEmpresa(Int32 idE, String nombreE, String forma, String direccionE, String telefonoE, String sector, String empleados, String nit, String tipo, String id_empresa, String nombre_empresa, String forma_juridica, String direccion_empresa, String telefono_empresa, String sector_economico, String num_empleados, String tipo_empresa)
        {
            DataTable datosE = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("uniempleo.f_modificar_empresa", conection);

                dataAdapter.SelectCommand.Parameters.Add("_id_emp", NpgsqlDbType.Integer).Value = id_empresa;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = nombre_empresa;
                dataAdapter.SelectCommand.Parameters.Add("_forma", NpgsqlDbType.Text).Value = forma_juridica;
                dataAdapter.SelectCommand.Parameters.Add("_direccion", NpgsqlDbType.Text).Value = direccion_empresa;
                dataAdapter.SelectCommand.Parameters.Add("_telefono", NpgsqlDbType.Text).Value = telefono_empresa;
                dataAdapter.SelectCommand.Parameters.Add("_sector", NpgsqlDbType.Text).Value = sector_economico;
                dataAdapter.SelectCommand.Parameters.Add("_empleados", NpgsqlDbType.Integer).Value = num_empleados;
                dataAdapter.SelectCommand.Parameters.Add("_nit", NpgsqlDbType.Text).Value = nit;
                dataAdapter.SelectCommand.Parameters.Add("_tipo", NpgsqlDbType.Text).Value = tipo_empresa;
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

        public DataTable EmpresaMiPerfil(Int32 idEmpresa)
        {
            DataTable datosE = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("uniempleo.miperfile", conection);
                dataAdapter.SelectCommand.Parameters.Add("_idempresa", NpgsqlDbType.Integer).Value = idEmpresa;
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

        public DataTable obtenermisOfertas(Int32 idO)
        {
            DataTable perfil = new DataTable();
            NpgsqlConnection conexion = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("uniempleo.f_misofertas", conexion);
                dataAdapter.SelectCommand.Parameters.Add("_id_emp", NpgsqlDbType.Integer).Value = idO;
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


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
    }
}
