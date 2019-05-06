using fenixBack.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace fenixBack.Controllers
{
    public class Login
    {
        public string email { get; set; }
        public string senha { get; set; }
    }
    public class LoginController : ApiController
    {
        [HttpPost]
        [Route("api/login")]
        public Usuario login([FromBody] Login usuarioBody)
        {
            abrigofenixEntities1 entities = new abrigofenixEntities1();

            var usuario = entities.Usuario.FirstOrDefault(u => u.email == usuarioBody.email);

            if (usuario != null)
            {
                if (usuario.senha == usuario.senha)
                {
                    return usuario;
                }
            }

            return null;
        }
    }
}
