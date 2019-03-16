using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using fenixBack.DataAccess;

namespace fenixBack.Controllers
{
    public class LoginController : ApiController
    {
        [HttpPost]
        public bool Post([FromBody] string email, [FromBody] string senha)
        {
            abrigofenixEntities1 entities = new abrigofenixEntities1();
            var usuarioLogado = entities.Usuario.FirstOrDefault(usuario => usuario.email.Equals(email) && usuario.senha.Equals(senha));
            if (usuarioLogado != null)
                return true;
            else
                return false;
        }
    }
}
