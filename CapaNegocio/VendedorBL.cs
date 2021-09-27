using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;

namespace CapaNegocio
{
    public class VendedorBL : Interface.IVendedor
    {
        private Datos datos = new DatosSQL();
        private string mensaje;
        private string Mensaje
        {
            get { return mensaje; }
        }
        public bool Actualizar(Vendedor vendedor)
        {
            throw new NotImplementedException();
        }

        public bool Agregar(Vendedor vendedor)
        {
            DataRow fila = datos.TraerDataRow("spAgregarVendedor", vendedor.CodVenddor, vendedor.Apellidos, vendedor.Nombres,vendedor.Usuario,vendedor.Contrasena);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(string CodVendedor)
        {
            throw new NotImplementedException();
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarVendedor");
        }
    }
}
