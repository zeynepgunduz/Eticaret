using Eticaret.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eticaret.WebUI.ViewCompenents
{
    public class Categories : ViewComponent
    {
        public DatabaseContext _context=new DatabaseContext();
        public async Task< IViewComponentResult >InvokeAsync()
        {
            return View(await _context.Categories.ToListAsync());
        }
    }
}
