using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFSQLliteDataBinding.DataAccess;

namespace XFSQLliteDataBinding
{
    public partial class App : Application
    {
        // USE THIS
        //  basic respository (database class only)

        static ItemDatabaseBasic database;
        public static ItemDatabaseBasic Database
        {
            get
            {
                if (database == null)
                {
                    database = new ItemDatabaseBasic();
                }
                return database;
            }
        }


        // OR THIS (but not both)
        //  advanced respository (repository and generic database class)
        static ItemRepository repository;
        public static ItemRepository Repository
        {
            get
            {
                if (repository == null)
                {
                    repository = new ItemRepository();
                }
                return repository;
            }
        }

        public App()
        {
            InitializeComponent();

            //MainPage = new ItemPage();
            //MainPage = new ItemPageUsingViewModel();
            //MainPage = new ItemPageUsingViewModel2();
            //MainPage = new ItemPageUsingBindableModel();
            //MainPage = new ItemPageUsingItemViewModel();
            //MainPage = new ItemPageEditingProperties();
            //MainPage = new EditableListView();


            //SQLite
            MainPage = new NavigationPage(new HomePage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
