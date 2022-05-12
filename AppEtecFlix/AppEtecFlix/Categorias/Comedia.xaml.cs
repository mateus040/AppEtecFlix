using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppEtecFlix.Filmes;

namespace AppEtecFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Comedia : ContentPage
    {
        public Comedia()
        {
            InitializeComponent();


            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.etecflix.png");

            btnCarasMalvados.Source = ImageSource.FromResource("AppEtecFlix.Posters.caras_malvados.jpg");
        }

        private async void Btn_Open_CarasMalvados(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new CarasMalvados());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "OK");
            }
        }
    }
}