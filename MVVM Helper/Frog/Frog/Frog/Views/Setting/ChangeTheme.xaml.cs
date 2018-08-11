using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frog.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Frog.Views.Setting
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChangeTheme : ContentPage
	{
		public ChangeTheme ()
		{
			InitializeComponent ();
		}

	    private void ButtonLight_OnClicked(object sender, EventArgs e)
	    {
	        Settings.SetTheme(Helpers.Theme.Light);
	    }
	    private void ButtonDark_OnClicked(object sender, EventArgs e)
	    {
	        Settings.SetTheme(Helpers.Theme.Dark);
        }
    }
}