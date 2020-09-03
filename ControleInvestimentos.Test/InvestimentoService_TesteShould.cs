using ControleInvestimentos.Domain.Services;
using Xunit;

namespace ControleInvestimentos.Test
{
    public class InvestimentoService_TesteShould
    {
        private readonly InvestimentoService _service;
        public InvestimentoService_TesteShould()
        {
            _service = new InvestimentoService();
        }

        [Theory]
        [InlineData(10)]
        public void Teste_IsTen_ReturnTrue(int value)
        {
            var result = _service.Teste();

            Assert.Equal(value, result);
        }
    }
}