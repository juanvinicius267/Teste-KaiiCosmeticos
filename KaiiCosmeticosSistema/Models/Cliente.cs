using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KaiiCosmeticosSistema.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string OrgExpeditor { get; set; }
        public char Tipo { get; set; } //F ou J Fisica ou Juridica
        public bool Situacao { get; set; } //Ativo ou Desativo
        public int Telefone { get; set; }
        public int IdEndereco { get; set; }
        public Endereco Endereco { get; set; }
    }
}
