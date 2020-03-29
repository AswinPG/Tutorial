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
    public partial class ForumPage : ContentPage
    {
        public ForumPage()
        {
            InitializeComponent();
            Stack1.ItemsSource = new List<Models.ForumViewModel>
            {
                new Models.ForumViewModel
                {
                    Author="DestinyTheGame",
                    Avatar="alarmclock.png",
                    Date="19h",
                    Heading="There's nothing better to me than streamers whining",
                    Para="Y'all said that casual players shouldn't get awarded. Y'all said ToO was to place for casual players. Y'all said that its's meant for the top players. Well, now we're all leaving.",
                    ImageSource="",
                    CommentsNo="22k"
                },
                new Models.ForumViewModel
                {
                    Author="DestinyTheGame",
                    Avatar="alarmclock.png",
                    Date="19h",
                    Heading="There's nothing better to me than streamers whining",
                    Para="Y'all said that casual players shouldn't get awarded. Y'all said ToO was to place for casual players. Y'all said that its's meant for the top players. Well, now we're all leaving.",
                    ImageSource="",
                    CommentsNo="22k"
                },
                new Models.ForumViewModel
                {
                    Author="DestinyTheGame",
                    Avatar="alarmclock.png",
                    Date="19h",
                    Heading="There's nothing better to me than streamers whining",
                    Para="Y'all said that casual players shouldn't get awarded. Y'all said ToO was to place for casual players. Y'all said that its's meant for the top players. Well, now we're all leaving.",
                    ImageSource="",
                    CommentsNo="22k"
                },
                new Models.ForumViewModel
                {
                    Author="DestinyTheGame",
                    Avatar="alarmclock.png",
                    Date="19h",
                    Heading="There's nothing better to me than streamers whining",
                    Para="Y'all said that casual players shouldn't get awarded. Y'all said ToO was to place for casual players. Y'all said that its's meant for the top players. Well, now we're all leaving.",
                    ImageSource="",
                    CommentsNo="22k"
                }
            };
        }
        private async void StartThreadFrameTapped(object sender, EventArgs e)
        {
            await StartThreadFrame.ScaleTo(.97, 100);
            await StartThreadFrame.ScaleTo(1, 100);
            StartThreadFrame.IsVisible = false;
            AddForumContainer.IsVisible = true;
            Stack1.IsVisible = false;
        }
        private void SubmitClicked(object sender, EventArgs e)
        {

            StartThreadFrame.IsVisible = true;
            AddForumContainer.IsVisible = false;
            Stack1.IsVisible = true;
        }
        private void ListView_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReplyPage());
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