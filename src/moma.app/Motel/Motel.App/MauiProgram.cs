using Motel.App.Pages;
using Motel.App.ViewModels;
using Motel.Application;
using Motel.Application.Authenticate;
using Motel.Application.Services;

namespace Motel.App
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.Services.AddSingleton<IHttpProvider, HttpProvider>();
            builder.Services.AddSingleton<IStorageProvider, StorageProvider>();

            builder.Services.AddScoped<IAuthenticateService,AuthenticateService>();

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<Authenticate>();
            builder.Services.AddSingleton<Home>();
            builder.Services.AddSingleton<LoginViewModel>();
            return builder.Build();
        }
    }
}