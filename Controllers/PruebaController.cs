using API2.Data;
using API2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API2.Controllers
{
    public class PruebaController : ApiController
    {
        [HttpPost]
        [Route("api/funciones/Suma")]
        public decimal GetSuma([FromBody] FunctionRequest request)
        {
            decimal resultado;
            resultado=request.numero1+request.numero2;
            return resultado;
                         
        }
    }
}
