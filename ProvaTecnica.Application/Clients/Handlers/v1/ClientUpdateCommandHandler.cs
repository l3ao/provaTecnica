using MediatR;
using ProvaTecnica.Domain.Entities.v1;
using ProvaTecnica.Domain.Interfaces.v1;
using TechnicalTest.Application.Clients.Commands.v1;

namespace TechnicalTest.Application.Clients.Handlers.v1;

public sealed class ClientUpdateCommandHandler : IRequestHandler<ClientUpdateCommand, Client>
{
    private readonly IClientRepository _clientRepository;
    private readonly ICompanyRepository _companyRepository;

    public ClientUpdateCommandHandler(IClientRepository clientRepository, ICompanyRepository companyRepository)
    {
        _clientRepository = clientRepository;
        _companyRepository = companyRepository;
    }

    public async Task<Client> Handle(ClientUpdateCommand request, CancellationToken cancellationToken)
    {
        if (request.CompanyId.HasValue)
        {
            var company = await _companyRepository.GetByIdAsync(request.CompanyId!.Value);
        
            if (company == null)
                throw new Exception("Empresa não encontrada.");
        }
        
        var client = await _clientRepository.GetByIdAsync(request.Id);

        if (client == null)
            throw new ApplicationException("Cliente não encontrado.");
        
        client!.Update(request.Name, request.Document, request.Address,
            request.PhoneNumber, request.CompanyId!.Value, null);

        return await _clientRepository.UpdateAsync(client);
    }
}