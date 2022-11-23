using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API2.Models
{
    public class UsuariosEnProceso
    {
        public string identificacion { get; set; }
        public string correo { get; set; }
        public string estado { get; set; }
        public string fechaRegistro { get; set; }

    }
}