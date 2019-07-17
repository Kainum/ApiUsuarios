using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiUsuarios.Models;

namespace ApiUsuarios.Repositorio
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly UsuarioDbContext _context;

        public UsuarioRepository(UsuarioDbContext ctx)
        {
            _context = ctx;
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _context.Usuarios.ToList();
        }

        public void Add(Usuario user)
        {
            _context.Usuarios.Add(user);
            _context.SaveChanges();
        }

        public Usuario Find(int id)
        {
            return _context.Usuarios.FirstOrDefault(user => user.Usuario_id == id);
        }

        public void Remove(int id)
        {
            var entity = _context.Usuarios.First(user => user.Usuario_id == id);
            _context.Usuarios.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Usuario user)
        {
            _context.Usuarios.Update(user);
            _context.SaveChanges();
        }
    }
}
