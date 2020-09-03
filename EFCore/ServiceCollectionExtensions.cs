using System;
using ControleInvestimentos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EFCore
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDataAccessServices(this IServiceCollection service, string connectionString)
        {
            service.AddEntityFrameworkNpgsql()
            .AddDbContext<ControleInvestimentosContext>(
                opt => opt.UseNpgsql(
                    connectionString
                )
            );
        }
    }
}
