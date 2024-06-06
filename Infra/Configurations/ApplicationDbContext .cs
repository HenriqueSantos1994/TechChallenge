using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Configurations
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<FormaPagamento> FormasPagamento { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .Property(x => x.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<FormaPagamento>()
                .Property(x => x.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Cliente>()
                .Property(x => x.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Produto>()
                .Property(x => x.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Categoria>()
                .Property(x => x.Id).ValueGeneratedOnAdd();

            //modelBuilder.Entity<Categoria>().HasData(
            //    new Categoria { Id = 1, Nome = "Lanche" });
            //modelBuilder.Entity<Categoria>().HasData(
            //    new Categoria { Id = 2, Nome = "Acompanhamento" });
            //modelBuilder.Entity<Categoria>().HasData(
            //    new Categoria { Id = 3, Nome = "Bebida" });
            //modelBuilder.Entity<Categoria>().HasData(
            //    new Categoria { Id = 4, Nome = "Sobremesa" });

            //modelBuilder.Entity<FormaPagamento>().HasData(
            //    new FormaPagamento { Id = 1, Nome = "Mercado Pago" });

            base.OnModelCreating(modelBuilder);
        }


    }


}
