using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Frog.Models;
using Frog.ViewModels.Base;
using Xamarin.Forms;

namespace Frog.ViewModels
{
    public class UserItemViewModel : BaseViewModel
    {
        public User User { get; set; }
        public ICommand SaveCommand { get; set; }

        public UserItemViewModel(User user = null)
        {
            User = user ?? new User();

            SaveCommand = new Command(Save);
        }

        private async void Save()
        {
            if(User.UserId != 0)
                App.Instance.Data.UpdateUser(User);
            else
            {
                App.Instance.Data.SaveUser(User);
            }

            await Navigation.PopAsync();
        }
    }
}
