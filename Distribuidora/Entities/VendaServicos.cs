using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Distribuidora.Entities
{
    public class VendaServicos
    {
        [Key]
        public int Codigo { get; set; }
        [ForeignKey("CodigoServico")]
        public int CodigoServico { get; set; }
        public double TempoTotal { get; set; } 
        public decimal ValorTotal { get; set; }
        public ICollection<Servicos> Servicos { get; set; }

    }
}
