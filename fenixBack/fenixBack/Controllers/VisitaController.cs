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

        [HttpPost]
        [Route("api/visita/pesquisar")]
        public List<Visita> Pesquisar([FromBody] Pesquisa dado)
        {

            abrigofenixEntities1 entities = new abrigofenixEntities1();
            DateTime dadoAux;
          
            var visitaAux = new Visita();
            if (DateTime.TryParse(dado.dado, out dadoAux))
                visitaAux = entities.Visita.FirstOrDefault(visita => visita.dataVisita == dadoAux);

            if (visitaAux == null)
                return entities.Visita.ToList();
            else
            {
                var visitaList = new List<Visita>();
                visitaList.Add(visitaAux);
                return visitaList;
            }
        }


        [HttpPost]
        [Route("api/visita/atualizar")]
        public bool atualizar([FromBody] Visita visitaInput)
        {
            abrigofenixEntities1 entities = new abrigofenixEntities1();
            var visitaAux = entities.Visita.FirstOrDefault(visita => visita.idVisita == visitaInput.idVisita);
            if (visitaAux == null)
                return false;
            entities.Visita.Remove(visitaAux);
            entities.Visita.Add(visitaInput);
            entities.SaveChanges();
            return true;
        }
    }
}