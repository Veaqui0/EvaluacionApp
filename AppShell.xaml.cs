namespace EvaluacionApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(DetallePeliculaPage), typeof(DetallePeliculaPage));
	}
}
