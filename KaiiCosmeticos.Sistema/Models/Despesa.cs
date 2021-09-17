using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaiiCosmeticos.Sistema.Models
{
    public class Despesa
    {   
        [Key]
        public int IdDespesa { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public float Valor { get; set; }
        public DateTime Data { get; set; }
    }
}
