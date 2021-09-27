using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaNegocios.Interface
{
    interface IUsuario
    {
        bool login(CUsuario usuario);
    }
}
