using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaiiCosmeticosSistema.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string TipoDeAcesso { get; set; }
        public string Cargo { get; set; }
    }
}
