using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaiiCosmeticosSistema.Models
{
    public class Frete
    {
        [Key]
        public int IdFrete { get; set; }
        public string CodigoId { get; set; }
        public float Valor { get; set; }
        public int TransportadoraId { get; set; }
        public Transportadora Transportadora { get; set; }
    }
}
