using ECommerce.Core.Entities.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Infrastructure.Data.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(a => a.Id).IsRequired();
        builder.Property(a => a.Name).IsRequired().HasMaxLength(60);
        builder.Property(a => a.Description).IsRequired().HasMaxLength(250);
        builder.Property(a => a.Price).IsRequired().HasColumnType("decimal(18, 2)");
    }
}
