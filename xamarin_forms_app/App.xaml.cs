using Xamarin.Forms;

namespace xamarin_forms_app
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new xamarin_forms_appPage();
        }

        protected override void OnStart()
        {
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
