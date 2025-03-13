using Eticaret.Data;
using Eticaret.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eticaret.WebUI.Controllers
{
    public class ProductsController : Controller
    {
        private readonly DatabaseContext _context;

        public ProductsController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Admin/Products
        public async Task<IActionResult> Index()
        {
            var databaseContext = _context.Products.Where(p=>p.IsActive).Include(p => p.Brand).Include(p => p.Category);
            return View(await databaseContext.ToListAsync());
        }
        // GET: Admin/Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            var model= new ProductDetailViewModel()
            { Product = product,
                RelatedProducts = _context.Products.Where(p => p.CategoryId == product.CategoryId && p.IsActive && p.Id!=product.Id).ToList()
            };

            return View(model);
        }

    }
}
