using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;

namespace CapaNegocio.Interface
{
        interface IVendedor
        {
            DataSet Listar();
            bool Agregar(Vendedor vendedor);
            bool Eliminar(string CodVendedor);
            bool Actualizar(Vendedor vendedor);
            DataSet Buscar(string texto, string criterio);
        }
}
