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
        abrigofenixEntities1 entities = new abrigofenixEntities1();

        [HttpGet]
        [Route("api/usuario/")]
        public List<Usuario>listUsuario()
            {
            var usuario = entities.Usuario.ToList();
            return usuario;
      
            }



        [HttpGet]
        [Route("api/usuario/tipo")]
        public List<TipoUsuario> listaTipoUsuario()
        {
            var tipoUsuario = entities.TipoUsuario.ToList();
            return tipoUsuario;
        }











    }
}