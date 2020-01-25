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
    public partial class ItemPageUsingViewModel2 : ContentPage
    {

        TitleViewModel2 titleViewModel2;

        public ItemPageUsingViewModel2()
        {
            InitializeComponent();
            titleViewModel2 = new TitleViewModel2();
            titleViewModel2.Title = "First";
            this.BindingContext = titleViewModel2;
        }

        private async void DisplayButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Item Object", "Title property:" + titleViewModel2.Title.ToString(), "OK");
        }

        private async void UpdateButtonClicked(object sender, EventArgs e)
        {
            // the code below will also update the UI, because we are implementing INotifyPropertyChanged on the model
            titleViewModel2.Title = "Data Model Updated (the model inherits from a base class)";
            await DisplayAlert("Item Object", "Title property:" + titleViewModel2.Title.ToString(), "OK");
        }
    }
}