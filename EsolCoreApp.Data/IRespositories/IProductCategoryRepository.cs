using EsolCoreApp.Data.Entities;
using EsolCoreApp.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EsolCoreApp.Data.IRespositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory, int>
    {
        List<ProductCategory> GetbyAliass(string Alias);
    }
}
