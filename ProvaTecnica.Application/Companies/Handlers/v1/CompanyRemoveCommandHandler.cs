using MediatR;
using ProvaTecnica.Domain.Entities;
using ProvaTecnica.Domain.Entities.v1;
using ProvaTecnica.Domain.Interfaces.v1;
using TechnicalTest.Application.Companies.Commands.v1;

namespace TechnicalTest.Application.Companies.Handlers.v1;

public sealed class CompanyRemoveCommandHandler : IRequestHandler<CompanyRemoveCommand, Company>
{
    private readonly ICompanyRepository _repository;

    public CompanyRemoveCommandHandler(ICompanyRepository repository)
    {
        _repository = repository;
    }

    public async Task<Company> Handle(CompanyRemoveCommand request, CancellationToken cancellationToken)
    {
        var company = await _repository.GetByIdAsync(request.Id);

        if (company == null)
            throw new AggregateException("Empresa não encontrada.");

        return await _repository.RemoveAsync(company!);
    }
}