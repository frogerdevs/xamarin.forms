using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frog.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Frog.Views.User
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserItemPage : ContentPage
	{
	    private UserItemViewModel viewModel;
		public UserItemPage (Models.User user = null)
		{
			InitializeComponent ();

		    BindingContext = viewModel = new UserItemViewModel(user) {Navigation = Navigation};
		}
	}
}