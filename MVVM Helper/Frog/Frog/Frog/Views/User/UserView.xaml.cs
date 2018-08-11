using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Frog.ViewModels;

namespace Frog.Views.User
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserView : ContentPage
	{
        public UserViewModel Model { get; set; }
        public UserView ()
		{
			InitializeComponent ();

            Model = new UserViewModel(){Navigation = Navigation};
            BindingContext = Model;
		}

	    private async void ListUser_OnItemTapped(object sender, ItemTappedEventArgs e)
	    {
	        if(!(e.Item is Models.User item))
                return;

	        await Navigation.PushAsync(new UserItemPage(item));

	        ListUser.SelectedItem = null;
	    }

	    private async void MenuDelete_OnClicked(object sender, EventArgs e)
	    {
	        var menuitem = ((MenuItem) sender);
	        var usr = menuitem.CommandParameter as Models.User;
	        var answer = await DisplayAlert("Delete User ", $"Delete User {usr.UserName}", "Delete", "Cancel");

	        if(answer)
	            Model.DeleteUser(usr);
	    }
	}
}