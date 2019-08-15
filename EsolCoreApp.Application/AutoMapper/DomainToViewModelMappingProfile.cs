using AutoMapper;
using EsolCoreApp.Application.ViewModels.Product;
using EsolCoreApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EsolCoreApp.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile :Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
        }
    }
}
