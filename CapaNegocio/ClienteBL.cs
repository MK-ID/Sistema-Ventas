using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;      

using CapaDatos;
namespace CapaNegocio
{
    public class ClienteBL : Interface.iCliente
    {
        private Datos datos = new DatosSQL();
        private string mensaje;
        private string Mensaje
        {
            get { return mensaje; }
        }
        public bool Actualizar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public bool Agregar(Cliente cliente)
        {
            DataRow fila = datos.TraerDataRow("spAgregarCliente", cliente.CodCliente, cliente.Apellidos, cliente.Nombres, cliente.Direccion,cliente.Usuario, cliente.Contrasena);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarCliente", texto, criterio);
        }

        public bool Eliminar(string CodCliente)
        {
            DataRow fila = datos.TraerDataRow("spEliminarCliente", CodCliente);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarVendedor");
        }
    }
}
