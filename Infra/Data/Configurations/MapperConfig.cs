using AutoMapper;
using FIAP.TechChallenge.ByteMeBurguer.Application.Models.Response;
using FIAP.TechChallenge.ByteMeBurguer.Domain.Entities;

namespace FIAP.TechChallenge.ByteMeBurguer.Infra.Data.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<ClienteResponse, Cliente>().ReverseMap();
            CreateMap<ProdutoResponse, Produto>().ReverseMap()
                .ForMember(x => x.NomeCategoria, y => y.MapFrom(x => x.CategoriaProduto.Nome));
            CreateMap<FormaPagamentoResponse, FormaPagamento>().ReverseMap();
            CreateMap<PedidoResponse, Pedido>().ReverseMap();
        }
    }
}
