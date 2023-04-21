using Ebis.Services;
using Ebis.View;
using Ebis.ViewModel;

namespace Ebis;

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

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<BorneViewModel>();
        builder.Services.AddSingleton<BorneService>();
        builder.Services.AddSingleton<OperationPage>();
        builder.Services.AddSingleton<OperationViewModel>();
		builder.Services.AddSingleton<OperationService>();
        builder.Services.AddSingleton<Incident>();
        builder.Services.AddSingleton<IncidentViewModel>();
        builder.Services.AddSingleton<IncidentService>();
        builder.Services.AddSingleton<BornePage>();
        builder.Services.AddSingleton<infoBorneViewModel>();
        builder.Services.AddSingleton<InfoBorneService>();
        builder.Services.AddSingleton<EntretienPage>();
        builder.Services.AddSingleton<EntretienViewModel>();
        builder.Services.AddSingleton<EntretienService>();


        return builder.Build();
	}
}
