using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Eticaret.WebUI.Models;
using Eticaret.Data;
using Microsoft.EntityFrameworkCore;
using Eticaret.WebUI.Areas.Admin.Controllers;
using Eticaret.Core.Entities;

namespace Eticaret.WebUI.Controllers;

public class HomeController : Controller
{
    private readonly DatabaseContext _context;

    public  HomeController (DatabaseContext context)
    {
        _context = context;
    }
    
    public async Task<IActionResult >Index()
    {
        var model = new HomePageViewModel()
        {
            Sliders = await _context.Sliders.ToListAsync(),
            News = await _context.News.ToListAsync(),
            Products = await _context.Products.Where(p=>p.IsActive && p.IsHome ).ToListAsync() 
        };
        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult ContactUs()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
