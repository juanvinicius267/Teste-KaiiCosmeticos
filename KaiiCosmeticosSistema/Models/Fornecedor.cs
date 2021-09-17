using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaiiCosmeticosSistema.Models
{
    public class Fornecedor
    {
        [Key]
        public int IdFornecedor { get; set; }
        public string RazãoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string InsEstadual { get; set; }
        public string Cnpj { get; set; }
        public string Email { get; set; }
        public string OrgExpeditor { get; set; }
        public char Tipo { get; set; } //Fab ou Forn 
        public bool Situacao { get; set; } //Ativo ou Desativo
        public int Telefone { get; set; }
        public int IdEndereco { get; set; }
        public Endereco Endereco { get; set; }
    }
}
