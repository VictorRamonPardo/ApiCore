using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tutorial.Interface;
using Tutorial.Model;
using Tutorial.Repository;

namespace Tutorial.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase {

        private IUsuario usuarios = new UsuariosRepository();

        [HttpGet]
        // https://localhost:44324/api/usuarios
        public IEnumerable<Usuario> Get() {
            return usuarios.GetAll();
        }

        [HttpGet("{id}")]
        // https://localhost:44324/api/usuarios/2
        public Usuario Get(int id) {
            return usuarios.Get(id);
        }

        [HttpPost]
        // https://localhost:44324/api/usuarios/
        public Usuario CreateUsuario(Usuario item) {
            return usuarios.Add(item);
        }

        [HttpPut]
        // https://localhost:44324/api/usuarios
        public bool UpdateUsuario(Usuario item) {
            return usuarios.Update(item);
        }

        [HttpDelete]
        // https://localhost:44324/api/usuarios/2
        public void DeleteUsuario(int id) {
            usuarios.Remove(id);
        }
    }
}
