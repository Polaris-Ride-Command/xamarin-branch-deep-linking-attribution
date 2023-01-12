using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using BranchXamarinSDK;

namespace DemoApp;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
[IntentFilter(
        new[] { Android.Content.Intent.ActionView },
        Categories = new[] { "android.intent.category.DEFAULT", "android.intent.category.BROWSABLE" },
        DataScheme = "ridecommand-orv")]
[IntentFilter(
        new[] { "android.intent.action.VIEW" },
        Categories = new[] { "android.intent.category.DEFAULT", "android.intent.category.BROWSABLE" },
        DataScheme = "riderxorv",
        DataHost = "bnc.lt",
        DataPathPrefix = "/RFZm")]
[IntentFilter(
        new[] { "android.intent.action.VIEW" },
        Categories = new[] { "android.intent.category.DEFAULT", "android.intent.category.BROWSABLE" },
        DataScheme = "riderxorv",
        DataHost = "open")]
[IntentFilter(
        new[] { Android.Content.Intent.ActionView },
        Categories = new[] { Android.Content.Intent.CategoryDefault, Android.Content.Intent.CategoryBrowsable },
        DataScheme = "https",
        DataHost = "bnc.lt",
        DataPathPrefix = "/RFZm")]
public class MainActivity : MauiAppCompatActivity
{
    // Branch Setup Pieces:
    // - Intent filters set up (above)
    // - Package Name for Android demo app set to: net.weathernation.mobile.orvtrails

    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        //BranchAndroid.Init(this, App.DevBranchIoKey, (IBranchBUOSessionInterface)App.Current);
        BranchAndroid.Init(this, App.StageBranchIoKey, (IBranchBUOSessionInterface)App.Current);
    }

    protected override void OnNewIntent(Intent intent)
    {
        base.OnNewIntent(intent);

        // RC-10755
        // When the app is in the background, OnNewIntent() is called when a branch link is tapped on and our app is selected on the "Open with" OS dialog.
        // The Branch link is then handled as an "App Link", and the intent.Data property holds the Branch link URI.
        // This method is called before the InitSessionComplete() method is, where the Branch link CustomData is parsed and handled by the appropriate
        // IDeepLinkPlugin. If we don't set the intent here the branchObject in InitSessionComplete won't have the data it needs to be processed.
        // From the Branch docs: https://help.branch.io/developers-hub/docs/xamarin-android#initialize-branch-1
        // "The OnNewIntent method must be overriden to retrieve the latest link identifier when the app becomes active due to a Branch link click."
        this.Intent = intent;
    }
}