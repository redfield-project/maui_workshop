using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class DetailsView : ContentPage
{
	public DetailsView(DetailsViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}