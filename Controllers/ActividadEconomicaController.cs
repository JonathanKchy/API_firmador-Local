using API2.Data;
using API2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API2.Controllers
{
    public class ActividadEconomicaController : ApiController
    {
        [HttpGet]
        [Route("api/funciones/Actividad")]
        public List<ActividadEconomica> Get([FromBody]FunctionRequest variable)
        {

            if (variable.numero1.Equals(1))
            {
                return UsuarioData.ListarActividad();
            }
            else
                return null;
            
        }
    }
}