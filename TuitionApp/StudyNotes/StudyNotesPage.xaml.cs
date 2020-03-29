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
            MainListView.ItemsSource = new List<Models.StudyNotesModel>
            {
                new Models.StudyNotesModel()
                {
                    ChapterNo="Chapter 1",
                    Heading="Indian space program closes out year with launch of upgraded GSLV",
                    SubHeading="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite, on December 19, 2018 at 1610 hrs (IST) from the Second Launch Pad (SLP) of Satish Dhawan Space Centre SHAR, Sriharikota. ",
                    Para="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite, on December 19, 2018 at 1610 hrs (IST) from the Second Launch Pad (SLP) of Satish Dhawan Space Centre SHAR, Sriharikota. ",
                    ImageSource=""
                },
                new Models.StudyNotesModel()
                {
                    ChapterNo="Chapter 1",
                    Heading="Indian space program closes out year with launch of upgraded GSLV",
                    SubHeading="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite, on December 19, 2018 at 1610 hrs (IST) from the Second Launch Pad (SLP) of Satish Dhawan Space Centre SHAR, Sriharikota. ",
                    Para="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite, on December 19, 2018 at 1610 hrs (IST) from the Second Launch Pad (SLP) of Satish Dhawan Space Centre SHAR, Sriharikota. ",
                    ImageSource=""
                }

            };
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
        //private async void NextPage(object sender, EventArgs e)
        //{
            //MainFrame.TranslateTo(-2000, 0, 600);
            //MidFrame.FadeTo(1);
            //MidFrame.TranslateTo(-200,0,300);
            //await MainFrame.FadeTo(0);
            //MidFrame.TranslateTo(0, 0, 0);
            //await MainFrame.TranslateTo(0, 0, 0);
            //MidFrame.FadeTo(1);
            //MainFrame.FadeTo(1);
        //}
    }
}