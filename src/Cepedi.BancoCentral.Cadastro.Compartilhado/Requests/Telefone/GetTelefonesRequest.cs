using Cepedi.BancoCentral.Cadastro.Compartilhado.Responses;
using MediatR;
using OperationResult;

namespace Cepedi.BancoCentral.Cadastro.Compartilhado.Requests.Telefone;

public class GetTelefonesRequest : IRequest<Result<List<GetTelefonesResponse>>>
{
    
}