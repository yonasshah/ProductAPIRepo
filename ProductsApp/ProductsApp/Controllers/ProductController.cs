using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Pop", Category = "Cheese", Price = 99 },
            new Product { Id = 2, Name = "Crackle", Category = "Boats", Price = 5.75M },
            new Product { Id = 3, Name = "Snap", Category = "Sticks", Price = 26.99M }
        };

        public ProductController()
        {
        }
        public ProductController(Product[] products)
        {
            this.products = products;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
