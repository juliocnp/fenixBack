using fenixBack.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace fenixBack.Controllers
{
    public class EstoqueController: ApiController
    {
        [HttpGet]
        [Route("api/estoque/lista")]
        public List<Estoque> listaEstoque()
        {
            abrigofenixEntities1 entities = new abrigofenixEntities1();
            var estoque = entities.Estoque.ToList();
            return estoque;
        }

        [HttpGet]
        [Route("api/estoque/listaCategorias")]
        public List<string> listaCategorias()
        {
            abrigofenixEntities1 entities = new abrigofenixEntities1();
            var estoque = entities.EstoqueCat.ToList();
            return estoque.Select(x => x.nomeCategoria).ToList();
        }

        [HttpPost]
        [Route("api/estoque/inserir")]
        public bool inserir([FromBody] Estoque estoqueInput)
        {
            abrigofenixEntities1 entities = new abrigofenixEntities1();
            entities.Estoque.Add(estoqueInput);
            entities.SaveChanges();
            if (entities.Estoque.FirstOrDefault(estoque => estoque.id == estoqueInput.id) != null)
                return true;
            else
                return false;
        }

        [HttpPost]
        [Route("api/estoque/atualizar")]
        public bool atualizar([FromBody] Estoque estoqueInput)
        {
            abrigofenixEntities1 entities = new abrigofenixEntities1();
            var estoqueAux = entities.Estoque.FirstOrDefault(estoque => estoque.id == estoqueInput.id);
            if (estoqueAux == null)
                return false;
            entities.Estoque.Remove(estoqueAux);
            entities.Estoque.Add(estoqueInput);
            entities.SaveChanges();
            return true;
        }
    }
}