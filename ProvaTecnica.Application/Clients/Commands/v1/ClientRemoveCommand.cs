using System.ComponentModel.DataAnnotations;
using MediatR;
using ProvaTecnica.Domain.Entities.v1;

namespace TechnicalTest.Application.Clients.Commands.v1;

public sealed class ClientRemoveCommand : IRequest
{
    [Required]
    public new int Id { get; init; }

    public ClientRemoveCommand(int id)
    {
        Id = id;
    }
}