using fenixBack.DataAccess;
using fenixBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace fenixBack.Controllers
{

    /// <summary>
    /// CRUD de Caixa
    /// GET: Pegar/Listar
    /// POST: Inserir
    /// PUT: Atulizar
    /// </summary>




    public class CaixaController : ApiController
    {

        abrigofenixEntities1 entities = new abrigofenixEntities1();

        [HttpGet]
        [Route("api/caixa/")]
        public List<CAIXA> listaCaixa()
        {
            var caixa = entities.CAIXA.ToList();
            return caixa;
        }


        [HttpPost]
        [Route("api/CAIXA/")]
        public bool inserir([FromBody] CAIXA caixaInput)
        {
            entities.CAIXA.Add(caixaInput);
            entities.SaveChanges();
            if (entities.CAIXA.FirstOrDefault(caixa => caixa.ID_TRANSACAO == caixa.ID_TRANSACAO) != null)
                return true;
            else
                return false;
        }



        [HttpPut]
        [Route("api/CAIXA/")]
        public bool atualizar([FromBody] CAIXA caixaInput)
        {
            var caixaAux = entities.CAIXA.FirstOrDefault(caixa => caixa.ID_TRANSACAO == caixaInput.ID_TRANSACAO);
            if (caixaAux == null)
                return false;
            entities.Entry(caixaAux).State = System.Data.Entity.EntityState.Modified;
            entities.Entry(caixaAux).CurrentValues.SetValues(caixaAux);
            entities.SaveChanges();
            return true;
        }



    }   
}