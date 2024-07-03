using MediatR;
using ProvaTecnica.Domain.Entities.v1;

namespace TechnicalTest.Application.Clients.Commands.v1;

public sealed class ClientUpdateCommand : ClientCommand
{
    public new int Id { get; init; }
}