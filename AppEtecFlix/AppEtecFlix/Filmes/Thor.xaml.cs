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
    public partial class Thor : ContentPage
    {
        public Thor()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.etecflix.png");
            poster.Source = ImageSource.FromResource("AppEtecFlix.Posters.thor4.jpg");

            sinopse.Text = "Thor: Amor e Trovão é quarta aventura solo de Thor (Chris Hemsworth), personagem da Marvel. O próximo filme do super-herói pretende ser a sequência direta de Thor: Ragnarok e o 29º filme do Universo Cinematográfico Marvel. O longa, além de representar os acontecimentos de Thor: Ragnarok, promove a volta de Jane Foster (Natalie Portman), que se transforma na versão feminina de Thor. Os Guardiões da Galáxia terão papel importante na história, trazendo aventuras que podem fazer o filho de Odin questionar seu papel enquanto Deus do Trovão,  precisando contar com o apoio de grandes aliados como Valquíria (Tessa Thompson) e Korg (Taika Waititi) para enfrentar suas lutas. O filme ainda apresenta Gorr (Christian Bale) - sendo o grande vilão da narrativa - e ainda, Zeus (Russell Crowe).";
        }
    }
}