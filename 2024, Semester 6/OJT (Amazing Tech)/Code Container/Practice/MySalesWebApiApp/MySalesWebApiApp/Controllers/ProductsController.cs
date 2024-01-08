using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySalesWebApiApp.Models;

namespace MySalesWebApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public static List<Product> products = new List<Product>();

        [HttpGet("get-all-products")]
        public IActionResult GetAll()
        {
            return Ok(products);
        }

        [HttpGet("get-product-by-id/{id}")]
        public IActionResult GetById(string id)
        {
            try
            {
                //LINQ [Object] Query
                var product = products.SingleOrDefault(p => p.ProductId == Guid.Parse(id));
                if (product == null)
                {
                    return NotFound();
                }
                return Ok(product);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost("add-product")]
        public IActionResult CreateNew(ProductVM productVM)
        {
            var product = new Product
            {
                ProductId = Guid.NewGuid(),
                ProductName = productVM.ProductName,
                UnitPrice = productVM.UnitPrice
            };
            products.Add(product);
            return Ok(new
            {
                Success = true,
                Data = product
            }); ;
        }

        [HttpPut("update-product")]
        public IActionResult Edit(string id, Product productEdit)
        {
            try
            {
                // LINQ [Object] Query
                var product = products.SingleOrDefault(p => p.ProductId == Guid.Parse(id));
                if (product == null)
                {
                    return NotFound();
                }

                if (id != product.ProductId.ToString())
                {
                    return BadRequest();
                }

                // Update
                product.ProductName = productEdit.ProductName;
                product.UnitPrice = productEdit.UnitPrice;

                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete("delete-product/{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                // LINQ [Object] Query
                var product = products.SingleOrDefault(p => p.ProductId == Guid.Parse(id));
                if (product == null)
                {
                    return NotFound();
                }
                products.Remove(product);

                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
