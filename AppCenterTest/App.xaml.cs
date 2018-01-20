using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace AppCenterTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppCenterTestPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start($"android=99278131-4880-47ba-9909-cbf0121eceee;ios=89f45fda-5859-4496-85e7-f5aa810fb05f",
    typeof(Analytics), typeof(Crashes));
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
