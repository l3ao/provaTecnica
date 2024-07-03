using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProvaTecnica.Domain.Entities;
using ProvaTecnica.Domain.Entities.v1;

namespace ProvaTecnica.InfraData.Mapping.v1;

public class CompanyMap : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.HasKey(company => company.Id);
        builder.Property(company => company.Name)
            .HasMaxLength(100)
            .IsRequired();
        builder.Property(company => company.Size)
            .IsRequired();
    }
}