using Microsoft.EntityFrameworkCore;
using SecondRazorPage.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//The service is already in the container, 
//We don't have to write it again each time we use -> Dependency Injections 
builder.Services.AddRazorPages();

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
    )); 
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapGet("/", context =>
{
    context.Response.Redirect("/LoginPage/Index");   // or "/Login/Student"
    return Task.CompletedTask;
});

app.MapRazorPages();

app.Run();
