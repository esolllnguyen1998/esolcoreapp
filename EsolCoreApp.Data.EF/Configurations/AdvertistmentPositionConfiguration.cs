using EsolCoreApp.Data.EF.Extensions;
using EsolCoreApp.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EsolCoreApp.Data.EF.Configurations
{
    public class AdvertistmentPositionConfiguration : DbEntityConfiguration<AdvertistmentPosition>
    {
        public override void Configure(EntityTypeBuilder<AdvertistmentPosition> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(20).IsRequired();
            // etc.
        }
    }
}