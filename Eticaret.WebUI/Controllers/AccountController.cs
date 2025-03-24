using Eticaret.Core.Entities;
using Eticaret.Data;
using Eticaret.WebUI.Models;
using Microsoft.AspNetCore.Authentication;//login işlemi için
using Microsoft.AspNetCore.Authorization;//login işlemi için
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Eticaret.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly DatabaseContext _context;

        public AccountController(DatabaseContext context)
        {
            _context = context;
        }
        [Authorize]//new 
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult SignIn()
        {
            return View();
        }


        /*
         */
        [HttpPost]
        public async Task< IActionResult> SignInAsync(LoginViewModel loginViewModel)  
        {
            string returnURL = string.Empty;
            if (ModelState.IsValid )
            {
                try
                { 

                    var account =await _context.AppUsers.FirstOrDefaultAsync(x => x.Email == loginViewModel.Email && x.Password == loginViewModel.Password && x.IsActive);
                    if (account==null)
                    {
                        ModelState.AddModelError("", "Kullanıcı Bulunamadı!");
                        return View(loginViewModel);
                    }
                    else
                    {
                        var claims= new List<Claim>()
                        {
                            new Claim(ClaimTypes.Name,account.Name),
                            new Claim(ClaimTypes.Email,account.Email),
                            new Claim(ClaimTypes.Role,account.IsAdmin?"Admin":"User"),
                            new ("UserId",account.Id.ToString()),
                            new ("UserIdGuid",account.UserGuid.ToString())
                        };
                        var userIdentity = new ClaimsIdentity(claims, "Login");
                        ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                        await HttpContext.SignInAsync(principal);
                        return Redirect(string.IsNullOrEmpty(loginViewModel.ReturnUrl)? "/" : loginViewModel.ReturnUrl);
                         
                    }

                }
                catch (Exception ex)
                {

                    //loglama
                    ModelState.AddModelError("", "Hata Oluştu!");//  + ex.Message );
                }
            }
             return View(loginViewModel);

        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUpAsync(AppUser appUser)
        {
            appUser.IsActive = true;
            appUser.IsAdmin = false;

            if (ModelState.IsValid)
            {
                await _context.AddAsync(appUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(appUser);

        }

        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("SignIn");

        }   
    }
}
