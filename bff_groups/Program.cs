using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using bff_groups; // Your project namespace
using bff_groups.Services;
using bff_groups.Repositories;
using System.Net.Http;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add root components
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Setup HttpClient with MockAPI base URL
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://686262c896f0cc4e34b9815c.mockapi.io/dche/")
});

// Register repositories and services
builder.Services.AddScoped<IClassesRepository, ClassesRepository>();
builder.Services.AddScoped<ClassesService>();

await builder.Build().RunAsync();