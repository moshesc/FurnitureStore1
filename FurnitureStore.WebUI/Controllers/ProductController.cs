using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FurnitureStore.Domain.Abstract;
using FurnitureStore.Domain.Entities;
using FurnitureStore.WebUI.Models;


namespace FurnitureStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductsRepository repository;
        public int PageSize = 4;

        public ProductController(IProductsRepository productsRepository)
        {
            this.repository = productsRepository;
        }
        public ViewResult List(string category,int page = 1)
        { ProductsListViewModel model = new ProductsListViewModel
        {
            Products = repository.Products
            .Where(p => category == null || p.Category == category)

             .OrderBy(p => p.ProductID)
                 .Skip((page - 1) * PageSize)
                 .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = page,
                ItemsPerPage = PageSize,
                TotalItems = category == null ?
                repository.Products.Count() :
                repository.Products.Where(e => e.Category == category).Count()
                },
            CurrentCategory = category
        };
            return View(model);


}
    }
}