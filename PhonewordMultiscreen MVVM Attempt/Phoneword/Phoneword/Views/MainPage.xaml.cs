using System;
using Xamarin.Forms;

namespace Hooli
{
	public partial class MainPage : BaseView
    {
        string translatedNumber;

        public MainPage()
        {
			BindingContext = App.Locator.UserName;
			InitializeComponent ();
			base.Init ();
			Title = "Details";
        }
			
        void Login(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CallHistoryPage());
        }
    }
}