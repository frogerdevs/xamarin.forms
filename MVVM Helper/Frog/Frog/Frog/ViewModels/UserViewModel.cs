using Frog.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Frog.Data;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Frog.Models;
using Frog.ViewModels.Base;
using Frog.Views.User;
using Xamarin.Forms;

namespace Frog.ViewModels
{
    public class UserViewModel : BaseViewModel
    {

        public MockData Data { get; set; }
        public ObservableCollection<User> Users { get; set; }
        public ICommand AddCommand { get; set; }
        public UserViewModel()
        {
            Users = App.Instance.Data.Users;

            AddCommand = new Command(() => { Navigation.PushAsync(new UserItemPage());});
        }

        public void DeleteUser(User user)
        {
            App.Instance.Data.DeleteUser(user);
        }
    }
}
