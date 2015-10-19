using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Phoneword
{
	public partial class BreakfastPage : ContentPage
	{
		public BreakfastPage ()
		{
			
			InitializeComponent ();
				
		}

		void Recipe1Click(object sender, EventArgs e)
		{
			Navigation.PushAsync(new BreakfastRecipe1());
		}
	}


}

