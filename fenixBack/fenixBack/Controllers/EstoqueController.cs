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
        public  List <EstoqueCat> listaCategorias()
        {
            abrigofenixEntities1 entities = new abrigofenixEntities1();
            var estoqueCat = entities.EstoqueCat.ToList();
            //return estoqueCat.Select(x => x.EstoqueCat).ToList();
            return estoqueCat;

            //return estoqueCat.Select(x => new { x.id, x.nomeCategoria }).ToList();

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

        [HttpPost]
        [Route("api/estoque/pesquisarCategoria")]
        public List<Estoque> Pesquisar([FromBody] Pesquisa dado)
        {
            abrigofenixEntities1 entities = new abrigofenixEntities1();
            int dadoAux;
            var estoqueAux = new Estoque();
            if (int.TryParse(dado.dado, out dadoAux))

                estoqueAux = entities.Estoque.FirstOrDefault(estoque => estoque.EstoqueCat.id == dadoAux);


            if (estoqueAux == null)
                return entities.Estoque.ToList();
            else
            {
                var estoqueList = new List<Estoque>();
                estoqueList.Add(estoqueAux);
                return estoqueList;
            }
        }
    }
}