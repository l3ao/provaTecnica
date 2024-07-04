using MediatR;
using ProvaTecnica.Domain.Entities.v1;
using ProvaTecnica.Domain.Interfaces.v1;
using TechnicalTest.Application.Clients.Commands.v1;

namespace TechnicalTest.Application.Clients.Handlers.v1;

public sealed class ClientCreateCommandHandler : IRequestHandler<ClientCreateCommand, Client>
{
    private readonly IClientRepository _clientRepository;
    private readonly ICompanyRepository _companyRepository;

    public ClientCreateCommandHandler(IClientRepository clientRepository, ICompanyRepository companyRepository)
    {
        _clientRepository = clientRepository;
        _companyRepository = companyRepository;
    }

    public async Task<Client> Handle(ClientCreateCommand request, CancellationToken cancellationToken)
    {
        var company = await _companyRepository.GetByIdAsync(request.CompanyId);
        
        if (company == null)
            throw new Exception("Empresa não encontrada.");
        
        var client = new Client(request.Name, request.Document, request.Address,
            request.PhoneNumber, request.CompanyId, company);

        if (client == null)
            throw new Exception("Erro ao criar o registro de cliente.");
        
        return await _clientRepository.CreateAsync(client!);
    }
}