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
    public partial class Aventura : ContentPage
    {
        public Aventura()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.etecflix.png");

            btnBatman.Source = ImageSource.FromResource("AppEtecFlix.Posters.thebatman.jpg");
            btnDoutorEstranho.Source = ImageSource.FromResource("AppEtecFlix.Posters.doutorestranho.jpg");
            btnThorAmorTrovao.Source = ImageSource.FromResource("AppEtecFlix.Posters.thor4.jpg");
            btnHomemAranha.Source = ImageSource.FromResource("AppEtecFlix.Posters.homem_aranha.png");
        }

        private async void Btn_Open_Batman(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Batman());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "OK");
            }
        }

        private async void Btn_Open_DoutorEstranho(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new DoutorEstranho());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "OK");
            }
        }

        private async void Btn_Open_Thor(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Thor());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "OK");
            }
        }

        private async void Btn_Open_HomemAranha(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new HomemAranha());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "OK");
            }
        }
    }
}