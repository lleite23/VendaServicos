﻿using System.ComponentModel.DataAnnotations;

namespace Distribuidora.Entities
{
    public class Produtos
    {
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
