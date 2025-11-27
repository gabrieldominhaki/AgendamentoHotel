using Microsoft.Extensions.Logging;

namespace AgendamentoHotel
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
                    fonts.AddFont("ScinceGothic.ttf", "ScinceGothic");
                    fonts.AddFont("ScinceGothic-Regular.ttf", "ScinceGothicRegular");
                    fonts.AddFont("Delius-Regular.ttf", "Delius");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
