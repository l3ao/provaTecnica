using MediatR;
using ProvaTecnica.Domain.Entities;
using ProvaTecnica.Domain.Entities.v1;
using ProvaTecnica.Domain.Interfaces.v1;
using TechnicalTest.Application.Companies.Queries.v1;

namespace TechnicalTest.Application.Companies.Handlers.v1;

public sealed class GetAllCompaniesQueryHandler : IRequestHandler<GetAllCompaniesQuery, IEnumerable<Company>>
{
    private readonly ICompanyRepository _repository;

    public GetAllCompaniesQueryHandler(ICompanyRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<IEnumerable<Company>> Handle(GetAllCompaniesQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetAllAsync();
    }
}