using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFSQLliteDataBinding.Models;

namespace XFSQLliteDataBinding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemPageEditingProperties : ContentPage
    {
        List<ObservableItem> items;

        public ItemPageEditingProperties()
        {
            InitializeComponent();
            items = new List<ObservableItem> {
                new ObservableItem {Title = "First", Description="1st item"},
                new ObservableItem {Title = "Second", Description="2nd item"},
                new ObservableItem {Title = "Third", Description="3rd item"}
            };

            this.BindingContext = items;
        }

        public async void EditClicked(object sender, EventArgs e)
        {
            items[0].Title = "First Edited";
            await DisplayAlert("Item Object", "First row edited", "OK");
        }

        public async void ListItemTapped(object sender, ItemTappedEventArgs e)
        {
            ObservableItem item = (ObservableItem)e.Item;
            await DisplayAlert("Tapped", item.Title.ToString() + " was selected.", "OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}