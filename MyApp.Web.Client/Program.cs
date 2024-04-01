using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyApp.Shared.Interfaces;
using MyApp.Web.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device specific services used by Razor Class Library (MyApp.Shared)
builder.Services.AddSingleton<IFormFactor, FormFactor>();

await builder.Build().RunAsync();
