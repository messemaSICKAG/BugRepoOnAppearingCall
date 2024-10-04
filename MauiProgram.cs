using BugRepoOnAppearingCall.Pages;
using Microsoft.Extensions.Logging;

namespace BugRepoOnAppearingCall
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
                }).ConfigureContainer();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        private static void ConfigureContainer(this MauiAppBuilder appBuilder)
        {
            //appBuilder.Services.AddTransient<SelectDevicePage>();
        }
    }
}
