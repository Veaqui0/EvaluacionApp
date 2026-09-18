using EvaluacionApp.Model;

namespace EvaluacionApp;

public partial class MainPage : ContentPage
{

	private List<Pelicula> catalogo = new()
    {
	    new Pelicula { Nombre = "La estrategia del Caracol", Director = "Sergio Cabrera", Anio=1993 },
        new Pelicula { Nombre = "El penalti más largo del mundo",  Director = "Roberto Santiago", Anio=2005 },
    	new Pelicula { Nombre = "Atrápame si puedes", Director = "Steven Spielberg", Anio=2002 },
    };	

	public MainPage()
	{
		InitializeComponent();
		peliculasCollectionView.ItemsSource = catalogo;
	}

	   private async void OnPeliculaClick(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is not Pelicula peliculaElegida)
            return;
 
        var parametros = new Dictionary<string, object>
        {
            { "NombrePelicula", peliculaElegida.Nombre },
            { "DirectorPelicula", peliculaElegida.Director },
			{ "AnioPelicula", peliculaElegida.Anio }
        };
 
        await Shell.Current.GoToAsync(nameof(DetallePeliculaPage), parametros);
 
        peliculasCollectionView.SelectedItem = null;
    }
	

}
