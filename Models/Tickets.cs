using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API2.Models
{
    public class Tickets
    {
        public int idTicket { get; set; }
        public string identificacion { get; set; }
        public string nombre { get; set; }
        public string fechaIngreso { get; set; }

        public string detalle { get; set; }
        public string estadoTicket { get; set; }
        public string tipoTicket { get; set; }
        public string fechaCierre { get; set; }
    }
}