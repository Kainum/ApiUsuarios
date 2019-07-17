using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


/*Classe usuário*/
namespace ApiUsuarios.Models
{
    public class Usuario
    {
        [Key]
        public int Usuario_id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }

    }
}
