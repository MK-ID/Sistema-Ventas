using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SeguridadFrontEnd
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        }
        ServiceReferenceUsuario.wsClienteSoapClient servicio = new ServiceReferenceUsuario.wsClienteSoapClient();

        protected void lInicio_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string usuario = lInicio.UserName;
            string contrasena = lInicio.Password;
            string[] rsta = servicio.Login(usuario, contrasena).ToArray();
            string codError = rsta[0];
            string mensaje = rsta[1];
            if (codError == "true")
            {
                FormsAuthentication.RedirectFromLoginPage(mensaje,false);
            }
            else
            {
                //lInicio.FailureText = "Usuario y/o contraseñas incorrectas";
                lInicio.FailureText = mensaje;
            }
        }
    }
}