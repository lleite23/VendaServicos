using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Distribuidora.Entities
{
    public class Categoria
    {
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public ICollection<Servicos> Servicos { get; set; }
    }
}
