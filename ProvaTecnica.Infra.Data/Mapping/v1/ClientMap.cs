using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProvaTecnica.Domain.Entities.v1;

namespace ProvaTecnica.InfraData.Mapping.v1;

public class ClientMap : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.HasKey(client => client.Id);
        builder.Property(client => client.Name)
            .HasMaxLength(100)
            .IsRequired();
        builder.Property(client => client.Address)
            .HasMaxLength(250);
        builder.Property(client => client.Document)
            .HasMaxLength(50);
        builder.Property(client => client.PhoneNumber)
            .HasMaxLength(20);
        
        builder.HasOne(client => client.Company)
            .WithMany(company => company.Clients)
            .HasForeignKey(client => client.CompanyId);
    }
}