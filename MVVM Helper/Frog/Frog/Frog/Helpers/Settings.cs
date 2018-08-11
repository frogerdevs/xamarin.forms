using System;
using System.Collections.Generic;
using System.Text;
using Frog.Theme;
using Xamarin.Forms;

namespace Frog.Helpers
{
    public enum Theme
    {
        Light,
        Dark
    }

    public static class Settings
    {
        public static void SetTheme(Theme theme)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                switch (theme)
                {
                    case Theme.Dark:
                        Application.Current.Resources.MergedWith = typeof(DarkTheme);
                        break;
                    case Theme.Light:
                        Application.Current.Resources.MergedWith = typeof(LightTheme);
                        break;
                    default:
                        break;
                }
            });
        }
    } 
}
