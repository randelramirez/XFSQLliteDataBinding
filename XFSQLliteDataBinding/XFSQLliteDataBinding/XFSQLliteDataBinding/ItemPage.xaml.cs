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
    public partial class ItemPage : ContentPage
    {
        private Item item;

        public ItemPage()
        {
            InitializeComponent();
            item = new Item { Title = "First", Description = "1st item" };
            this.BindingContext = item;
        }

        private async void ButtonClicked(object sender, EventArgs e)
        {
            /*
                trivial binding(not using INotifyPropertyChanged)
                the code below updates the actual model, but if you noticed, the UI does not reflect the changw
                uncomment the code below to see limitation of trivial binding
             */
            //item.Title = "Trivial binding";
            await DisplayAlert("Item Object", "Title property:" + item.Title.ToString(), "OK");
        }
    }
}