using EsolCoreApp.Data.Enums;
using EsolCoreApp.Data.Interfaces;
using EsolCoreApp.Infrastructure.ShareKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EsolCoreApp.Data.Entities
{
    [Table("ProductCategories")]
    public class ProductCategory : DomainEntity<int>,
        IHasSeoMetaData, ISwitchable, ISortable, IDateTracking
    {
        public ProductCategory()
        {
            Products = new List<Product>();
        }
        public ProductCategory(string Name, string Description, int? ParentId, int? HomeOrder, string Image, bool? HomeFlag, DateTime DateCreated, DateTime DateModified, int SortOrder,
           Status Status, string SeoPageTitle, string SeoAlias, string SeoKeywords, string SeoDescription, int SorOrder)
        {
            this.Name = Name;
            this.Description = Description;
            this.ParentId = ParentId;
            this.HomeOrder = HomeOrder;
            this.Image = Image;
            this.HomeFlag = HomeFlag;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.SortOrder = SortOrder;
            this.Status = Status;
            this.SeoPageTitle = SeoPageTitle;
            this.SeoAlias = SeoAlias;
            this.SeoKeywords = SeoKeywords;
            this.SeoDescription = SeoDescription;
            this.SortOrder = SorOrder;
        }
        public string Name { get; set; }

        public string Description { get; set; }

        public int? ParentId { get; set; }

        public int? HomeOrder { get; set; }

        public string Image { get; set; }

        public bool? HomeFlag { get; set; }

        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public int SortOrder { set; get; }
        public Status Status { set; get; }
        public string SeoPageTitle { set; get; }
        public string SeoAlias { set; get; }
        public string SeoKeywords { set; get; }
        public string SeoDescription { set; get; }

        public virtual ICollection<Product> Products { set; get; }
        public int SorOrder { set; get; }
    }
}