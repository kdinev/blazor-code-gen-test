using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using IgniteUI.Blazor.Controls;
using PeopleApp;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(typeof(IgbNavbarModule));
    services.AddIgniteUIBlazor(typeof(IgbIconModule));
    services.AddIgniteUIBlazor(typeof(IgbAvatarModule));
    services.AddIgniteUIBlazor(typeof(IgbBadgeModule));
    services.AddIgniteUIBlazor(typeof(IgbButtonModule));
    services.AddIgniteUIBlazor(typeof(IgbRippleModule));
    services.AddIgniteUIBlazor(typeof(IgbListModule));
    services.AddIgniteUIBlazor(typeof(IgbInputModule));
    services.AddIgniteUIBlazor(typeof(IgbDatePickerModule));
    services.AddIgniteUIBlazor(typeof(IgbRadioGroupModule));
    services.AddIgniteUIBlazor(typeof(IgbRadioModule));
    services.AddIgniteUIBlazor(typeof(IgbCheckboxModule));
    services.AddIgniteUIBlazor(typeof(IgbCardModule));
}