using System.Collections.Generic;
using Tutorial.Model;

namespace Tutorial.Interface {
    public interface IUsuario {
        IEnumerable<Usuario> GetAll();

        Usuario Get(int id);

        Usuario Add(Usuario item);

        void Remove(int id);

        bool Update(Usuario item);
    }
}
