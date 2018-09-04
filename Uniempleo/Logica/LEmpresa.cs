using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;
using Data;
using System.Data;

namespace Logica
{
    public class LEmpresa
    {
        public UEmpresa modificarEmp(Int32 Idemp)
        {
            DEmpresa datosE = new DEmpresa();
            DataTable modificarDatos = datosE.obtenerEmpresa(Idemp);
            UEmpresa datosEmpresa = new UEmpresa();

            datosEmpresa.Url = "Modificar_H_Empresa.aspx";
            return datosEmpresa;
        }

        public UEmpresa modificarEmpresa(Int32 IdEmp, String nombreE, String forma, String direccionE, String telefonoE, String sector, String empleados, String nit, String tipo, String id_empresa, String nombre_empresa, String forma_juridica, String direccion_empresa, String telefono_empresa, String sector_economico, String num_empleados, String tipo_empresa)
        {
            DEmpresa datosE = new DEmpresa();
            DataTable modificarDatos = datosE.EditarEmpresa(IdEmp, nombreE, forma, direccionE, telefonoE, sector, empleados, nit, tipo, id_empresa, nombre_empresa,
                                                            forma_juridica, direccion_empresa, telefono_empresa, sector_economico, num_empleados, tipo_empresa);
            UEmpresa datosEmpresa = new UEmpresa();

            datosEmpresa.Url = "Modificar_H_.Empresa.aspx";
            return datosEmpresa;
        }

        public DataTable mostrarmiPerfilE(Int32 idperfil)
        {

            DataTable muestraPE = new DataTable();
            DEmpresa miperfile = new DEmpresa();
            muestraPE = miperfile.EmpresaMiPerfil(idperfil);
            return muestraPE;
        }

        public DataTable mostrarmisOfertas(int idO)
        {

            DataTable muestraO = new DataTable();
            DEmpresa misofertas = new DEmpresa();
            muestraO = misofertas.obtenermisOfertas(idO);
            return muestraO;
        }

    }
}
