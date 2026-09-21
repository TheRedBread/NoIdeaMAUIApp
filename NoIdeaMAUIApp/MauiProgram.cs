using Microsoft.Extensions.Logging;

namespace NoIdeaMAUIApp
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
                    fonts.AddFont("Literata-SemiBold.ttf", "LiterataSemiBold");
                    fonts.AddFont("IBMPlexSans-Regular.ttf", "PlexSansRegular");
                    fonts.AddFont("IBMPlexSans-Medium.ttf", "PlexSansMedium");
                    fonts.AddFont("IBMPlexMono-Medium.ttf", "PlexMonoMedium");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
