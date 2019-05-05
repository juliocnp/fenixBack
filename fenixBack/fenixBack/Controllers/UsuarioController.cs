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

        [HttpPost]
        [Route("api/usuario/")]
        public bool inserir([FromBody] Usuario usuarioInput)
        {
            entities.Usuario.Add(usuarioInput);
            entities.SaveChanges();
            if (entities.Usuario.FirstOrDefault(usuario => usuario.id == usuarioInput.id) != null)
                return true;
            else
                return false;
        }

        [HttpPut]
        [Route("api/usuario/")]
        public bool atualizar([FromBody] Usuario usuarioInput)
        {
            var usuarioAux = entities.Usuario.FirstOrDefault(usuario => usuario.id == usuarioInput.id);
            if (usuarioAux == null)
                return false;
            entities.Entry(usuarioAux).State = System.Data.Entity.EntityState.Modified;
            entities.Entry(usuarioAux).CurrentValues.SetValues(usuarioInput);
            entities.SaveChanges();
            return true;
        }

        [HttpDelete]
        [Route("api/usuario/")]
        public bool remover([FromBody] Usuario usuarioInput)
        {
            entities.Usuario.Attach(usuarioInput);
            entities.Usuario.Remove(usuarioInput);
            entities.SaveChanges();
            if (entities.Usuario.FirstOrDefault(usuario => usuario.id == usuarioInput.id) != null)
                return true;
            else
                return false;
        }

        [HttpGet]
        [Route("api/usuario/tipo")]
        public List<TipoUsuario> listaTipoUsuario()
        {
            var tipoUsuario = entities.TipoUsuario.ToList();
            return tipoUsuario;
        }

        [HttpPost]
        [Route("api/usuario/GroupItensTipoUsuario")]
        public List<Usuario> Pesquisar([FromBody] Pesquisa dado)
        {
            int dadoAux;
            var usuarioAux = new List<Usuario>();
            if (int.TryParse(dado.dado, out dadoAux))
                usuarioAux = entities.Usuario.Where(usuario => usuario.TipoUsuario.id == dadoAux).ToList();
            if (usuarioAux == null)
                return entities.Usuario.ToList();
            else
            {
                var UsuarioList = new List<Usuario>();
                UsuarioList = usuarioAux;
                return UsuarioList;
            }
        }









    }
}