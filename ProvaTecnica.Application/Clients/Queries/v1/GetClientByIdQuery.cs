using MediatR;
using ProvaTecnica.Domain.Entities.v1;

namespace TechnicalTest.Application.Clients.Queries.v1;

public sealed class GetClientByIdQuery : IRequest<Client>
{
    public int Id { get; init; }

    public GetClientByIdQuery(int id)
    {
        Id = id;
    }
}