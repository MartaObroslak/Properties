using Microsoft.EntityFrameworkCore;
using Properites.Helpers;
using Properites.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<PropertiesContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("PropertiesContext"));
});


builder.Services.AddDefaultIdentity<ApplicationUser>(options => {
    options.SignIn.RequireConfirmedAccount = false;
})
.AddEntityFrameworkStores<PropertiesContext>();

builder.Services.AddControllersWithViews();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
    options.LogoutPath = "/Account/Logout";
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Properties/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Properties}/{action=Index}/{id?}");

app.Run();
