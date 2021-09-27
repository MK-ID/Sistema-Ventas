using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//agregar using
using CapaServicio;

namespace CapaWeb
{
    public partial class WFVenedor : System.Web.UI.Page
    {
        
        private ServiceReferenceVendedor.WSVendedorSoapClient servicio=new ServiceReferenceVendedor.WSVendedorSoapClient();
        private void Listar()
        {
            gvVendedor.DataSource = servicio.Listar();
            gvVendedor.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Listar();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string codVendedor = txtCodVendedor.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();
            if (servicio.Agregar(codVendedor, apellidos, nombres, usuario, contrasena))
            {
                Listar();
                
              
            }
            //Response.Write("<script>alert('"+servicio.mensa+"');</script>");
        }
        
    }
}