﻿using FIAP.TechChallenge.ByteMeBurguer.Application.Models.Request;

namespace FIAP.TechChallenge.ByteMeBurguer.Application.UseCases.Interfaces
{
    public interface IAtualizarProdutoUseCase : IUseCaseAsync<AtualizarProdutoRequest, bool>
    {
    }
}
