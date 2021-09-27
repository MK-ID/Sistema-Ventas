using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CapaDatos;
using System.Web.Security;
using System.Data;
using CapaNegocio;
using CapaEntidad;
using System.Security.Cryptography.X509Certificates;
using System.Web.UI.WebControls;


namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de WebServiceCliente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceCliente : System.Web.Services.WebService
    {
        Datos datos = new DatosSQL();

        [WebMethod(Description = "Listar datos de la tabla Vendedor")]
        public DataSet Listar()
        {
            ClienteBL cliente = new ClienteBL();
            return cliente.Listar();
        }

        [WebMethod(Description = "Agregar un vendedor a la tabla Vendedor")]
        public bool Agregar(string CodCliente, string Apellidos, string Nombres, string Direccion, string Usuario, string Contrasena)
        {
            Cliente cliente = new Cliente();
            cliente.CodCliente = CodCliente;
            cliente.Apellidos = Apellidos;
            cliente.Nombres = Nombres;
            cliente.Direccion = Direccion;
            cliente.Usuario = Usuario;
            cliente.Contrasena = Contrasena;
            ClienteBL clienteBL = new ClienteBL();
            if (clienteBL.Agregar(cliente)) return true;
            else return false;

        }
        public bool Eliminar()
        {
            DataRow fila = datos.TraerDataRow("spEliminarCliente", CodCliente);
            byte CodError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (CodError == 0) return true;
            else return false;
        }
        public bool Actualizar()
        {
            DataRow fila = datos.TraerDataRow("spActualizarCliente", Usuario, Contrasena);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }
        public DataTable Buscar(string texto, string criterio)
        {
            return datos.TraerDataTable("spBuscarCliente", texto, criterio);
        }

        public partial class Login : System.Web.UI.Page
        {
            protected void Page_Load(object sender, EventArgs e)
            {
                Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            }
            ServiceReferenceUsuario.wsClienteSoapClient servicio = new ServiceReferenceUsuario.wsClienteSoapClient();

            protected void LoginCliente(object sender, AuthenticateEventArgs e)
            {
                string usuario = LoginInicio.UserName;
                string contrasena = LoginInicio.Password;
                string[] rsta = servicio.Login(usuario, contrasena).ToArray();
                string codError = rsta[0];
                string mensaje = rsta[1];
                if (codError == "true")
                {
                    FormsAuthentication.RedirectFromLoginPage(mensaje, false);
                }
                else
                {
                    //lInicio.FailureText = "Usuario y/o contraseñas incorrectas";
                    LoginInicio.FailureText = mensaje;
                }
            }
        }
    }
}
