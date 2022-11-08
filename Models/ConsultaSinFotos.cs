using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API2.Models
{
    public class ConsultaSinFotos
    {
       
        public string ci { get; set; }
        public string nombre { get; set; }
        public string segundoNombre { get; set; }
        public string apellido { get; set; }
        public string segundoApellido { get; set; }
        public string numeroSolicitud { get; set; }
        public string fechaEmision { get; set; }
        public string fechaVencimiento { get; set; }
        public string correo { get; set; }
        public string celular { get; set; }
        public string telefono { get; set; }
        public string ciudad { get; set; }
        public string sector { get; set; }
        public string direccionPersonal { get; set; }
        public string direccionOficina { get; set; }
        public string ip { get; set; }
        public int idSolicitudCertificado { get; set; }
        public string actividadEconomica { get; set; }
        public string ruc { get; set; }
    }
}