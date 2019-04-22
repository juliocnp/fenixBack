using fenixBack.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace fenixBack.Controllers
{
    public class VisitaController: ApiController
    {
        [HttpGet]
        [Route("api/visita/lista")]
        public List<Visita> listaVisita()
        {
            abrigofenixEntities1 entities = new abrigofenixEntities1();
            var visitas = entities.Visita.ToList();
            return visitas;
        }
    }
}