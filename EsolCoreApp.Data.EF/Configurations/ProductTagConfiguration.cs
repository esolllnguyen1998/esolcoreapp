using EsolCoreApp.Data.EF.Extensions;
using EsolCoreApp.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EsolCoreApp.Data.EF.Configurations
{
    public class ProductTagConfiguration : DbEntityConfiguration<ProductTag>
    {
        public override void Configure(EntityTypeBuilder<ProductTag> entity)
        {
            entity.Property(c => c.TagId).HasMaxLength(255).IsRequired();
            // etc.
        }
    }
}