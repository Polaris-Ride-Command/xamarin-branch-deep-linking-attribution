namespace DemoApp;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}

    async void CopyLinkButtonClicked(System.Object sender, System.EventArgs e)
    {
		await DisplayAlert("Branch Link Copied", "Go paste this link into a browser", "Sweet");
    }
}


