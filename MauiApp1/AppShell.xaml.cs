using MauiApp1.Views;

namespace MauiApp1;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		InitializeRouting();

    }

	void InitializeRouting()
	{
		Routing.RegisterRoute(nameof(DetailsView), typeof(DetailsView));
        Routing.RegisterRoute("Author", typeof(AuthorView));
        Routing.RegisterRoute("Telephone", typeof(TelephoneView));
    }
}
