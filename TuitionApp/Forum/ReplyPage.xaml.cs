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