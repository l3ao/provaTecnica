using MediatR;
using ProvaTecnica.Domain.Entities;
using ProvaTecnica.Domain.Entities.v1;

namespace TechnicalTest.Application.Companies.Queries.v1;

public class GetAllCompaniesQuery : IRequest<IEnumerable<Company>>
{
    
}