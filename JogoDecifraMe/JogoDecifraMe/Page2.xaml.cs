using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JogoDecifraMe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var texto = entryResposta.Text;
            if (texto.ToUpper().Equals("AZUL"))
            {
                await Navigation.PushAsync(new Page3());
            }
            else
            {
                await DisplayAlert("A Esfinge fala:", "Continue assim meu estômago agradece!", "OK");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}