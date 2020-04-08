using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuitionApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Quiz.QuizPage())
            {
                BarBackgroundColor = Color.FromHex("#ffffff"),
                BarTextColor = Color.FromHex("#6518E7")
            };

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
