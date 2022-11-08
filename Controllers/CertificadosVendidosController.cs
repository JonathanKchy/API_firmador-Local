using API2.Data;
using API2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API2.Controllers
{
    public class CertificadosVendidosController : ApiController
    {
        [HttpGet]
        [Route("api/CertificadosVendidos")]
        public int Get([FromBody]Fecha request)
        {


            return UsuarioData.ListarCertificadosVendidos(request.tiempo);

        }
    }
}