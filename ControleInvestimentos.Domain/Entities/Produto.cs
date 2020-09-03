using ControleInvestimentos.Domain.Enums;

namespace ControleInvestimentos.Domain.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public TipoProdutoEnum TipoProduto { get; set; }
    }
}