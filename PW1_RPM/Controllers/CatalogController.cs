using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PW1_RPM.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<dynamic>
            {
                new { Id = 1, Name = "Товар 1", Description = "Описание товара 1", Price = 1000, ImageUrl = "/images/sample-product.jpg" },
                new { Id = 2, Name = "Товар 2", Description = "Описание товара 2", Price = 2000, ImageUrl = "/images/sample-product.jpg" },
                new { Id = 3, Name = "Товар 3", Description = "Описание товара 3", Price = 3000, ImageUrl = "/images/sample-product.jpg" }
            };

            return View(products);
        }

        public IActionResult Cart()
        {
            // Логика корзины
            return View();
        }
    }
}
