using System.Collections.Generic;
using System.Web.Mvc;
using FurnitureStore.Domain.Abstract;
using System.Linq;

namespace FurnitureStore.WebUI.Controllers
{
    public class NavController : Controller
    {
        private IProductsRepository repository;

        public NavController(IProductsRepository repo)
        {
            repository = repo;
        }


        public PartialViewResult Menu(string category = null)
        {

            ViewBag.SelectCategory = category;
            IEnumerable<string> categories = repository.Products
                                                .Select(x => x.Category)
                                                .Distinct()
                                                .OrderBy(x => x);
            
            return PartialView("FlexMenu", categories);
        }
    }
}