namespace DemoApp;

public partial class LinkDetailsPage : ContentPage
{
	public LinkDetailsPage(LinkDetailsViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}
