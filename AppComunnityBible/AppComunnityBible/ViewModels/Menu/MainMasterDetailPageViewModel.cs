using AppComunnityBible.Models.Menu;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppComunnityBible.ViewModels.Menu
{
    public class MainMasterDetailPageViewModel
    {
        public ICommand ItemSelectedCommand { get; private set; }

        public MainMasterDetailPageViewModel()
        {
            ItemSelectedCommand = new Command<SelectedItemChangedEventArgs>(OnItemSelected);
        }

        void OnItemSelected(SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;

            if (item != null) {
                var mainPage = (MasterDetailPage)Application.Current.MainPage;
                var page = (Page)Activator.CreateInstance(item.TargetType);
                page.Title = item.Title;

                mainPage.Detail = new NavigationPage(page);
                mainPage.IsPresented = false;
            }
        }
    }
}
