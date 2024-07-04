using Microsoft.Extensions.Logging;

namespace Evaluacion
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

#if DEBUG
<<<<<<< HEAD
    		builder.Logging.AddDebug();
=======
            builder.Logging.AddDebug();
>>>>>>> Agregar archivos de proyecto.
#endif

            return builder.Build();
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> Agregar archivos de proyecto.
