using EsolCoreApp.Application.Interfaces;
using EsolCoreApp.Application.ViewModels.Product;
using EsolCoreApp.Data.EF.Repositories;
using EsolCoreApp.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EsolCoreApp.Application.Implementation
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly ProductCategoryRepository _ProductCategoryRepository;
        private IUnitOfWork _unitOfWork;
        public ProductCategoryService (ProductCategoryRepository productCategoryRepository,IUnitOfWork unitOfWork)
        {
            _ProductCategoryRepository = productCategoryRepository;
            _unitOfWork = unitOfWork;
        }
        public ProductCategoryViewModel Add(ProductCategoryViewModel productCategoryVm)
        {
            return _ProductCategoryRepository.Add(productCategoryVm);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductCategoryViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<ProductCategoryViewModel> GetAll(string keyword)
        {
            throw new NotImplementedException();
        }

        public List<ProductCategoryViewModel> GetAllByParentId(int parentId)
        {
            throw new NotImplementedException();
        }

        public ProductCategoryViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductCategoryViewModel> GetHomeCategories(int top)
        {
            throw new NotImplementedException();
        }

        public void ReOrder(int sourceId, int targetId)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(ProductCategoryViewModel productCategoryVm)
        {
            throw new NotImplementedException();
        }

        public void UpdateParentId(int sourceId, int targetId, Dictionary<int, int> items)
        {
            throw new NotImplementedException();
        }
    }
}
