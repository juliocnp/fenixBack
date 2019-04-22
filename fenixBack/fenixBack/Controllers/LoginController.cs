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
        public Usuario Post([FromBody] Login usuarioBody)
        {
            if (usuarioBody == null)
                return null;

            abrigofenixEntities1 entities = new abrigofenixEntities1();
            var usuarioLogado = entities.Usuario.FirstOrDefault(usuario => usuario.email.Equals(usuarioBody.email) && usuario.senha.Equals(usuarioBody.senha));

            if (usuarioLogado == null)
                return null;

            return usuarioLogado;
        }
    }
}
