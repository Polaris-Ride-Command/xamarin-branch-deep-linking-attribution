using System.Diagnostics;
using BranchXamarinSDK;

namespace DemoApp;

public partial class App : Application, IBranchSessionInterface, IBranchBUOSessionInterface
{
    // Links to test:
    public const string DevBranchLink = "https://up0q.test-app.link/Eq74AgIEiwb"; // "Branch demo waypoint", dev env.
    public const string StageBranchLink = "https://up0q.app.link/NGAbM2xQvwb";
    // You can add ?debug=true to the end of any of these links to debug them in the branch.io portal and see all the link details


    // This is the key for the "Polaris RC Stage/Dev TEST" app in the Branch.io portal (dev environment)
    public const string DevBranchIoKey = "key_test_eoMhNwmzvq3WUBYiBF8XNbboAElr16yQ";

    // This is the key for the "Polaris RC Stage/Dev LIVE" (stage environment)
    public const string StageBranchIoKey = "key_live_bnVgKwoqFtZZUy9fErZWNbdprBgFY9FF"; // trying this for iOS


    // 1/11/23 - links on iOS aren't opening the app for some reason
    // iOS Branch Setup:
    // DEV
    //  Bundle ID: com.polarisindustries.ORVTrails
    // App Prefix: 3ZAM7Q8RD6
    //  Signed by: Tom S ORV Dev PP

    // STAGE
    //  Bundle ID: com.polarisindustries.orvtrails.inhouse
    // App Prefix: YZHSD6YVEJ                              // Enterprise dev program
    //  Signed by: Polaris Ride Command (In-House)


    public App(MainPage page)
	{
		InitializeComponent();

		MainPage = new NavigationPage(page);
	}

    public void InitSessionComplete(Dictionary<string, object> data)
    {
        Debug.WriteLine($"InitSessionComplete");
        Debug.WriteLine("data");

        foreach (var item in data)
            Debug.WriteLine($" {item.Key}: {item.Value}");
    }

    public async void InitSessionComplete(BranchUniversalObject buo, BranchLinkProperties blp)
    {
        // This method gets called after the Branch library initialization and after the app is opened by a branch link

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

            
            if (referringParams.ContainsKey("+clicked_branch_link"))
            {
                var objectValue = referringParams["+clicked_branch_link"];
                var canParseBool = bool.TryParse(objectValue.ToString(), out bool clickedBranchLink);

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
    }

    public void SessionRequestError(BranchError error)
    {
        Debug.WriteLine($"Branch session request error, {error.ErrorCode}: {error.ErrorMessage}");
    }
}