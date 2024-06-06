using Application.Models.Request;
using Application.UseCases.Interfaces;
using Domain.Entities;
using Domain.Repositories;

namespace Application.UseCases
{
    public class CriarProdutoUseCase : ICriarProdutoUseCase
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly ICategoriaRepository _categoriaRepository;

        public CriarProdutoUseCase(IProdutoRepository repository, ICategoriaRepository categoriaRepository)
        {
            _produtoRepository = repository;
            _categoriaRepository = categoriaRepository;
        }

        public async Task<bool> Execute(CriarProdutoRequest request)
        {
            var categoria = await _categoriaRepository.GetByName(request.NomeCategoria);
            var produto = new Produto()
            {
                Nome = request.Nome,
                Descricao = request.Descricao,
                Valor = request.Valor,
                CategoriaProduto = categoria
            };
            await _produtoRepository.Post(produto);

            return true;
        }
    }
}
