using System.Collections.Generic;
using System.Linq;
using Tutorial.Interface;
using Tutorial.Model;

namespace Tutorial.Repository {
    public class UsuariosRepository : IUsuario {
        private List<Usuario> data = new List<Usuario>
        {
            new Usuario { Id = 1, Nombre = "Juan", Apellidos = "Martin" },
            new Usuario { Id = 2, Nombre = "Ines", Apellidos = "Garcia" },
            new Usuario { Id = 3, Nombre = "David", Apellidos = "Lopez" }
        };

        private static UsuariosRepository repo = new UsuariosRepository();

        public static IUsuario GetRepository() {
            return repo;
        }

        public Usuario Add(Usuario item) {
            item.Id = data.Count + 1;
            data.Add(item);

            return item;
        }

        public Usuario Get(int id) {
            var matches = data.Where(r => r.Id == id);

            return matches.Count() > 0 ? matches.First() : null;
        }

        public IEnumerable<Usuario> GetAll() {
            return data;
        }

        public void Remove(int id) {
            Usuario item = Get(id);
            if(item != null) {
                data.Remove(item);
            }
        }

        public bool Update(Usuario item) {
            Usuario storedItem = Get(item.Id);
            if(storedItem != null) {
                storedItem.Nombre = item.Nombre;
                storedItem.Apellidos = item.Apellidos;
                return true;
            } else {
                return false;
            }
        }

    }
}
