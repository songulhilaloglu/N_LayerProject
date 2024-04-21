using ApplicationLayer.AutoMapper;
using ApplicationLayer.Services.KategoriService;
using ApplicationLayer.Services.SepetService;
using ApplicationLayer.Services.UrunService;
using ApplicationLayer.Services.UserService;
using DomainLayer.Entities.Concrete;
using DomainLayer.Repositories.Abstract;
using InfrastructureLayer;
using InfrastructureLayer.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// veritabanı
builder.Services.AddDbContext<UrunContext>(x=> x.UseSqlServer());
//identity
builder.Services.AddIdentity<Uye, Rol>(x => x.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<UrunContext>().AddRoles<Rol>();
//automapper
builder.Services.AddAutoMapper(x => x.AddProfile(typeof(UrunProjeMapper)));

//projedeki servisler
//builder.Services.AddTransient()
//builder.Services.AddSingleton()
//builder.Services.AddScoped() 

builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IUrunService, UrunService>();
builder.Services.AddTransient<IKategoriService, KategoriService>();
builder.Services.AddTransient<ISepetService, SepetService>();

builder.Services.AddTransient<IUrunRepository, UrunRepository>();
builder.Services.AddTransient<IKategoriRepository, KategoriRepository>();
builder.Services.AddTransient<ISepetRepository, SepetRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
