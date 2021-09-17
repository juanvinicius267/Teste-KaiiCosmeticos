using System.ComponentModel.DataAnnotations;

namespace KaiiCosmeticosSistema.Models
{
    public class Endereco
    {
        [Key]
        public int IdEndereco { get; set; }
        public string Logradouro { get; set; }//Rua
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
    }
}