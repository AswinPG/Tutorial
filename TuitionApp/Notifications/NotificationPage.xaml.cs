using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuitionApp.Notifications
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotificationPage : ContentPage
    {
        public NotificationPage()
        {
            InitializeComponent();
        }
        private void Notification_Back(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        private void Back(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }


    }
}