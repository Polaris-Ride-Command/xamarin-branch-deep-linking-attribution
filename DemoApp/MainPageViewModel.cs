using System;

namespace DemoApp
{
	public class MainPageViewModel
	{
        public string Title { get; } = "Welcome to the .NET MAUI demo app for the Branch.io SDK iOS & Android binding projects";

        public string Step3
        {
            get
            {
                if (Microsoft.Maui.Devices.DeviceInfo.Current.Platform == Microsoft.Maui.Devices.DevicePlatform.iOS)
                {
                    return "3.) Background this app, paste the link into Reminders or Notes, then tap on it";
                }
                else
                {
                    return "3.) Background this app and paste the link into a browser";
                }
            }
        }

        public Command CopyLinkCommand
        {
            get
            {
                return new Command(async () =>
                {
                    //var branchLink = App.DevBranchLink;
                    var branchLink = App.StageBranchLink;

                    await Clipboard.Default.SetTextAsync(branchLink);
                });
            }
        }
    }
}

