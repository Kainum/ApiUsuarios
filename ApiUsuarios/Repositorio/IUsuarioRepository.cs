using ApiUsuarios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiUsuarios.Repositorio
{
    public interface IUsuarioRepository
    {

        IEnumerable<Usuario> GetAll();
        void Add(Usuario user);
        Usuario Find(int id);
        void Remove(int id);
        void Update(Usuario user);

    }
}
