using MediatR;
using ProvaTecnica.Domain.Entities.v1;
using ProvaTecnica.Domain.Interfaces.v1;
using TechnicalTest.Application.Clients.Commands.v1;

namespace TechnicalTest.Application.Clients.Handlers.v1;

public sealed class ClientCreateCommandHandler : IRequestHandler<ClientCreateCommand, Client>
{
    private readonly IClientRepository _clientRepository;

    public ClientCreateCommandHandler(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public async Task<Client> Handle(ClientCreateCommand request, CancellationToken cancellationToken)
    {
        var client = new Client(request.Name, request.Document, request.Address,
            request.PhoneNumber, request.CompanyId!.Value, null);

        if (client == null)
            throw new Exception("Erro ao criar o registro de cliente.");
        
        return await _clientRepository.CreateAsync(client!);
    }
}