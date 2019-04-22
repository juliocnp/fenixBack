using fenixBack.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace fenixBack.Controllers
{
    public class Pesquisa
    {
        public string dado { get; set; }
    }
    public class JovemController : ApiController
    {
        [HttpGet]
        [Route("api/jovem/lista")]
        public List<Jovem> listaJovem()
        {
            abrigofenixEntities1 entities = new abrigofenixEntities1();
            var jovens = entities.Jovem.ToList();
            return jovens;
        }

        [HttpPost]
        [Route("api/jovem/inserir")]
        public bool inserir([FromBody] Jovem jovemInput)
        {
            abrigofenixEntities1 entities = new abrigofenixEntities1();
            entities.Jovem.Add(jovemInput);
            entities.SaveChanges();
            if (entities.Jovem.FirstOrDefault(jovem => jovem.id == jovemInput.id) != null)
                return true;
            else
                return false;
        }

        [HttpPost]
        [Route("api/jovem/atualizar")]
        public bool atualizar([FromBody] Jovem jovemInput)
        {
            abrigofenixEntities1 entities = new abrigofenixEntities1();
            var jovemAux = entities.Jovem.FirstOrDefault(jovem => jovem.id == jovemInput.id);
            if (jovemAux == null)
                return false;
            entities.Jovem.Remove(jovemAux);
            entities.Jovem.Add(jovemInput);
            entities.SaveChanges();
            return true;
        }

        [HttpPost]
        [Route("api/jovem/pesquisar")]
        public List<Jovem> Pesquisar([FromBody] Pesquisa dado)
        {
            abrigofenixEntities1 entities = new abrigofenixEntities1();
            int dadoAux;
            var jovemAux = new Jovem();
            if (int.TryParse(dado.dado, out dadoAux))
                jovemAux = entities.Jovem.FirstOrDefault(jovem => jovem.id == dadoAux);
            else
                jovemAux = entities.Jovem.FirstOrDefault(jovem => jovem.nome == dado.dado);

            
            if (jovemAux == null)
                return entities.Jovem.ToList();
            else
            {
                var jovemList = new List<Jovem>();
                jovemList.Add(jovemAux);
                return jovemList;
            }
        }
    }
}
