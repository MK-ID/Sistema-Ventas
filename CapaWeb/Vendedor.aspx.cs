using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CapaServicio;
namespace CapaWeb
{
    public partial class Vendedor : System.Web.UI.Page
    {
        private ServiceReferenceVendedor.wsVendedorSoapClient servicio = new ServiceReferenceVendedor.wsVendedorSoapClient();
        private void Listar()
        {
            gvVendedor.DataSource = servicio.Listar();
            gvVendedor.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Listar();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string codVendedor = txtCodVendedor.Text.Trim();
            string Apellidos = txtApellidos.Text.Trim();
            string Nombres = txtNombres.Text.Trim();
            string Usuario = txtUsuario.Text.Trim();
            string Contrasena = txtContrasena.Text.Trim();
            if (servicio.Agregar(codVendedor, Apellidos, Nombres, Usuario, Contrasena) == true)
            {
                Response.Write("<script language='JavaScript'>alert('Insertado correctamente vendedor');</script>");
                Listar();
            }
            else Response.Write("<script language='JavaScript'>alert('Error: Usuario ya existe');</script>");
        }
    }
}