using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class ToDoItemsView : ContentPage
{
	public ToDoItemsView(ToDoItemsViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}