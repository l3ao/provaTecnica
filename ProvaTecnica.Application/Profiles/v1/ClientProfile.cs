using AutoMapper;
using ProvaTecnica.Domain.Entities.v1;
using TechnicalTest.Application.Clients.Commands.v1;
using TechnicalTest.Application.Dtos.v1;

namespace TechnicalTest.Application.Profiles.v1;

public sealed class ClientProfile : Profile
{
    public ClientProfile()
    {
        CreateMap<ClientDto, Client>().ReverseMap();
        CreateMap<ClientCreateDto, ClientCreateCommand>();
        CreateMap<ClientUpdateDto, ClientUpdateCommand>();
        CreateMap<Company, CompanyDto>();
    }
}