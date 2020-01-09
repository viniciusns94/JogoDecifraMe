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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var texto = entryResposta.Text;
            if (texto.ToUpper().Equals("DECIFRA-ME"))
            {
                await Navigation.PushAsync(new Page2());
            } 
            else
            {
                await DisplayAlert("A Esfinge fala:", "Seus miolos são apetitosos. Vou devorá-los", "OK");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}