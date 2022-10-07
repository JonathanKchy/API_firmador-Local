using API2.Data;
using API2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API2.Controllers
{
    public class TicketsController : ApiController
    {
        [HttpGet]
        [Route("api/Tickets")]
        public List<Tickets> Get()
        {

            return UsuarioData.ListarTicket();

        }
    }
}