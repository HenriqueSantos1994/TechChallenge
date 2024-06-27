using FIAP.TechChallenge.ByteMeBurguer.Domain.Entities;
using FIAP.TechChallenge.ByteMeBurguer.Application.Models.Request;
using FIAP.TechChallenge.ByteMeBurguer.Application.UseCases.Interfaces;
using FIAP.TechChallenge.ByteMeBurguer.Domain.Repositories;

namespace FIAP.TechChallenge.ByteMeBurguer.Application.UseCases
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
            var categoria = _categoriaRepository.GetByName(request.NomeCategoria);
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
