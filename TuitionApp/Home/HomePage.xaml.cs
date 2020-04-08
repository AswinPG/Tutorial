using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuitionApp.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private void SubjectTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Subject.SubjectPage());
        }
        private void CA_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CurrentAffairs.SwipePage());
        }
        private void Notification(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Notifications.NotificationPage());
        }
        private void Forum_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Forum.ForumPage());
        }

    }
}