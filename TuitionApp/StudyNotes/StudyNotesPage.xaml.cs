using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuitionApp.StudyNotes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudyNotesPage : ContentPage
    {
        public StudyNotesPage()
        {
            InitializeComponent();
        }
        private void Notification(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Notifications.NotificationPage());
        }

        private void Note_Tapped(object sender, EventArgs e)
        {

        }
        private void Notification_Back(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}