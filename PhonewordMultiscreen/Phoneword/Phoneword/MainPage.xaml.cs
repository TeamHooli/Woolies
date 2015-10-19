using System;
using Xamarin.Forms;



namespace Phoneword
{
	public partial class MainPage : MasterDetailPage
    {
        string translatedNumber;

        public MainPage()
        {
            InitializeComponent();
        }
			
        void Login(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VerticalMenu());
        }

		void DiscountButtonClick(object sender, EventArgs e)
		{
			Navigation.PushAsync(new DiscountPage());
		}
    }
}