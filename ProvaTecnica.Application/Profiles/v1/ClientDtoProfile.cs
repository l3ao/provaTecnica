using AutoMapper;
using ProvaTecnica.Domain.Entities.v1;
using TechnicalTest.Application.Clients.Commands.v1;
using TechnicalTest.Application.Dtos.v1;

namespace TechnicalTest.Application.Profiles.v1;

public sealed class ClientDtoProfile : Profile
{
    public ClientDtoProfile()
    {
        CreateMap<ClientDto, Client>().ReverseMap();
        CreateMap<ClientDto, ClientCreateCommand>();
        CreateMap<ClientDto, ClientUpdateCommand>();
        CreateMap<Company, CompanyDto>();
    }
}