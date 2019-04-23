﻿using fenixBack.DataAccess;
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
    }
}