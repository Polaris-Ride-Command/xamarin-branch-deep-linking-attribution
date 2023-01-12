namespace DemoApp;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}

    void CopyLinkButtonClicked(System.Object sender, System.EventArgs e)
    {
		linkButton.Text = "Link Copied!";
    }
}


