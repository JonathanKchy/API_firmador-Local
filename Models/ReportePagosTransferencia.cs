using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API2.Models
{
    public class ReportePagosTransferencia
    {
        public string identificacion { get; set; }
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }

        public string TipoDePago { get; set; }
        public string Banco { get; set; }
        public int valor { get; set; }
        public string fecha { get; set; }
        public string numeroTransaccion { get; set; }
        public string numeroFactura { get; set; }
       
    }
}