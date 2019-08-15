using EsolCoreApp.Data.Interfaces;
using EsolCoreApp.Infrastructure.ShareKernel;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EsolCoreApp.Data.Enums;

namespace EsolCoreApp.Data.Entities
{
    [Table("SystemConfigs")]
    public class SystemConfig : DomainEntity<string>, ISwitchable
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        public string Value1 { get; set; }
        public int? Value2 { get; set; }

        public bool? Value3 { get; set; }

        public DateTime? Value4 { get; set; }

        public decimal? Value5 { get; set; }
        public Status Status { get; set; }
    }
}
