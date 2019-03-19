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
        public Usuario Post([FromBody] Usuario usuarioBody)
        {
            abrigofenixEntities1 entities = new abrigofenixEntities1();
            var usuarioLogado = entities.Usuario.FirstOrDefault(usuario => usuario.email.Equals(usuarioBody.email) && usuario.senha.Equals(usuarioBody.senha));

            if (usuarioLogado == null)
                return null;

            if (entities.Administrador.FirstOrDefault(adm => adm.Usuario_Id.Equals(usuarioLogado.id)) != null)
                usuarioLogado.tipoUsuario = "Administrador";
            else
                usuarioLogado.tipoUsuario = "Usuario";

            return usuarioLogado;
        }
    }
}
