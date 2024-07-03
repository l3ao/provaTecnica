using AutoMapper;
using ProvaTecnica.Domain.Entities;
using ProvaTecnica.Domain.Entities.v1;
using TechnicalTest.Application.Companies.Commands.v1;
using TechnicalTest.Application.Dtos.v1;

namespace TechnicalTest.Application.Profiles.v1;

public class CompanyDtoProfile : Profile
{
    public CompanyDtoProfile()
    {
        CreateMap<CompanyDto, Company>().ReverseMap();
        CreateMap<CompanyDto, CompanyCreateCommand>();
        CreateMap<CompanyDto, CompanyUpdateCommand>();
    }
}