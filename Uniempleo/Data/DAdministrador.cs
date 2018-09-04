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
    public class DAdministrador
    {
        public DataTable registroAdminisrador(String CorreoA, String usuarioA, String ClaveA, Int32 rol)
        {
            DataTable perfil = new DataTable();
            NpgsqlConnection conexion = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("uniempleo.f_registro_emp", conexion);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_correo", NpgsqlDbType.Text).Value = CorreoA;
                dataAdapter.SelectCommand.Parameters.Add("_usuario", NpgsqlDbType.Text).Value = usuarioA;
                dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Text).Value = ClaveA;
                dataAdapter.SelectCommand.Parameters.Add("_rol", NpgsqlDbType.Integer).Value = rol;
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
