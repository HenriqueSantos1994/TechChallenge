using AutoMapper;
using FIAP.TechChallenge.ByteMeBurguer.Application.UseCases;
using FIAP.TechChallenge.ByteMeBurguer.Application.UseCases.Interfaces;
using FIAP.TechChallenge.ByteMeBurguer.Domain.Repositories;
using FIAP.TechChallenge.ByteMeBurguer.Infra.Data.Configurations;
using FIAP.TechChallenge.ByteMeBurguer.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FIAP.TechChallenge.ByteMeBurguer.Infra.Data.Extensions
{
    public static class ServiceExtension
    {
        public static void RegisterDependence(this IServiceCollection services)
        {
            services.RegisterEntityFramework();

            //AutoMapper
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperConfig());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            //Repository
            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<IFormaPagamentoRepository, FormaPagamentoRepository>();
            services.AddTransient<IPedidoRepository, PedidoRepository>();
            services.AddTransient<IProdutoRepository, ProdutoRepository>();

            //UseCase
            services.AddTransient<IAtualizarProdutoUseCase, AtualizarProdutoUseCase>();
            services.AddTransient<ICriarClienteUseCase, CriarClienteUseCase>();
            services.AddTransient<ICriarPedidoUseCase, CriarPedidoUseCase>();
            services.AddTransient<ICriarProdutoUseCase, CriarProdutoUseCase>();
            services.AddTransient<IObterClientePorCpfUseCase, ObterClientePorCpfUseCase>();
            services.AddTransient<IObterClientesUseCase, ObterClientesUseCase>();
            services.AddTransient<IObterPedidoPorIdUseCase, ObterPedidoPorIdUseCase>();
            services.AddTransient<IObterPedidosUseCase, ObterPedidosUseCase>();
            services.AddTransient<IObterProdutoPorCategoriaUseCase, ObterProdutoPorCategoriaUseCase>();
            services.AddTransient<IRemoverProdutoUseCase, RemoverProdutoUseCase>();

        }

        private static void RegisterEntityFramework(this IServiceCollection services)
        {
            //EF Configurations
            var connectionString = Environment.GetEnvironmentVariable("SQLServerConnection");
            Console.WriteLine(connectionString);
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
        }
    }
}
