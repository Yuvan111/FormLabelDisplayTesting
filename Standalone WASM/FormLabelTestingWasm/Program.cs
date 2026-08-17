using System.Globalization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using FormLabelTestingWasm;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

var host = builder.Build();
var js = host.Services.GetRequiredService<IJSRuntime>();
string? cultureName = null;

try
{
	cultureName = await js.InvokeAsync<string?>("localStorage.getItem", "appCulture");
}
catch (JSException)
{
}

if (cultureName is "en-US" or "fr-FR")
{
	var culture = CultureInfo.GetCultureInfo(cultureName);
	CultureInfo.DefaultThreadCurrentCulture = culture;
	CultureInfo.DefaultThreadCurrentUICulture = culture;
}

await host.RunAsync();
