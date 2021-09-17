using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaiiCosmeticos.Sistema.Models
{
    public class PedidoVendas
    {
        [Key]
        public int IdPedido { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVenda { get; set; }
        public string TipoFrete { get; set; }
        public Frete Frete { get; set; }
        public Transportadora Transportadora { get; set; }
        public string Vendedor { get; set; }
        public float ValorTotal { get; set; }
        public float Lucro { get; set; }
        public float Descontos { get; set; }
        public ICollection<Promocoes> PromocoesAplicadas { get; set; }
        public ICollection<Produto> Produtos { get; set; }
        public string Status { get; set; }//Em progresso, finalizada....
    }
}
