using System;

namespace ControleInvestimentos.Domain.Entities
{
    public class Investimento
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataEntrada { get; set; }
    }
}