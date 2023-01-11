using System;

namespace DemoApp
{
	public class MainPageViewModel
	{
        public string Title { get; } = "Welcome to the .NET MAUI demo app for the Branch.io SDK iOS & Android binding projects";

        public Command CopyLinkCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var branchLink = App.DevBranchLink;
                    //var branchLink = App.StageBranchLink; // tried this for iOS

                    await Clipboard.Default.SetTextAsync(branchLink);
                });
            }
        }
    }
}

