using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
namespace CapaNegocio.Interface
{
    interface iCliente
    {
        DataSet Listar();
        bool Agregar(Cliente cliente);
        bool Eliminar(string CodCliente);
        bool Actualizar(Cliente cliente);
        DataSet Buscar(string texto, string criterio);
    }
}
