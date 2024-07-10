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
            CreateMap<FormaPagamentoResponse, FormaPagamento>().ReverseMap();
            CreateMap<Pedido, PedidoResponse>()
                .ForMember(dest => dest.ItensDePedido, opt => opt.MapFrom(src => src.ItensDePedido))
                .ReverseMap();
            CreateMap<ItemDePedido, ItensDePedidoResponse>()
               .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Produto.Nome))
               .ForMember(dest => dest.Descricao, opt => opt.MapFrom(src => src.Produto.Descricao))
               .ForMember(dest => dest.Categoria, opt => opt.MapFrom(src => src.Produto.CategoriaProduto.Nome))
               .ForMember(dest => dest.ValorUnitario, opt => opt.MapFrom(src => src.Produto.Valor))
               .ReverseMap();
        }
    }
}
