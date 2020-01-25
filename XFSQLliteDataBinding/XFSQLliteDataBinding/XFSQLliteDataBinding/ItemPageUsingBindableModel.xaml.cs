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
    public partial class ItemPageUsingBindableModel : ContentPage
    {
        private ItemBindable model;

        public ItemPageUsingBindableModel()
        {
            InitializeComponent();
            model = new ItemBindable();
            model.Title = "First";
            this.BindingContext = model;
        }

        private async void DisplayButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Item Object", "Title property:" + model.Title.ToString(), "OK");
        }

        private async void UpdateButtonClicked(object sender, EventArgs e)
        {
            // the code below will also update the UI, because we are implementing INotifyPropertyChanged on the model
            model.Title = "Data Model Updated (INotifyPropertyChanged on the model)";
            await DisplayAlert("Item Object", "Title property:" + model.Title.ToString(), "OK");
        }
    }
}