using MediatR;
using ProvaTecnica.Domain.Entities;
using ProvaTecnica.Domain.Entities.v1;
using ProvaTecnica.Domain.Interfaces.v1;
using TechnicalTest.Application.Companies.Commands.v1;

namespace TechnicalTest.Application.Companies.Handlers.v1;

public class CompanyCreateCommandHandler : IRequestHandler<CompanyCreateCommand, Company>
{
    private readonly ICompanyRepository _repository;

    public CompanyCreateCommandHandler(ICompanyRepository repository)
    {
        _repository = repository;
    }

    public async Task<Company> Handle(CompanyCreateCommand request, CancellationToken cancellationToken)
    {
        var company = new Company(request.Name, request.Size);

        if (company == null)
            throw new Exception("Erro ao criar empresa.");
        
        return await _repository.CreateAsync(company!);
    }
}