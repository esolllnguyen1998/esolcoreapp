using EsolCoreApp.Data.EF.Extensions;
using EsolCoreApp.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EsolCoreApp.Data.EF.Configurations
{
    public class TagConfiguration : DbEntityConfiguration<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(50);
        }
    }
}