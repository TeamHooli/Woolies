using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Phoneword
{
	public partial class VerticalMenu : ContentPage
	{
		public VerticalMenu ()
		{
			InitializeComponent ();
		}

		void RecipesButtonClick(object sender, EventArgs e)
		{

			Navigation.PushAsync(new RecipePage());
		}


		void DiscountButtonClick(object sender, EventArgs e)
		{

			Navigation.PushAsync(new DiscountPage());
		}



	}
}

