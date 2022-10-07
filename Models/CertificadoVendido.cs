using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API2.Models
{
    public class CertificadoVendido
    {
        public int idPago { get; set; }
        public string numeroFactura { get; set; }
        public string fecha { get; set; }
    }
}