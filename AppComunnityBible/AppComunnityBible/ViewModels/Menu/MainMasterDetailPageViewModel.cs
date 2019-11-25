using AppCommunityBible.Data.Context;
using AppCommunityBible.Data.Repositories;
using AppCommunityBible.Models.Menu;
using AppCommunityBible.Views;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;


namespace AppCommunityBible.ViewModels.Menu
{
    public class MainMasterDetailPageViewModel
    {

        public ICommand ItemSelectedCommand { get; private set; }

        public ObservableCollection<MasterPageItem> ListItemSource { get; private set; }

        public MainMasterDetailPageViewModel(IBibleRepository repository)
        {
            ItemSelectedCommand = new Command<SelectedItemChangedEventArgs>(OnItemSelected);

            ListItemSource = new ObservableCollection<MasterPageItem>();
            ListItemSource.Add(new MasterPageItem() { Title = "Buscar", TargetType = typeof(PageSearch) });
            ListItemSource.Add(new MasterPageItem() { Title = "Biblia", TargetType = typeof(PageBibleBooks) });
            ListItemSource.Add(new MasterPageItem() { Title = "Configuracion", TargetType = typeof(PageConfiguration) });

            var books = repository.GetBooksAsync().Result;
        }

        private void OnItemSelected(SelectedItemChangedEventArgs e)
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
