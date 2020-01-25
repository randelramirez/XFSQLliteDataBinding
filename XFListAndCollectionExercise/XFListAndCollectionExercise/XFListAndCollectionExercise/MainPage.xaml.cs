using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFListAndCollectionExercise.Models;

namespace XFListAndCollectionExercise
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var products = new ObservableCollection<Product>();
            products.Add(new Product { Id = 1, Name = "HP Envy 17", Price = 1400 });
            products.Add(new Product { Id = 2, Name = "HP Envy 15", Price = 1200 });
            products.Add(new Product { Id = 1, Name = "iPhone 11 Pro", Price = 1300 });
            products.Add(new Product { Id = 1, Name = "Macbook Pro 2019", Price = 1600 });
            products.Add(new Product { Id = 1, Name = "Samsung Galaxy S10 Edge", Price = 1100 });
            products.Add(new Product { Id = 1, Name = "Samsung 43 Monitor", Price = 700 });
            products.Add(new Product { Id = 1, Name = "iMac", Price = 1700 });
            products.Add(new Product { Id = 1, Name = "iPhone X", Price = 900 });
            products.Add(new Product { Id = 1, Name = "iPad Pro", Price = 1200 });
            products.Add(new Product { Id = 1, Name = "iPhone X Pro", Price = 1200 });


            ProductList.ItemsSource = products;
        }
    }
}
