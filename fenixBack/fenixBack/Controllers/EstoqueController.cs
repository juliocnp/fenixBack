using fenixBack.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace fenixBack.Controllers
{
    /// <summary>
    /// CRUD do Estoque e Categorias do Estoque
    /// GET: Pegar/Listar
    /// POST: Inserir
    /// PUT: Atulizar
    /// DELETE: Excluir
    /// </summary>
 
    public class EstoqueController: ApiController
    {
     
        abrigofenixEntities1 entities = new abrigofenixEntities1();

   
        [HttpGet]
        [Route("api/estoque/")]
        public List<Estoque> listaEstoque()
        {       
            var estoque = entities.Estoque.ToList();
            return estoque;
        }


        [HttpPost]
        [Route("api/estoque/")]
        public bool inserir([FromBody] Estoque estoqueInput)
        {
            entities.Estoque.Add(estoqueInput);
            entities.SaveChanges();
            if (entities.Estoque.FirstOrDefault(estoque => estoque.id == estoqueInput.id) != null)
                return true;
            else
                return false;
        }

        [HttpPut]
        [Route("api/estoque/")]
        public bool atualizar([FromBody] Estoque estoqueInput)
        {
            var estoqueAux = entities.Estoque.FirstOrDefault(estoque => estoque.id == estoqueInput.id);
            if (estoqueAux == null)
                return false;
            entities.Entry(estoqueAux).State = System.Data.Entity.EntityState.Modified;
            entities.Entry(estoqueAux).CurrentValues.SetValues(estoqueInput);
            entities.SaveChanges();
            return true;
        }

        [HttpDelete]
        [Route("api/estoque/")]
        public bool remover([FromBody] Estoque estoqueInput)
        {
            entities.Estoque.Attach(estoqueInput);
            entities.Estoque.Remove(estoqueInput);
            entities.SaveChanges();
            if (entities.Estoque.FirstOrDefault(estoque => estoque.id == estoqueInput.id) != null)
                return true;
            else
                return false;
        }

        [HttpGet]
        [Route("api/estoque/categoria")]
        public List<EstoqueCat> listaCategorias()
        {
            var estoqueCat = entities.EstoqueCat.ToList();
            return estoqueCat;
        }

        [HttpPost]
        [Route("api/estoque/categoria")]
        public List<Estoque> Pesquisar([FromBody] Pesquisa dado)
        {
            int dadoAux;
            var estoqueAux = new List<Estoque>();
            if (int.TryParse(dado.dado, out dadoAux))
                estoqueAux = entities.Estoque.Where(estoque => estoque.EstoqueCat.id == dadoAux).ToList();
            if (estoqueAux == null)
                return entities.Estoque.ToList();
            else
            {
                var estoqueList = new List<Estoque>();
                estoqueList = estoqueAux;
                return estoqueList;
            }
        }
    }
}