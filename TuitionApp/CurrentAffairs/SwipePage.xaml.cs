using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuitionApp.CurrentAffairs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwipePage : ContentPage
    {
        public SwipePage()
        {
            InitializeComponent();
        }
        private async void Swiped_Up(object sender, SwipedEventArgs e)
        {
            MainFrame.TranslateTo(0, -700, 300);
            MidFrame.FadeTo(.5);
            MidFrame.TranslateTo(0, -5, 100);
            LowFrame.FadeTo(0);
            await MainFrame.FadeTo(0);
            MidFrame.TranslateTo(0, 0, 0);
            await MainFrame.TranslateTo(0, 0, 0);
            LowFrame.FadeTo(1);
            MidFrame.FadeTo(1);
            MainFrame.FadeTo(1);
        }
        private void Notification(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Notifications.NotificationPage());
        }
        private void Back(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

    }
}