using MediatR;
using ProvaTecnica.Domain.Entities.v1;
using ProvaTecnica.Domain.Interfaces.v1;
using TechnicalTest.Application.Clients.Commands.v1;

namespace TechnicalTest.Application.Clients.Handlers.v1;

public sealed class ClientUpdateCommandHandler : IRequestHandler<ClientUpdateCommand, Client>
{
    private readonly IClientRepository _clientRepository;

    public ClientUpdateCommandHandler(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public async Task<Client> Handle(ClientUpdateCommand request, CancellationToken cancellationToken)
    {
        var client = await _clientRepository.GetByIdAsync(request.Id);

        if (client == null)
            throw new ApplicationException("Empresa não encontrada.");
        
        client!.Update(request.Name, request.Document, request.Address,
            request.PhoneNumber, request.CompanyId!.Value, null);

        return await _clientRepository.UpdateAsync(client);
    }
}