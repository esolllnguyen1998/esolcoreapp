using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EsolCoreApp.Application.Implementation;
using Microsoft.AspNetCore.Mvc;

namespace EsolCoreApp.Controllers
{
    [Route("api/[controller]")]
    public class ProductCategoryController : Controller
    {
        ProductCategoryService _productCategoryService;
        public ProductCategoryController(ProductCategoryService productCategoryService )
        {
            _productCategoryService = productCategoryService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}