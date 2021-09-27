using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data;

namespace CapaNegocios.Interface
{
    interface IVendedor
    {
        DataSet Listar();
        bool Agregar(CVendedor vendedor);
        bool Eliminar(string CodVendedor);
        bool Actualizar(CVendedor vendedor);
        DataSet Buscar(string texto, string criterio);
    }
}
