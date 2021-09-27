using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;

namespace CapaNegocios
{
    public class VendedorBL : Interface.IVendedor
    {
        private Datos datos = new DatosSQL();
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
        }
        public bool Actualizar(CVendedor vendedor)
        {
            throw new NotImplementedException();
        }

        public bool Agregar(CVendedor vendedor)
        {
            DataRow fila = datos.TraerDataRow("spAgregarVendedor", vendedor.CodVendedor, vendedor.Apellidos,
                vendedor.Nombres, vendedor.Usuario, vendedor.Contrasena);
            mensaje = fila["Mensaje"].ToString();
            byte coderror = Convert.ToByte(fila["CodError"]);
            if (coderror == 0) return true;
            else return true;
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
