﻿using Cepedi.BancoCentral.Cadastro.Compartilhado.Enums;
using Cepedi.BancoCentral.Cadastro.Dominio.Entidades;
using Cepedi.BancoCentral.Cadastro.Dominio.Repository;
using Cepedi.BancoCentral.Cadastro.Compartilhado.Requests;
using Cepedi.BancoCentral.Cadastro.Compartilhado.Responses;
using MediatR;
using Microsoft.Extensions.Logging;
using OperationResult;

namespace Cepedi.BancoCentral.Cadastro.Dominio.Handlers;
public class CriarPessoaRequestHandler
    : IRequestHandler<CriarPessoaRequest, Result<CriarPessoaResponse>>
{
    private readonly ILogger<CriarPessoaRequestHandler> _logger;
    private readonly IPessoaRepository _pessoaRepository;

    public CriarPessoaRequestHandler(IPessoaRepository pessoaRepository, ILogger<CriarPessoaRequestHandler> logger)
    {
        _pessoaRepository = pessoaRepository;
        _logger = logger;
    }

    public async Task<Result<CriarPessoaResponse>> Handle(CriarPessoaRequest request, CancellationToken cancellationToken)
    {
        var pessoa = new PessoaEntity()
        {
            Nome = request.Nome,
            DataNascimento = request.DataNascimento,
            Cpf = request.Cpf,
            Genero = request.Genero,
            EstadoCivil = request.EstadoCivil,
            Nacionalidade = request.Nacionalidade
        };

        await _pessoaRepository.CriarPessoaAsync(pessoa);

        return Result.Success(new CriarPessoaResponse(pessoa.IdPessoa, pessoa.Nome));
    }
}
