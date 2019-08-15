using AutoMapper;
using EsolCoreApp.Application.ViewModels.Product;
using EsolCoreApp.Data.Entities;

namespace EsolCoreApp.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProductCategoryViewModel, ProductCategory>().ConstructUsing(c => new ProductCategory(c.Name, c.Description, c.ParentId,c.HomeOrder,c.Image,c.HomeFlag,c.DateCreated,c.DateModified
                ,c.SortOrder,c.Status,c.SeoPageTitle,c.SeoAlias,c.SeoKeywords,c.SeoDescription,c.SortOrder));
        
        }
    }
}