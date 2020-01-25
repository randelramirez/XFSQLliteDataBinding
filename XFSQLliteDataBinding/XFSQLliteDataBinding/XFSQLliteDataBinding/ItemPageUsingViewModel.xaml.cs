using System;
using System.Collections.Generic;
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
    public partial class ItemPageUsingViewModel : ContentPage
    {
        TitleViewModel titleViewModel;

        public ItemPageUsingViewModel()
        {
            InitializeComponent();
            titleViewModel = new TitleViewModel();
            titleViewModel.Title = "First";
            this.BindingContext = titleViewModel;
        }

        private async void DisplayButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Item Object", "Title property:" + titleViewModel.Title.ToString(), "OK");
        }

        private async void UpdateButtonClicked(object sender, EventArgs e)
        {
            // the code below will also update the UI, because we are implementing INotifyPropertyChanged on the model
            titleViewModel.Title = "Data Model Updated";
            await DisplayAlert("Item Object", "Title property:" + titleViewModel.Title.ToString(), "OK");
        }
    }
}