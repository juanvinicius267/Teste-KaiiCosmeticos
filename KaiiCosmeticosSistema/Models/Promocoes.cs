using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaiiCosmeticosSistema.Models
{
    public class Promocoes
    {
        [Key]
        public int IdPromocoes { get; set; }
        public int IdProduto { get; set; }
        public Produto Produto { get; set; }
        public float ValorPorc { get; set; }
        public float Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

    }
}
