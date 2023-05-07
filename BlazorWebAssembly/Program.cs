using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorWebAssembly;
using BlazorWebAssembly.Entities.Category;
using BlazorWebAssembly.Entities.Product;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton<ICatalogProduct, InMemoryCatalogProduct>();
builder.Services.AddSingleton<IShopCart,InMemoryShopCart>();
builder.Services.AddSingleton<ICategoriesRepository,InMemoryCategoriesRepository>();



builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();