namespace Evaluacion.Views
{
    public partial class PersonajeFavorito : ContentPage
    {
        public PersonajeFavorito()
        {
            InitializeComponent();
        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}