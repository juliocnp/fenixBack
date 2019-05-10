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
        public List<Caixa> listaTransacoes()
        {
            var estoque = entities.Transa.ToList();
            return estoque;
        }

    }
}