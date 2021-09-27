using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CapaEntidad
{
    [DataContract]
    public class CUsuario
    {
        [DataMember]
        public string _Usuario
        { get; set; }
        public string _Contrasena
        { get; set; }

    }
}
