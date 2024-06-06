using Application.Models.Request;
using Application.UseCases.Interfaces;
using Domain.Entities;
using Domain.Repositories;

namespace Application.UseCases
{
    public class AtualizarProdutoUseCase : IAtualizarProdutoUseCase
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly ICategoriaRepository _categoriaRepository;

        public AtualizarProdutoUseCase(IProdutoRepository repository, ICategoriaRepository categoriaRepository)
        {
            _produtoRepository = repository;
            _categoriaRepository = categoriaRepository;
        }

        public async Task<bool> Execute(AtualizarProdutoRequest request)
        {
            var categoria = await _categoriaRepository.GetByName(request.NomeCategoria);
            var produto = new Produto()
            {
                Id = request.Id,
                Nome = request.Nome,
                Descricao = request.Descricao,
                Valor = request.Valor,
                CategoriaProduto = categoria
            };
            await _produtoRepository.Update(produto);

            return true;
        }
    }
}
