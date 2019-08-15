using EsolCoreApp.Data.Interfaces;
using EsolCoreApp.Infrastructure.ShareKernel;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EsolCoreApp.Data.Enums;

namespace EsolCoreApp.Data.Entities
{
    [Table("Languages")]
    public class Language : DomainEntity<string>, ISwitchable
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        public bool IsDefault { get; set; }

        public string Resources { get; set; }

        public Status Status { get; set; }
    }
}
