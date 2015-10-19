using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Phoneword
{
	public partial class RecipePage : ContentPage
	{
		public RecipePage ()
		{
			InitializeComponent ();
		}

		void DailySuggestionButtonClick(object sender, EventArgs e)
		{

			Navigation.PushAsync(new DailySuggestionPage());
		}

		void BreakfastButtonClick(object sender, EventArgs e)
		{

			Navigation.PushAsync(new BreakfastPage());
		}

		void AppetizersButtonClick(object sender, EventArgs e)
		{

			Navigation.PushAsync(new AppetizersPage());
		}

		void DrinksButtonClick(object sender, EventArgs e)
		{

			Navigation.PushAsync(new DrinksPage());
		}

		void LunchButtonClick(object sender, EventArgs e)
		{

			Navigation.PushAsync(new LunchPage());
		}
	}
}

