using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Skinet.Core.Domain.Entities;

namespace Skinet.Infrastructure.Data.Config
{
  public class ProductConfiguration : IEntityTypeConfiguration<Product>
  {
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(p => p.Id).IsRequired();
        builder.Property(p => p.ProductName).IsRequired();
        builder.Property(p => p.Description).IsRequired();
        builder.Property(p => p.Price).HasColumnType("decimal(18, 2)");
        builder.Property(p => p.PictureUrl).IsRequired();
        builder.HasOne(b => b.ProductBrand).WithMany()
               .HasForeignKey(p => p.ProductBrandID);
        builder.HasOne(t => t.ProductType).WithMany()
               .HasForeignKey(p => p.ProductTypeID);
    }
  }
}