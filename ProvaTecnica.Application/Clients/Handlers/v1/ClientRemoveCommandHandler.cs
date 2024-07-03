using MediatR;
using ProvaTecnica.Domain.Interfaces.v1;
using TechnicalTest.Application.Clients.Commands.v1;

namespace TechnicalTest.Application.Clients.Handlers.v1;

public sealed class ClientRemoveCommandHandler : IRequestHandler<ClientRemoveCommand>
{
    private readonly IClientRepository _clientRepository;

    public ClientRemoveCommandHandler(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public async Task Handle(ClientRemoveCommand request, CancellationToken cancellationToken)
    {
        var client = await _clientRepository.GetByIdAsync(request.Id);

        if (client == null)
            throw new AggregateException("Cliente não encontrado.");

        await _clientRepository.RemoveAsync(client!);
    }
}