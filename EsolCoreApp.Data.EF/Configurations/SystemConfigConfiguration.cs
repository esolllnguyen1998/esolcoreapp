using EsolCoreApp.Data.EF.Extensions;
using EsolCoreApp.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EsolCoreApp.Data.EF.Configurations
{
    internal class SystemConfigConfiguration : DbEntityConfiguration<SystemConfig>
    {
        public override void Configure(EntityTypeBuilder<SystemConfig> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
        }
    }
}