using fenixBack.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace fenixBack.Controllers
{
    public class UsuarioController : ApiController
    {
        [HttpPost]
        [Route("api/usuario/lista")]
        public List<Usuario>listUsuario()
            {

            abrigofenixEntities1 entities = new abrigofenixEntities1();
            var usuario = entities.Usuario.ToList();
            return usuario;
      
            }

    }
}