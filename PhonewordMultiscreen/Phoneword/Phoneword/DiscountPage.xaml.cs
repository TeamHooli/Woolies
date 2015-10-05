using System;
using System.Collections.Generic;


using Xamarin.Forms;

namespace Phoneword
{
	public partial class DiscountPage : ContentPage
	{
		public DiscountPage ()
		{
			InitializeComponent ();

			//this.ItemsSource = ProductModel1.All;
		}

		void onClickTest(object sender, EventArgs e)
		{
			//Testing.IsVisible = true;
		}


		int count =0;

		void changePicture(object sender, EventArgs e)
		{
			//if (Picture2.IsVisible == false && Picture3.IsVisible == false) {
				//Picture1.IsVisible = false;
				//Picture2.IsVisible=true;	
			//}

			count += 1;
			if (count == 1) {
				Picture1.IsVisible = false;
				Picture2.IsVisible=true;					
			}if (count == 2) {
				Picture2.IsVisible = false;
				Picture3.IsVisible = true;
			}if (count == 3) {
				Picture3.IsVisible = false;
				Picture1.IsVisible = true;
				count = 0;
			}

		}

		void changeProduct(){
			
		}

		//void loadPicture(object sender, EventArgs e){
			//var Product1Image = new Image{ Aspect=Aspect.AspectFit};
			//Product1Image.Source = ImageSource.FromResource ("Phoneword.Pictures.dummyProduct1.png");
		//}
	}
}

