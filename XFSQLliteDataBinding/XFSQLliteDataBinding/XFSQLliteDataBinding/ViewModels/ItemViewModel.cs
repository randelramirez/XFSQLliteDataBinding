using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using XFSQLliteDataBinding.Models;

namespace XFSQLliteDataBinding.ViewModels
{
    // The INotifyPropertyChanged is implemented on the class and not on the actual model itself


    public class ItemViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        Item item;

        public ItemViewModel()
        {
            item = new Item();
        }

        // We wrap the title property of the model only(description is not included in the viewmodel), 
        // because that what's only needed in the view
        // View models typically contain only what is needed by their view.
        public string Title
        {
            get
            {
                return item.Title;
            }
            set
            {
                if (!value.Equals(item.Title, StringComparison.Ordinal))
                {
                    item.Title = value;
                    OnPropertyChanged("Title");
                }
            }
        }

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
