using AutoMapper;
using FIAP.TechChallenge.ByteMeBurguer.Application.Models.Response;
using FIAP.TechChallenge.ByteMeBurguer.Application.UseCases.Interfaces;
using FIAP.TechChallenge.ByteMeBurguer.Domain.Repositories;

namespace FIAP.TechChallenge.ByteMeBurguer.Application.UseCases
{
    public class ObterProdutoPorCategoriaUseCase : IObterProdutoPorCategoriaUseCase
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IMapper _mapper;

        public ObterProdutoPorCategoriaUseCase(IProdutoRepository repository, ICategoriaRepository categoriaRepository, IMapper mapper)
        {
            _produtoRepository = repository;
            _categoriaRepository = categoriaRepository;
            _mapper = mapper;
        }

        public IList<ItensDePedidoResponse> Execute(string request)
        {
            var result = new List<ItensDePedidoResponse>();
            var categoria = _categoriaRepository.GetByName(request);

            if (categoria is null)
                return result;

            var produtos = _produtoRepository.GetByCategoria(categoria.Id);

            return _mapper.Map<IList<ItensDePedidoResponse>>(produtos);
        }
    }
}