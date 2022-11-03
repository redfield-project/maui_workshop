using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class AboutView : ContentPage
{
	public AboutView(AboutViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}