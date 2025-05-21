using Eticaret.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Eticaret.Service.Abstract ;

using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Eticaret.Service.Concrete;
using Microsoft.EntityFrameworkCore.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddDbContext<DatabaseContext>();
/*builder.Services.AddScoped(typeof(IService<>),typeof(Service<>));*/

//dependency injection DI gecis yaptým 21.05.2025
builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    options.ConfigureWarnings(warnings =>
        warnings.Throw(RelationalEventId.PendingModelChangesWarning));
});



builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x=>
{
    x.LoginPath = "/Account/SignIn";
    x.LogoutPath = "/Account/SignOut";
    x.AccessDeniedPath = "/AccessDenied";
    x.Cookie.MaxAge=TimeSpan.FromDays(7);
    x.Cookie.Name = "Account";
    x.Cookie.IsEssential = true;


});


builder.Services.AddAuthorization(x=>
{ 
    x.AddPolicy("AdminPolicy",policy=>policy.RequireClaim(ClaimTypes.Role,"Admin") );

    x.AddPolicy("UserPolicy", policy => policy.RequireClaim(ClaimTypes.Role, "Admin", "User", "Customer"));
    
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();//önce oturum acma
app.UseAuthorization();//sonra yetkilendirme

app.MapControllerRoute( //not adminin calýsacagý controllerý belirttik.
  name: "admin",
  pattern: "{area:exists}/{controller=Main}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
