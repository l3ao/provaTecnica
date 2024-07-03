using MediatR;
using ProvaTecnica.Domain.Entities.v1;

namespace TechnicalTest.Application.Clients.Queries.v1;

public class GetAllClientsQuery : IRequest<IEnumerable<Client>>
{
    
}