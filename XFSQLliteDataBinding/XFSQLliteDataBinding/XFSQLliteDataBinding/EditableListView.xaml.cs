using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFSQLliteDataBinding.Models;
using XFSQLliteDataBinding.ViewModels;

namespace XFSQLliteDataBinding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditableListView : ContentPage
    {
        ListViewModel items;

        public EditableListView()
        {
            InitializeComponent();
            items = new ListViewModel();
            this.ItemListView.ItemsSource = items.Items;
            this.BindingContext = items;
        }

        public async void EditClicked(object sender, EventArgs e)
        {
            items.Items[0].Title = "First Edited";
            await DisplayAlert("Item Object", "First row edited", "OK");

        }

        public async void DeleteClicked(object sender, EventArgs e)
        {
            items.Items.RemoveAt(0);
            await DisplayAlert("Delete", "Row deleted", "OK");
        }

        public async void ReplaceClicked(object sender, EventArgs e)
        {
            items.Replace();
            await DisplayAlert("Replace", "List replaced con Español", "OK");
            this.ItemListView.ItemsSource = this.items.Items;
            this.BindingContext = items;
        }

        public async void ListItemTapped(object sender, ItemTappedEventArgs e)
        {
            ObservableItem item = (ObservableItem)e.Item;
            await DisplayAlert("Tapped", item.Title.ToString() + " was selected.", "OK");
            ((ListView)sender).SelectedItem = null;
        }
    }

}