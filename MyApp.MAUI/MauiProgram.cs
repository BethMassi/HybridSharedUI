using Microsoft.Extensions.Logging;
using MyApp.MAUI.Services;
using MyApp.Shared;
using MyApp.Shared.Interfaces;

namespace MyApp.MAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            //Ignore the interactive render settings in the shared razor class library. 
            InteractiveRenderSettings.InteractiveServer = null;
            InteractiveRenderSettings.InteractiveAuto = null;
            InteractiveRenderSettings.InteractiveWebAssembly = null;

            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            // Add device specific services used by Razor Class Library (MyApp.Shared)
            builder.Services.AddSingleton<IFormFactor, FormFactor>();

            return builder.Build();
        }
    }
}
