using Xamarin.Forms;

namespace MasterDetailLearning
{
	public partial class MasterDetailLearningPage : MasterDetailPage
	{
		public MasterDetailLearningPage()
		{
			InitializeComponent();
			Detail = new NavigationPage(new Page1());
			IsPresented = false;
		}
		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Detail = new NavigationPage(new Page1());
			IsPresented = false;
		}
		void Handle_Clicked2(object sender, System.EventArgs e)
		{
			Detail = new NavigationPage(new Page2());
			IsPresented = false;
		}
	}
}
