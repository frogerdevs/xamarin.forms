using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Frog.Annotations;
using Frog.Helpers;
using Frog.Models;

namespace Frog.Data
{
    public class MockData : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        #region INotifyPropertyChanged Implementation
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public ObservableCollection<MainMenuItem> MainMenuItems { get; set; }
        public ObservableCollection<User> Users { get; set; }
        public MockData()
        {
            LoadMainMenuItem();
            LoadUsers();
        }

        private void LoadMainMenuItem()
        {
            MainMenuItems = new ObservableCollection<MainMenuItem>()
            {
                new MainMenuItem{ NavigationId = 1,
                    ClassName = "Views.MainMenu.MainMenuDetail",
                    Icon = FontAwesomeFont.Info, Text = "Detail Page" },
                new MainMenuItem{ NavigationId = 2, ClassName = "Views.Setting.ChangeTheme",
                    Icon = FontAwesomeFont.Tachometer, Text = "Theme"},
                new MainMenuItem{ NavigationId = 3, ClassName= "Views.User.UserView",
                    Icon = FontAwesomeFont.User, Text="User"},
                new MainMenuItem{ NavigationId = 10000, ClassName = "",
                    Icon = FontAwesomeFont.SignOut, Text = "Logout"}

            };
        }

        private void LoadUsers()
        {
            Users = new ObservableCollection<User>()
            {
                new User{ UserId = 1 , UserName = "Xamarin", Password = "123456",
                        Image = "https://xamarin.com/content/images/pages/forms/example-app.png"},
                new User{ UserId = 2, UserName = "Forger", Password = "123456",
                        Image = "splash.png"}
            };
        }

        public void SaveUser(User user)
        {
            Users.Add(new User()
            {
                UserId =  Users.Count+1,
                UserName = user.UserName,
                Password = user.Password
            });
        }

        public void UpdateUser(User user)
        {
            var usr = Users.FirstOrDefault(x => x.UserId == user.UserId);
            usr.UserName = user.UserName;
            usr.Password = usr.Password;
        }

        public void DeleteUser(User user)
        {
            Users.Remove(user);
        }
    }
}
