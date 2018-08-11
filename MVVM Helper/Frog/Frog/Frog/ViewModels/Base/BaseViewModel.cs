using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Frog.ViewModels.Base
{
    public class BaseViewModel: ObservableObject, INavigation
    {
        public BaseViewModel()
        {
            
        }

        private bool isBusy = false;
        public bool IsBusy
        {
            get => isBusy;
            set => SetProperty(ref isBusy, value);
        }

        private string _title = string.Empty;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        #region INavigation

        private INavigation _navigation;

        public INavigation Navigation
        {
            get => _navigation;
            set => _navigation = value;
        }

        public Page Main
        {
            get => Application.Current?.MainPage;
            set => Application.Current.MainPage = value;
        }
        public void InsertPageBefore(Page page, Page before)
        {
            _navigation?.InsertPageBefore(page, before);
        }

        public async Task<Page> PopAsync()
        {
            var task = _navigation?.PopAsync();
            return task != null ? await task : await Task.FromResult(null as Page);
        }

        public async Task<Page> PopAsync(bool animated)
        {
            var task = _navigation?.PopAsync(animated);
            return task != null ? await task : await Task.FromResult(null as Page);
        }

        public async Task<Page> PopModalAsync()
        {
            var task = _navigation?.PopModalAsync();
            return task != null ? await task : await Task.FromResult(null as Page);
        }

        public async Task<Page> PopModalAsync(bool animated)
        {
            var task = _navigation?.PopModalAsync(animated);
            return task != null ? await task : await Task.FromResult(null as Page);
        }

        public async Task PopToRootAsync()
        {
            var task = _navigation?.PopToRootAsync();
            if (task != null)
                await task;
        }

        public async Task PopToRootAsync(bool animated)
        {
            var task = _navigation?.PopToRootAsync(animated);
            if (task != null)
                await task;
        }

        public async Task PushAsync(Page page)
        {
            var task = _navigation?.PushAsync(page);
            if (task != null)
                await task;
        }

        public async Task PushAsync(Page page, bool animated)
        {
            var task = _navigation?.PushAsync(page, animated);
            if (task != null)
                await task;
        }

        public async Task PushModalAsync(Page page)
        {
            var task = _navigation?.PushModalAsync(page);
            if (task != null)
                await task;
        }

        public async Task PushModalAsync(Page page, bool animated)
        {
            var task = _navigation?.PushModalAsync(page, animated);
            if (task != null)
                await task;
        }

        public void RemovePage(Page page)
        {
            _navigation?.RemovePage(page);
        }

        public IReadOnlyList<Page> ModalStack => _navigation?.ModalStack;
        public IReadOnlyList<Page> NavigationStack => _navigation?.NavigationStack;

        #endregion
    }
}
