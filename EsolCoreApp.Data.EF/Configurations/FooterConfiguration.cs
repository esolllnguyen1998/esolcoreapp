using EsolCoreApp.Data.EF.Extensions;
using EsolCoreApp.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EsolCoreApp.Data.EF.Configurations
{
    public class FooterConfiguration : DbEntityConfiguration<Footer>
    {
        public override void Configure(EntityTypeBuilder<Footer> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).HasMaxLength(255);
            // etc.
        }
    }
}