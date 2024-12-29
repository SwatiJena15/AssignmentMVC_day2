using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;
using AssignmentMVC_day2.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentMVC_day2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            Product Product = new Product
            {
                Pcode = 123,
                Name = "Product1",
                Qtyinstock = 4,
                Details = "product is good",
                Price = 100

            };
            ViewBag.Product = Product;
            return View();
        }

        public IActionResult Mproduct2()
        {
            List<Product> Products = new List<Product>()
            {
                new Product() { Pcode = 1, Name = "ProductA", Qtyinstock = 10, Details = "product is good", Price = 200 },
                new Product() { Pcode = 2, Name = "ProductB", Qtyinstock = 20, Details = "product is ok", Price = 300 },
                new Product() { Pcode = 3, Name = "ProductC", Qtyinstock = 30, Details = "product is avg", Price = 400 },
                new Product() { Pcode = 4, Name = "ProductD", Qtyinstock = 40, Details = "product is moderate", Price = 500 },
                new Product() { Pcode = 5, Name = "ProductE", Qtyinstock = 50, Details = "product is best", Price = 600 }

            };
            ViewBag.Products = Products;
            return View();
        }
        public IActionResult DirectViewsingle()
        {
            Product product = new Product()
            {
                Pcode = 456,
                Name = "ProductAA",
                Qtyinstock = 5,
                Details = "product is good",
                Price = 1000
            };
            return View(product);
        }

        public IActionResult DirectViewmultiple()
        {
            List<Product> Products = new List<Product>()
            {
                new Product() { Pcode = 1, Name = "ProductA1", Qtyinstock = 10, Details = "product is good", Price = 200 },
                new Product() { Pcode = 2, Name = "ProductB1", Qtyinstock = 20, Details = "product is ok", Price = 300 },
                new Product() { Pcode = 3, Name = "ProductC1", Qtyinstock = 30, Details = "product is avg", Price = 400 },
                new Product() { Pcode = 4, Name = "ProductD1", Qtyinstock = 40, Details = "product is moderate", Price = 500 },
                new Product() { Pcode = 5, Name = "ProductE1", Qtyinstock = 50, Details = "product is best", Price = 600 }

            };
            
            return View(Products);
        }
    }


}
