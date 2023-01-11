using System.Diagnostics;
using BranchXamarinSDK;
using Foundation;
using UIKit;

namespace DemoApp;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        Branch.EnableLogging = true;

        //BranchIOS.Init(App.DevBranchIoKey, launchOptions ?? new NSDictionary(), (IBranchBUOSessionInterface)App.Current);
        BranchIOS.Init(App.StageBranchIoKey, launchOptions ?? new NSDictionary(), (IBranchBUOSessionInterface)App.Current);

        return base.FinishedLaunching(application, launchOptions);
    }

    public override bool ContinueUserActivity(UIApplication application, NSUserActivity userActivity, UIApplicationRestorationHandler completionHandler)
    {
        if (!(userActivity.WebPageUrl is null))
        {
            var isBranchLink = userActivity.WebPageUrl.AbsoluteString.Contains("app.link") || userActivity.WebPageUrl.AbsoluteString.Contains("bnc.lt");

            if (isBranchLink)
            {
                return BranchIOS.getInstance().ContinueUserActivity(userActivity);
            }
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

