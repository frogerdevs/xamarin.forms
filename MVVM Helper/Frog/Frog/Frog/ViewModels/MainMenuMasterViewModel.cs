using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Frog.Annotations;
using Frog.Data;
using Frog.Models;
using Frog.ViewModels.Base;
using Xamarin.Forms;

namespace Frog.ViewModels
{
    public class MainMenuMasterViewModel : BaseViewModel
    {
        public MockData Data { get; set; }
        public MainMenuMasterViewModel()
        {
            Data = new MockData();
            MenuItems = Data.MainMenuItems;

        }
        public ObservableCollection<MainMenuItem> MenuItems { get; set; }


        public void MenuItemTaped(MainMenuItem item)
        {
            var mdp = App.Current.MainPage as MasterDetailPage;
            var nmspace = App.Instance.GetType().Namespace;
            var clsname = string.Format("{0}.{1}", nmspace, item.ClassName);
            Type pagetyp = Type.GetType(clsname, true);
            var page = (Page)Activator.CreateInstance(pagetyp);
            page.Title = item.Text;
            if (mdp != null)
            {
                mdp.Detail = new NavigationPage(page);
            }

            mdp.IsPresented = false;


        }
    }
}
