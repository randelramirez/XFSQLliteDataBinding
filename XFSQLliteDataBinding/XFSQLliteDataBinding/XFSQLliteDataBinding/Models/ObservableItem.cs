using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace XFSQLliteDataBinding.Models
{
    public class ObservableItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        Item item;
        public ObservableItem()
        {
            // Wrapping the Item model inside this ObservableItem
            // We could just instead create ObservableItem with INotifyPropertyChanged and the properties without the model
            // But for this example we decided to reuse the Item model
            item = new Item();
        }
        public string Title
        {
            set
            {
                if (!value.Equals(item.Title, StringComparison.Ordinal))
                {
                    item.Title = value;
                    OnPropertyChanged("Title");

                    // The compiler converts the code above to:
                    //OnPropertyChanged("Title");
                }
            }
            get
            {
                return item.Title;
            }
        }

        public string Description
        {
            set
            {
                if (!value.Equals(item.Description, StringComparison.Ordinal))
                {
                    item.Description = value;
                    OnPropertyChanged("Description");
                }
            }

            get
            {
                return item.Description;
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
