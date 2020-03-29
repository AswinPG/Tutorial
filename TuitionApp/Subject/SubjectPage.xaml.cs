using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuitionApp.Subject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubjectPage : ContentPage
    {
        public SubjectPage()
        {
            InitializeComponent();
        }
        private void Notification(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Notifications.NotificationPage());
        }
        private void Notification_Back(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void StudyNotes_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StudyNotes.StudyNotesPage());
        }
        private void Forum_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Forum.ForumPage());
        }
    }
}