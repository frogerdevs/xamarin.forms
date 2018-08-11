using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Frog.Views.MainMenu;
using Xamarin.Forms;
using Frog.Data;
namespace Frog
{
	public partial class App : Application
	{
        public MockData Data { get; set; }
        public App ()
		{
			InitializeComponent();

            Data = new MockData();
			MainPage = new MainMenu();
		}
	    private static volatile App _instance;
	    private static object syncRoot = new Object();

	    public static App Instance
	    {
	        get
	        {
	            if (_instance == null)
	            {
	                lock (syncRoot)
	                {

	                    if (_instance == null)
	                        _instance = new App();
	                }
	            }

	            return _instance;
	        }
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
