using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appli_Restos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void OnForgottenPasswordClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgottenPage { });
        }

        async void OnSignUpClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage { });
        }

        void OnConnectButtonClicked(object sender, EventArgs e)
        {
            if (mail.Text == null || password.Text == null || mail.Text == "" || password.Text == "")
            {
                DisplayAlert("Attention", "Veuillez entrer une adresse mail et un mot de passe", "OK");
            }
            else if (mail.Text == "toto" && password.Text == "toto") //CODER FONCTION IS_USER_IN_DB
            {
                // CONNECTION OK !!!! AFFICHER MAIN VUE !!
            }
            else
            {
                DisplayAlert("Attention", "Adresse mail ou mot de passe erroné", "OK");
            }
        }
    }
}