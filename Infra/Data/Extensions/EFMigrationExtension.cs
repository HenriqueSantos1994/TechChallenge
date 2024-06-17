using FIAP.TechChallenge.ByteMeBurguer.Domain.Entities;
using FIAP.TechChallenge.ByteMeBurguer.Infra.Data.Configurations;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FIAP.TechChallenge.ByteMeBurguer.Infra.Data.Extensions
{
    public static class EFMigrationExtension
    {
        public static void MigrationInitial(this IApplicationBuilder application)
        {
            using (var serviceScope = application.ApplicationServices.CreateScope())
            {
                var serviceDb = serviceScope.ServiceProvider
                    .GetService<ApplicationDbContext>();

                serviceDb.Database.Migrate();

                if (!serviceDb.Categorias.Any())
                {
                    serviceDb.AddRange(
                        new Categoria { Nome = "Lanche" },
                        new Categoria { Nome = "Acompanhamento" },
                        new Categoria { Nome = "Bebida" },
                        new Categoria { Nome = "Sobremesa" },
                        new FormaPagamento { Nome = "Mercado Pago" }
                        );

                    serviceDb.SaveChanges();
                }
            }

        }
    }
}
