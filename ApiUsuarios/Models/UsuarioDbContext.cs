using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiUsuarios.Models
{
    public class UsuarioDbContext : DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }

        public UsuarioDbContext(DbContextOptions<UsuarioDbContext> options) : base(options)
        {

        }

    }
}
