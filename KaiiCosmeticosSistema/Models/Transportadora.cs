using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaiiCosmeticosSistema.Models
{
    public class Transportadora
    {
        [Key]
        public int IdTransportadora { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Cnpj { get; set; }
    }
}
