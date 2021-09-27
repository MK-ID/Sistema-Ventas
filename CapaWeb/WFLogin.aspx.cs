using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaServicio;
using System.Data;

namespace CapaWeb
{
    public partial class WFLogin : System.Web.UI.Page
    {
        private ServiceReferenceUsuario.WSUsuarioSoapClient servicio = new ServiceReferenceUsuario.WSUsuarioSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text.Trim();
            string contrasena = txtPassword.Text.Trim();
            var value = servicio.Login(user, contrasena)[0];
            if(value == "true")
            {
                Response.Write("<script>alert('"+ value + "')</script>");
            }    

            Response.Write("<script>alert('" + servicio.Login(user, contrasena).ElementAt(1).ToString() + "');</script>");
        }
    }
}