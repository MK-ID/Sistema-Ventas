using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    [DataContract]
    public class Vendedor
    {
        [DataMember]
        public string CodVenddor
        { get; set; }
        [DataMember]
        public string Apellidos
        { get; set; }
        [DataMember]
        public string Nombres
        { get; set; }
        [DataMember]
        public string Usuario
        { get; set; }
        [DataMember]
        public string Contrasena
        { get; set; }

    }
}
