using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuitionApp.Forum
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReplyPage : ContentPage
    {
        public ReplyPage()
        {
            InitializeComponent();
            List<Models.CommentsViewModel> a = new List<Models.CommentsViewModel>
            {
                new Models.CommentsViewModel
                {
                    Author="DestinyTheGame",
                    Avatar="alarmclock.png",
                    Date="19h",
                    ReplyComment="Y'all said that casual players shouldn't get awarded. Y'all said ToO was to place for casual players. Y'all said that its's meant for the top players. Well, now we're all leaving.",
                },
                new Models.CommentsViewModel
                {
                    Author="DestinyTheGame",
                    Avatar="alarmclock.png",
                    Date="19h",
                    ReplyComment="Y'all said that casual players shouldn't get awarded. Y'all said ToO was to place for casual players. Y'all said that its's meant for the top players. Well, now we're all leaving.",
                },
                new Models.CommentsViewModel
                {
                    Author="DestinyTheGame",
                    Avatar="alarmclock.png",
                    Date="19h",
                    ReplyComment="Y'all said that casual players shouldn't get awarded. Y'all said ToO was to place for casual players. Y'all said that its's meant for the top players. Well, now we're all leaving.",
                },

            };
            CommentsListView.ItemsSource = a;
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