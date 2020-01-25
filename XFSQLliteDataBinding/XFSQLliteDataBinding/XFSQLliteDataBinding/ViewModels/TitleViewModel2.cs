using System;
using System.Collections.Generic;
using System.Text;
using XFSQLliteDataBinding.Models;

namespace XFSQLliteDataBinding.ViewModels
{
    public class TitleViewModel2 : BindableBase
    {
        string title;

        public string Title
        {
            set
            {
                if (!value.Equals(title, StringComparison.Ordinal))
                {
                    title = value;
                    base.OnPropertyChanged("Title");
                }
            }
            get
            {
                return title;
            }
        }
    }
}
