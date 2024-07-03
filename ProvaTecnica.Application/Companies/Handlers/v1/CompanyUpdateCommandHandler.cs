using MediatR;
using ProvaTecnica.Domain.Entities;
using ProvaTecnica.Domain.Entities.v1;
using ProvaTecnica.Domain.Interfaces.v1;
using TechnicalTest.Application.Companies.Commands.v1;

namespace TechnicalTest.Application.Companies.Handlers.v1;

public sealed class CompanyUpdateCommandHandler : IRequestHandler<CompanyUpdateCommand, Company>
{
    private readonly ICompanyRepository _repository;

    public CompanyUpdateCommandHandler(ICompanyRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<Company> Handle(CompanyUpdateCommand request, CancellationToken cancellationToken)
    {
        var company = await _repository.GetByIdAsync(request.Id);

        if (company == null)
            throw new ApplicationException("Empresa não encontrada.");
        
        company!.Update(request.Name);

        return await _repository.UpdateAsync(company);
    }
}