using AutoMapper;
using EsolCoreApp.Application.Interfaces;
using EsolCoreApp.Application.ViewModels.Product;
using EsolCoreApp.Data.EF.Repositories;
using EsolCoreApp.Data.Entities;
using EsolCoreApp.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EsolCoreApp.Application.Implementation
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly ProductCategoryRepository _ProductCategoryRepository;
        private IUnitOfWork _unitOfWork;
        private readonly Mapper _mapper;
        public ProductCategoryService (ProductCategoryRepository productCategoryRepository,IUnitOfWork unitOfWork,Mapper mapper)
        {
            _ProductCategoryRepository = productCategoryRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public void Add(ProductCategoryViewModel productCategoryVm)
        {
            var productCategory = _mapper.Map<ProductCategoryViewModel, ProductCategory>(productCategoryVm);
            _ProductCategoryRepository.Add(productCategory);
        }

        public void Delete(int id)
        {
            _ProductCategoryRepository.Remove(id);
        }

        public List<ProductCategoryViewModel> GetAll()
        {
            var lst = _ProductCategoryRepository.FindAll().ToList();
            List<ProductCategoryViewModel> productCategoryVM = new List<ProductCategoryViewModel>();
            productCategoryVM = _mapper.Map<List<ProductCategory>,List<ProductCategoryViewModel>>(lst);
            return productCategoryVM;
    }

        public List<ProductCategoryViewModel> GetAll(string keyword)
        {
            var lst = _ProductCategoryRepository.FindAll().Where(x=> x.Name.IndexOf(keyword) != 0).ToList();
            List<ProductCategoryViewModel> productCategoryVM = new List<ProductCategoryViewModel>();
            productCategoryVM = _mapper.Map<List<ProductCategory>, List<ProductCategoryViewModel>>(lst);
            return productCategoryVM;
        }

        public List<ProductCategoryViewModel> GetAllByParentId(int parentId)
        {
            var lst = _ProductCategoryRepository.FindAll().Where(x => x.Id  == parentId).ToList();
            List<ProductCategoryViewModel> productCategoryVM = new List<ProductCategoryViewModel>();
            productCategoryVM = _mapper.Map<List<ProductCategory>, List<ProductCategoryViewModel>>(lst);
            return productCategoryVM;
        }

        public ProductCategoryViewModel GetById(int id)
        {
            var lst = _ProductCategoryRepository.FindAll().Where(x => x.Id == id).FirstOrDefault();
            ProductCategoryViewModel productCategoryView = new ProductCategoryViewModel();
            productCategoryView = _mapper.Map<ProductCategory, ProductCategoryViewModel>(lst);
            return productCategoryView;
        }

        public List<ProductCategoryViewModel> GetHomeCategories(int top)
        {
            var lst = _ProductCategoryRepository.FindAll().Where(x => x.HomeOrder == top).ToList();
            List<ProductCategoryViewModel> productCategoryVM = new List<ProductCategoryViewModel>();
            productCategoryVM = _mapper.Map<List<ProductCategory>, List<ProductCategoryViewModel>>(lst);
            return productCategoryVM;
        }
        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(ProductCategoryViewModel productCategoryVm)
        {
            var productCategory = _mapper.Map<ProductCategoryViewModel, ProductCategory>(productCategoryVm);
            _ProductCategoryRepository.Update(productCategory);
        }
    }
}
