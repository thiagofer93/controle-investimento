using Microsoft.EntityFrameworkCore;

namespace ControleInvestimentos.Data
{
    public class ControleInvestimentosContext : DbContext
    {
        public ControleInvestimentosContext(DbContextOptions<ControleInvestimentosContext> options) : base(options)
        {

        }
    }
}