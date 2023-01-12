using BranchXamarinSDK;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.LifecycleEvents;
using Microsoft.Maui.Storage;
#if IOS
using Foundation;
#endif

namespace DemoApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .RegisterBranchIO()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainPageViewModel>();

        builder.Services.AddSingleton<LinkDetailsPage>();
        builder.Services.AddSingleton<LinkDetailsViewModel>();

    #if DEBUG
        builder.Logging.AddDebug();
    #endif

		return builder.Build();
	}


    private static MauiAppBuilder RegisterBranchIO(this MauiAppBuilder builder)
    {
        builder.ConfigureLifecycleEvents(events =>
        {
        #if IOS
            events.AddiOS(iOS => iOS.FinishedLaunching((app, launchOptions) =>
            {
                //BranchIOS.Init(App.DevBranchIoKey, launchOptions ?? new NSDictionary(), (IBranchBUOSessionInterface)App.Current);
                BranchIOS.Init(App.StageBranchIoKey, launchOptions ?? new NSDictionary(), (IBranchBUOSessionInterface)App.Current);

                return true;
            }));
        #elif ANDROID
            // If we have to do any similar initialization for Android. Currently this is done in the MainActivity
            //events.AddAndroid(android => android.OnCreate((activity, bundle) =>
            //{
            //}));
        #endif
        });

        return builder;
    }
}

