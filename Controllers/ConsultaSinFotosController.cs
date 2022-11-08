using API2.Data;
using API2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace API2.Controllers
{
    public class ConsultaSinFotosController : ApiController
    {
        [HttpGet]
        [Route("api/ConsultaSinFotos")]
        public List<ConsultaSinFotos> Get()
        {
            return UsuarioData.ListarConsultaSinFotos();
        }
    }
}