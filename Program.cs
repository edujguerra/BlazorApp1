using BlazorApp1;
using BlazorApp1.Interface;
using BlazorApp1.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient<IRestauranteService, RestauranteService>(client =>
{
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("blazorApp", policeBuilder =>
        policeBuilder.WithOrigins("http://localhost:3307")
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());
});

await builder.Build().RunAsync();


