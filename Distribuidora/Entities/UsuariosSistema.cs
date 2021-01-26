using System.ComponentModel.DataAnnotations;

namespace Distribuidora.Entities
{
    public class UsuariosSistema
    {
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF_CNPJ { get; set; }
        public string Senha { get; set; }
    }
}
