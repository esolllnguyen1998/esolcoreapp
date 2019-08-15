using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using EsolCoreApp.Infrastructure.ShareKernel;
using TeduCoreApp.Data.Entities;

namespace EsolCoreApp.Data.Entities
{
    [Table("AdvertistmentPages")]
    public class AdvertistmentPage : DomainEntity<string>
    {
        public string Name { get; set; }

        public virtual ICollection<AdvertistmentPosition> AdvertistmentPositions { get; set; }
    }
}
