using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaiiCosmeticosSistema.Models
{
    public class TipoPagamento
    {
        [Key]
        public int IdPagamento { get; set; }
        public string Descricao { get; set; }
    }
}
