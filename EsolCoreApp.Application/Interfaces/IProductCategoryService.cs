using EsolCoreApp.Application.ViewModels.Product;
using System.Collections.Generic;

namespace EsolCoreApp.Application.Interfaces
{
    public interface IProductCategoryService
    {
        void Add(ProductCategoryViewModel productCategoryVm);

        void Update(ProductCategoryViewModel productCategoryVm);

        void Delete(int id);

        List<ProductCategoryViewModel> GetAll();

        List<ProductCategoryViewModel> GetAll(string keyword);

        List<ProductCategoryViewModel> GetAllByParentId(int parentId);

        ProductCategoryViewModel GetById(int id);

        List<ProductCategoryViewModel> GetHomeCategories(int top);

        void Save();
    }
}