using Application.Models.Response;
using Application.UseCases.Interfaces;
using AutoMapper;
using Domain.Repositories;

namespace Application.UseCases
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

        public async Task<IList<ProdutoResponse>> Execute(string request)
        {
            var categoria = await _categoriaRepository.GetByName(request);
            var result = await _produtoRepository.GetByCategoria(categoria.Id);

            return _mapper.Map<IList<ProdutoResponse>>(result);
        }
    }
}