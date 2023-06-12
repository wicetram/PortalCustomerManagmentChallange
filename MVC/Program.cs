using MVC.Business.Abstract;
using MVC.Business.Concrete;
using PortalCustomerManagmentChallangeBusiness.Abstract;
using PortalCustomerManagmentChallangeBusiness.Concrete;
using PortalCustomerManagmentChallangeCore.DataAccess;
using PortalCustomerManagmentChallangeCore.DataAccess.EntityFramework;
using PortalCustomerManagmentChallangeDataAccess.Abstract;
using PortalCustomerManagmentChallangeDataAccess.Concrete.EntityFramework;
using PortalCustomerManagmentChallangeMVC.Business.Abstract;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ICustomerService, BaseCustomerManager>();
builder.Services.AddScoped<IVerificationService, VerificationManager>();
builder.Services.AddScoped<IUserService, UserManager>();
builder.Services.AddScoped<IUserDal, EfUserDal>();
builder.Services.AddControllers();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
