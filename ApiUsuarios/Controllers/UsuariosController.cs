using ApiUsuarios.Models;
using ApiUsuarios.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiUsuarios.Controllers
{
    [Route("api/[Controller]")]
    public class UsuariosController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepositorio;

        public UsuariosController(IUsuarioRepository usuarioRepo)
        {
            _usuarioRepositorio = usuarioRepo;
        }

        [HttpGet]
        public IEnumerable<Usuario> GetAll()
        {
            return _usuarioRepositorio.GetAll();
        }

        [HttpGet("{id}", Name = "GetUsuario")]
        public IActionResult GetById(int id)
        {
            var user = _usuarioRepositorio.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            return new ObjectResult(user);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Usuario user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            _usuarioRepositorio.Add(user);

            return CreatedAtRoute("GetUsuario", new { id = user.Usuario_id }, user);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Usuario user)
        {
            if (user == null || user.Usuario_id != id)
            {
                return BadRequest();
            }

            var entity = _usuarioRepositorio.Find(id);
            if (entity == null)
            {
                return NotFound();
            }

            //entity = user;
            entity.Email = user.Email;
            entity.Senha = user.Senha;
            entity.Nome = user.Nome;

            _usuarioRepositorio.Update(entity);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var entity = _usuarioRepositorio.Find(id);
            if (entity == null)
            {
                return NotFound();
            }

            _usuarioRepositorio.Remove(id);
            return new NoContentResult();
        }

    }
}
