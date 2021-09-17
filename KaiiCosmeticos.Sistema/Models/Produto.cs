using System;
using System.ComponentModel.DataAnnotations;

namespace KaiiCosmeticos.Sistema.Models
{
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }
        public string UnidadeDeMedida { get; set; }
        public float PrecoCusto { get; set; }
        public float PrecoVenda { get; set; }
        public int IdFornecedor { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public int IdFabricante { get; set; }
        public Fornecedor Fabricante { get; set; }
        public string Tipo { get; set; }
        public bool Visivel { get; set; }

    }
}
