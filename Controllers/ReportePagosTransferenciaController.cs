using API2.Data;
using API2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API2.Controllers
{
    public class ReportePagosTransferenciaController : ApiController
    {
        [HttpGet]
        [Route("api/ReportePagosTransferencia")]
        public List<ReportePagosTransferencia> Get()
        {          
         
                return UsuarioData.ListarReporte();
           
        }
    }
}