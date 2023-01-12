using System.Diagnostics;
using BranchXamarinSDK;

namespace DemoApp;

public partial class App : Application, /*IBranchSessionInterface,*/ IBranchBUOSessionInterface
{
    // DEV
    // Note: this option does NOT work on the iOS simulator for some reason. Works fine on iOS devices.
    //public const string DevBranchIoKey = "key_test_eoMhNwmzvq3WUBYiBF8XNbboAElr16yQ"; // Key for the "Polaris RC Stage/Dev TEST" app in the Branch.io portal (dev environment)
    //public const string DevBranchLink = "https://up0q.test-app.link/Eq74AgIEiwb";     // "Branch demo waypoint"

    // STAGE
    // Note: this works on iOS devices and simulator
    public const string StageBranchIoKey = "key_live_bnVgKwoqFtZZUy9fErZWNbdprBgFY9FF"; // Key for the "Polaris RC Stage/Dev LIVE" app (stage environment)
    public const string StageBranchLink = "https://up0q.app.link/NGAbM2xQvwb";          // "Branch demo waypoint (stage)"


    // iOS Branch Setup Checklist:
    // DEV
    //     API key and link: Dev variables (above)
    //            Bundle ID: com.polarisindustries.ORVTrails
    //     Signing Identity: Developer (Automatic)
    // Provisioning Profile: Tom S ORV Dev PP
    //   CFBundleURLSchemes: riderxorv
    // Entitlements file
    //  com.apple.developer.associated-domains: applinks:up0q.test-app.link

    // STAGE
    //     API key and link: Stage variables (above)
    //            Bundle ID: com.polarisindustries.orvtrails.inhouse
    //     Signing Identity: Developer
    // Provisioning Profile: Distribution: Polaris Industries, Inc.
    //            Signed by: In-House (Automatic) or Polaris Ride Command (In-House)
    //   CFBundleURLSchemes: riderxorv
    // Entitlements file
    //  com.apple.developer.associated-domains: applinks:up0q.app.link


    public App(MainPage page)
	{
		InitializeComponent();

		MainPage = new NavigationPage(page);
	}

    // Doesn't look like this method is ever called. This is part of the IBranchSessionInterface, but I think we only use IBranchBUOSessionInterface in the RC apps
    //public void InitSessionComplete(Dictionary<string, object> data)
    //{
    //    Debug.WriteLine($"InitSessionComplete");
    //    Debug.WriteLine("data");

    //    foreach (var item in data)
    //        Debug.WriteLine($" {item.Key}: {item.Value}");
    //}

    /// <summary>
    /// This method gets called after the Branch library initialization on app launch and after the app is opened by a branch link
    /// </summary>
    public async void InitSessionComplete(BranchUniversalObject buo, BranchLinkProperties blp)
    {
        Debug.WriteLine($"Branch Universal Object InitSessionComplete");

        Debug.WriteLine("bou (Branch Universal Object)");
        foreach (var item in buo.ToDictionary())
        {
            if (item.Key == "$keywords")
            {
                Debug.Write($" {item.Key}: ");
                foreach (var keyword in item.Value as List<string>)
                    Debug.Write($"{keyword} ,");

                Debug.Write(Environment.NewLine);
            }
            else
            {
                Debug.WriteLine($" {item.Key}: {item.Value}");
            }
        }

        Debug.WriteLine("blp (Branch Link Properties)");
        foreach (var item in blp.ToDictionary())
        {
            if (item.Key == "~tags")
            {
                Debug.Write($" {item.Key}: ");
                foreach (var tag in item.Value as List<string>)
                    Debug.Write($"{tag} ,");

                Debug.Write(Environment.NewLine);
            }
            else if (item.Key == "control_params")
            {
                Debug.WriteLine($" {item.Key}: ");
                foreach (var cp in item.Value as Dictionary<string, string>)
                    Debug.WriteLine($"  {cp.Key}: {cp.Value}");
            }
            else
            {
                Debug.WriteLine($" {item.Key}: {item.Value}");
            }
        }

        var referringParams = Branch.GetInstance().GetLastReferringParams();
        if (referringParams != null)
        {
            Debug.WriteLine("Referring Parameters");

            foreach (var param in referringParams)
                Debug.WriteLine($" {param.Key}: {param.Value}");


            await NavigateToDetailsPage(referringParams);
        }
    }

    /// <summary>
    /// Navigate to the link details page if the referringParams indicate that the user clicked on a Branch link
    /// </summary>
    private async Task NavigateToDetailsPage(Dictionary<string, object> referringParams)
    {
        if (referringParams.ContainsKey("+clicked_branch_link"))
        {
            var objectValue = referringParams["+clicked_branch_link"];
            var canParseBool = bool.TryParse(objectValue.ToString(), out bool clickedBranchLink); // for Android

            // iOS uses 1 and 0 instead of True and False
            if (Microsoft.Maui.Devices.DeviceInfo.Current.Platform == Microsoft.Maui.Devices.DevicePlatform.iOS)
            {
                var clickediOSBranchLink = objectValue.ToString() == "1";

                if (clickediOSBranchLink)
                    canParseBool = clickedBranchLink = true;
            }

            if (canParseBool && clickedBranchLink)
            {
                Debug.WriteLine("");
                Debug.WriteLine($"Branch link was clicked!");

                var vm = new LinkDetailsViewModel
                {
                    ReferringParams = referringParams
                };

                await Application.Current.MainPage.Navigation.PushAsync(new LinkDetailsPage(vm));
            }
        }
    }

    public void SessionRequestError(BranchError error)
    {
        Debug.WriteLine("---------------------------------------");
        Debug.WriteLine($"Branch session request error, {error.ErrorCode}: {error.ErrorMessage}");
        Debug.WriteLine("---------------------------------------");
    }
}