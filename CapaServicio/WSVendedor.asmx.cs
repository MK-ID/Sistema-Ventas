using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
//buffer de memoria
using System.Data;
using CapaNegocios;
using CapaEntidad;
using System.Diagnostics.SymbolStore;
using System.Web.Services.Description;
using System.Security.Permissions;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de WSVendedor
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WSVendedor : System.Web.Services.WebService
    {

        [WebMethod(Description = "Listar Datos de la tabla vendedor")]
        public DataSet Listar()
        {
            VendedorBL vendedor = new VendedorBL();
            return vendedor.Listar();
        }
        [WebMethod(Description = "Agregar un vendedor a la tabla vendedor")]
        public bool Agregar(string CodVendedor, string Apellidos, string Nombres, string Usuario, string Contrasena)
        {
            CVendedor vendedor = new CVendedor();
            vendedor.CodVendedor = CodVendedor;
            vendedor.Apellidos = Apellidos;
            vendedor.Nombres = Nombres;
            vendedor.Usuario = Usuario;
            vendedor.Contrasena = Contrasena;

            VendedorBL vendedorBL = new VendedorBL();

            if (vendedorBL.Agregar(vendedor))
            {
              
                return true;
               
            }

            else return false;
        }
        
    }
}
