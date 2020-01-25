using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFSQLliteDataBinding.ViewModels;

namespace XFSQLliteDataBinding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemPageUsingItemViewModel : ContentPage
    {
        private ItemViewModel itemViewModel;

        public ItemPageUsingItemViewModel()
        {
            InitializeComponent();
            itemViewModel = new ItemViewModel();
            itemViewModel.Title = "First";
            this.BindingContext = itemViewModel;
        }


        private async void DisplayButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Item Object", "Title property:" + itemViewModel.Title.ToString(), "OK");
        }

        private async void UpdateButtonClicked(object sender, EventArgs e)
        {
            // the code below will also update the UI, because we are implementing INotifyPropertyChanged on the model
            itemViewModel.Title = "Data Model Updated (INotifyPropertyChanged on the ViewModel)";
            await DisplayAlert("Item Object", "Title property:" + itemViewModel.Title.ToString(), "OK");
        }
    }
}