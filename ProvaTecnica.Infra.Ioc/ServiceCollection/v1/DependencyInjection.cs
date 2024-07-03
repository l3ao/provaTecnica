using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProvaTecnica.Domain.Interfaces.v1;
using ProvaTecnica.InfraData.Context.v1;
using ProvaTecnica.InfraData.Repositories.v1;
using System.Reflection;
using TechnicalTest.Application.Interfaces;
using TechnicalTest.Application.Profiles.v1;
using TechnicalTest.Application.Services.v1;

namespace ProvaTecnica.Infra.Ioc.ServiceCollection.v1;

public static class DependencyInjection
{
    public static IServiceCollection AddInfra(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConection"),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

        services.AddScoped<ICompanyRepository, CompanyRepository>();
        services.AddScoped<IClientRepository, ClientRepository>();
        
        services.AddScoped<ICompanyService, CompanyService>();
        services.AddScoped<IClientService, ClientService>();

        services.AddAutoMapper(typeof(ClientDtoProfile));
        services.AddAutoMapper(typeof(CompanyDtoProfile));

        var myhandlers = AppDomain.CurrentDomain.Load("ProvaTecnica.Application");
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(myhandlers));
        
        return services;
    }
}