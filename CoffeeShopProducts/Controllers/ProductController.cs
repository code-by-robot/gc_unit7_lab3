using Microsoft.AspNetCore.Mvc;
using CoffeeShopProducts.Models;

namespace CoffeeShopProducts.Controllers
{
    public class ProductController : Controller

    {
        private CoffeeDBContext context = new CoffeeDBContext();
        public IActionResult Details(int postId)
        {
            Product p = context.Products.FirstOrDefault(p => p.Id == postId);
            return View(p);
        }

        public IActionResult Index()
        {
            List<Product> result = context.Products.ToList();
            return View(result);

        }
    }
}
