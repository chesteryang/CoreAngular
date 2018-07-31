using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoreAngular.AdventureWorks.SqliteModel;
using CoreAngular.Model;
#pragma warning disable 1591

namespace CoreAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly Adventureworks2017Context _context;

        public ProductsController(Adventureworks2017Context context)
        {
            _context = context;
        }

        [HttpGet("ViewModel")]
        public IEnumerable<ProductViewModel> GetProductViewModels()
        {
            var list = _context.ProductProductPhoto.Where(pp => pp.ProductPhotoId != 1)
                .Include(pp => pp.ProductPhoto).Include(pp => pp.Product).Include(pp => pp.Product.ProductSubcategory)
                .Select(pp => new ProductViewModel
                {
                    ProductId = pp.ProductId,
                    Name = pp.Product.Name,
                    ProductNumber = pp.Product.ProductNumber,
                    StandardCost = pp.Product.StandardCost,
                    ListPrice = pp.Product.ListPrice,
                    SubCategoryName = pp.Product.ProductSubcategory.Name,
                    ThumbnailPhotoFileName = pp.ProductPhoto.ThumbnailPhotoFileName,
                    LargePhotoFileName = pp.ProductPhoto.LargePhotoFileName
                });
            return list;
        }

        // GET: api/Products
        [HttpGet]
        public IEnumerable<Product> GetProduct()
        {
            return _context.Product;
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = await _context.Product.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct([FromRoute] long id, [FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != product.ProductId)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Products
        [HttpPost]
        public async Task<IActionResult> PostProduct([FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Product.Add(product);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProductExists(product.ProductId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProduct", new { id = product.ProductId }, product);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Product.Remove(product);
            await _context.SaveChangesAsync();

            return Ok(product);
        }

        private bool ProductExists(long id)
        {
            return _context.Product.Any(e => e.ProductId == id);
        }
    }
}