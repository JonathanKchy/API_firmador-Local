using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;
using System.Web.Http;
using API2.Models;
using API2.Data;

namespace API2.Controllers
{
    public class UsuariosEnProcesoController : ApiController
    {


        [HttpPost]
        [Route("api/usuariosEnProceso")]
        public List<UsuariosEnProceso> Get([FromBody] AccesoUsuario request)
        {
            return UsuarioData.ListarUsuariosEnProceso(request);

        }
        
    }
}