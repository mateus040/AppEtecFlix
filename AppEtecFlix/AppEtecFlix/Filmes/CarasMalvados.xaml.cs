using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEtecFlix.Filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarasMalvados : ContentPage
    {
        public CarasMalvados()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.etecflix.png");
            poster.Source = ImageSource.FromResource("AppEtecFlix.Posters.caras_malvados.jpg");

            sinopse.Text = "Depois de uma vida inteira de assaltos lendários, os notórios criminosos Sr. Lobo, Sr. Cobra, Sr. Piranha, Sr. Tubarão e Srta. Tarântula são finalmente capturados. Para evitar uma sentença de prisão, os bandidos animais devem realizar seu golpe mais desafiador até agora - tornando-se cidadãos-modelo. Sob a tutela de seu mentor, Professor Marmelada, a duvidosa gangue se propõe a enganar o mundo e mostrar que está se tornando boa.";
        }
    }
}