namespace EvaluacionApp;

[QueryProperty(nameof(NombrePelicula), "NombrePelicula")]
[QueryProperty(nameof(DirectorPelicula), "DirectorPelicula")]
[QueryProperty(nameof(AnioPelicula), "AnioPelicula")]
public partial class DetallePeliculaPage : ContentPage
{
    public string NombrePelicula
    {
        set => nombreLabel.Text = value;
    }

    public string DirectorPelicula
    {
        set => directorLabel.Text = value;
    }

    public int AnioPelicula
    {
        set => anioLabel.Text = value.ToString();
    }

    public DetallePeliculaPage()
    {
        InitializeComponent();
    }
    private async void OnVolverClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}