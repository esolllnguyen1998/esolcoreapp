using EsolCoreApp.Data.Entities;
using EsolCoreApp.Data.IRespositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EsolCoreApp.Data.EF.Repositories
{
    public class ProductCategoryRepository: EFResponsitory<ProductCategory,int>, IProductCategoryRepository
    {
        AppDbContext _context;
        public ProductCategoryRepository(AppDbContext context) :base (context)
        {

        }

        public List<ProductCategory> GetbyAliass(string Alias)
        {
           return _context.ProductCategories.Where(x => x.SeoAlias == Alias).ToList();
        }
    }
}
