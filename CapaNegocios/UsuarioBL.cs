using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class UsuarioBL : Interface.IUsuario
    {
        private Datos datos = new DatosSQL();
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
        }
        public bool login(CUsuario usuario)
        {
            DataRow fila = datos.TraerDataRow("spLoginCliente", usuario._Usuario, usuario._Contrasena);
            mensaje = fila["Mensaje"].ToString();
            byte CodError = Convert.ToByte(fila["CodError"]);
            if (CodError == 0) return true;
            else return true;
        }
    }
}
