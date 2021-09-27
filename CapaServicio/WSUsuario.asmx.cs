using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using CapaNegocios;
using CapaEntidad;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de WSUsuario
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WSUsuario : System.Web.Services.WebService
    {

        [WebMethod(Description = "Login Usuario")]
        public string[] Login(string Usuario, string Contrasena)
        {
            CUsuario usuario = new CUsuario();
            usuario._Usuario = Usuario;
            usuario._Contrasena = Contrasena;
            UsuarioBL usuarioBL = new UsuarioBL();
            string[] respuesta = new string[2];
            bool codError = usuarioBL.login(usuario);
            if (codError == true) respuesta[0] = "true";
            else respuesta[0] = "false";
            respuesta[1] = usuarioBL.Mensaje;
            return respuesta;
        }
    }
}
