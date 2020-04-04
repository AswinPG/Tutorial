using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuitionApp.Quiz
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuizPage : ContentPage
    {
        public QuizPage()
        {
            
            InitializeComponent();
            List<Models.QuizViewModel> a = new List<Models.QuizViewModel>
            {
                new Models.QuizViewModel()
                {
                    Question="Question1",
                    Option1="Option1",
                    Option2="Option2",
                    Option3="Option3",
                    Option4="Option4",
                },
                new Models.QuizViewModel()
                {
                    Question="Question1",
                    Option1="Option1",
                    Option2="Option2",
                    Option3="Option3",
                    Option4="Option4",
                },
                new Models.QuizViewModel()
                {
                    Question="Question1",
                    Option1="Option1",
                    Option2="Option2",
                    Option3="Option3",
                    Option4="Option4",
                },
            };
            
            QuizList.ItemsSource = a;
        }
        private void Notification(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Notifications.NotificationPage());
        }
        private void Back(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void Opt1_Clicked(object sender, EventArgs e)
        {
            Button Opt = (Button)sender;
            Opt.BorderWidth = 2;
            Opt.BorderColor = Color.Blue;
        }

        private void Opt2_Clicked(object sender, EventArgs e)
        {
            Button Opt = (Button)sender;
            Opt.BorderWidth = 2;
            Opt.BorderColor = Color.Blue;
        }

        private void Opt3_Clicked(object sender, EventArgs e)
        {
            Button Opt = (Button)sender;
            Opt.BorderWidth = 2;
            Opt.BorderColor = Color.Blue;
        }

        private void Opt4_Clicked(object sender, EventArgs e)
        {
            Button Opt = (Button)sender;
            Opt.BorderWidth = 2;
            Opt.BorderColor = Color.Blue;
        }
        private void Finish(object sender, EventArgs e)
        {

        }
    }
}