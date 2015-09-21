using System;

using Xamarin.Forms;
using Hooli.Data;

namespace Hooli
{
	public class BaseView : MasterDetailPage
	{
		public BaseView ()
		{

		}
		protected void Init(){

			var lifecycleHandler = this.BindingContext as IPageLifeCycleEvents;

			if (lifecycleHandler != null) {
				base.Appearing += (object sender, EventArgs e) => {
					lifecycleHandler.OnAppearing();
				};
				base.Disappearing += (object sender, EventArgs e) => {
					lifecycleHandler.OnDisappearing();
				};
				base.LayoutChanged += (object sender, EventArgs e) => {
					lifecycleHandler.OnLayoutChanged();
				};
			}
		}
	}
}


