using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Hooli.Data.ViewModel;
using Hooli.Data;

namespace Hooli
{
	public class App : Application
	{
		private static ViewModelLocator _locator;
		private static NavigationService nav;
		public static ViewModelLocator Locator
		{
			get
			{
				return _locator ?? (_locator = new ViewModelLocator());
			}
		}

		public App ()
		{

			// The root page of your application
			MainPage = GetMainPage();

		}

		public Page GetMainPage()
		{
			nav = new NavigationService ();
			nav.Configure (ViewModelLocator.MainPageKey, typeof(MainPage));
			nav.Configure (ViewModelLocator.CallHistoryPageKey, typeof(CallHistoryPage));
			SimpleIoc.Default.Register<IMyNavigationService> (()=> nav, true);
			var navPage = new NavigationPage (new Hooli.MainPage());
			nav.Initialize (navPage);
			return navPage;
		}
		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}