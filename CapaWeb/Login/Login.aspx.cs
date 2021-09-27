using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

using CapaServicio;
using System.Data.SqlClient;

namespace CapaWeb.Login
{
    public partial class Login : System.Web.UI.Page
    {
        private ServiceReferenceUsuario.wsClienteSoapClient servicio = new ServiceReferenceUsuario.wsClienteSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            login__email.Focus();
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string Usuario = login__email.Text.Trim();
            string Contrasena = login__password.Text.Trim();
            if (servicio.Login(Usuario, Contrasena).ElementAt(0).ToString() == "0")
            {
                Response.Redirect("~/Login/Bienvenida.aspx?Name=" + servicio.Login(Usuario, Contrasena).ElementAt(1).ToString() + "");
            }
            else if (servicio.Login(Usuario, Contrasena).ElementAt(0).ToString() == "1")
            {
                Response.Write("<script language='JavaScript'>alert('" + servicio.Login(Usuario, Contrasena).ElementAt(1).ToString() + "');</script>");
            }
            else
            {
                Response.Write("<script language='JavaScript'>alert('" + servicio.Login(Usuario, Contrasena).ElementAt(1).ToString() + "');</script>");
            }
        }
    }
}