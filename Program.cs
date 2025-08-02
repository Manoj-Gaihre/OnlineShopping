using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnlineShopping.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<OnlineShoppingContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("OnlineShoppingContext") ?? throw new InvalidOperationException("Connection string 'OnlineShoppingContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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

//default ma product ddashboard kholne ko laghi
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=ProductDashboard}/{id?}");

app.Run();
