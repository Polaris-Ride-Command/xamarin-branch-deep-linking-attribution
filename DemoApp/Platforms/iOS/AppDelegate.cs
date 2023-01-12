using System.Diagnostics;
using BranchXamarinSDK;
using Foundation;
using MapKit;
using Microsoft.Maui.LifecycleEvents;
using UIKit;

namespace DemoApp;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        Branch.EnableLogging = true;

        //BranchIOS.Init(App.DevBranchIoKey, launchOptions ?? new NSDictionary(), (IBranchBUOSessionInterface)App.Current); // problem here is that App.Current is null
        // 1/12/23 - initialization for this was moved to the builder in MauiProgram.cs so we can get an instance of the App class

        return base.FinishedLaunching(application, launchOptions);
    }

    public override bool ContinueUserActivity(UIApplication application, NSUserActivity userActivity, UIApplicationRestorationHandler completionHandler)
    {
        if (!(userActivity.WebPageUrl is null))
        {
            var isBranchLink = userActivity.WebPageUrl.AbsoluteString.Contains("app.link") || userActivity.WebPageUrl.AbsoluteString.Contains("bnc.lt");

            if (isBranchLink)
                return BranchIOS.getInstance().ContinueUserActivity(userActivity);
        }

        return base.ContinueUserActivity(application, userActivity, completionHandler);
    }

    [Export("application:didFailToContinueUserActivityWithType:error:")]
    public void DidFailToContinueUserActivity(UIApplication application, string userActivityType, NSError error)
    {
        Debug.WriteLine("---------------------------------------");
        Debug.WriteLine($"DidFailToContinueUserActivity: {error}");
        Debug.WriteLine("---------------------------------------");
    }
}

