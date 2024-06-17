﻿namespace FIAP.TechChallenge.ByteMeBurguer.Application.UseCases.Interfaces
{
    public interface IUseCase<T1, T2>
    {
        Task<T2> Execute(T1 request);
    }

    public interface IUseCase<T1>
    {
        Task<T1> Execute();
    }
}
