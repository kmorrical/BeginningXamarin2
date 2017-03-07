using Xamarin.Forms;

namespace MasterDetailLearning
{
	public partial class App : Application
	//inherits from application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MasterDetailLearningPage();
			//tells the application what the root page is
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
