using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using CapaEntidad;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class UsuarioBL : Interface.iUsuario
    {
        private Datos datos = new DatosSQL();
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
        }
        public bool Login(Usuario usuario)
        {
            //try
            //{
                DataRow fila = datos.TraerDataRow("spLoginCliente", usuario._Usuario, usuario._Contrasena);
                mensaje = fila["Mensaje"].ToString();
                byte codError = Convert.ToByte(fila["CodError"]);
                if (codError == 0) return true;
                else return false;
            //}
            //catch (SqlException ex)
            //{
            //    mensaje = "Error: " + ex.Message;
            //    return false;
            //}
            //catch (Exception ex)
            //{
            //    mensaje = "Error: " + ex.Message;
            //    return false;
            //}
            //DataRow fila = datos.TraerDataRow("spLoginCliente", usuario._Usuario, usuario._Contrasena);
            //mensaje = fila["Mensaje"].ToString();
            //byte codError = Convert.ToByte(fila["CodError"]);
            //if (codError == 0) return true;
            //else return false;
        }
    }
}
