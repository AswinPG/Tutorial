using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuitionApp.Authentication.Interfaces;
using TuitionApp.Authentication.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuitionApp.Authentication.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public static IGoogleAuthenticator _googleManager = DependencyService.Get<IGoogleAuthenticator>();
        public GoogleUser GoogleUser { get; private set; }
        public bool IsLogedIn { get; private set; }

        public LoginPage()
        {
            InitializeComponent();
        }







        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                ChangeLook();
                _googleManager.Logout();
                _googleManager.Login(OnLoginComplete);

            }
            catch (Exception x)
            { 
                ChangeBackLook();
                await DisplayAlert("Authentication Failed", "Your Authentication Attempt Failed. Please try again..", "Ok");
            }
        }

        private async void OnLoginComplete(GoogleUser googleUser, string message)
        {
            if (googleUser != null)
            {
                GoogleUser = googleUser;
                try
                {
                    AppUser User = await DependencyService.Get<IFireBaseAuthenticator>().LoginWithGoogle(googleUser.token, null);
                    Application.Current.Properties["User"] = User.Uid;
                }
                catch (Exception e)
                {
                    await DisplayAlert("Oops", "Firebase Error", "Ok");
                    ChangeBackLook();
                }

                IsLogedIn = true;
                await DisplayAlert("Success", message, "Ok");
                ChangeBackLook();
            }
            else
            {
                ChangeBackLook();
                await DisplayAlert("Error", message, "Ok");
            }
        }
        private void ChangeLook()
        {
            MainLayout.Opacity = .5;
            LoadingLayout.IsVisible = true;
        }
        private void ChangeBackLook()
        {
            MainLayout.Opacity = 1;
            LoadingLayout.IsVisible = false;
        }
    }
}