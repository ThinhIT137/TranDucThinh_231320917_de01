using Microsoft.EntityFrameworkCore;
using TranDucThinh_231230917_de01.models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<TranDucThinh231230917De01Context>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("TranDucThinh_231230917_de01"));
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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=TranDucThinhHome}/{action=TranDucThinhContact}/{id?}");

app.Run();
