using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Frog.Models;
using Frog.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Frog.Views.MainMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenuMaster : ContentPage
    {
        private MainMenuMasterViewModel Model = new MainMenuMasterViewModel();

        public MainMenuMaster()
        {
            InitializeComponent();

            BindingContext = Model;
        }

        private void MenuItemsListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as MainMenuItem;
            if (item == null)
                return;

            Model.MenuItemTaped(item);

        }
    }
}