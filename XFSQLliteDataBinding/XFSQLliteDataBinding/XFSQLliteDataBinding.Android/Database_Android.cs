using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using Xamarin.Forms;
using XFSQLliteDataBinding.DataAccess;
using XFSQLliteDataBinding.Droid;

[assembly: Dependency(typeof(Database_Android))]
namespace XFSQLliteDataBinding.Droid
{
    public class Database_Android : IDatabase
    {
        public Database_Android() { }
        public SQLiteConnection DBConnect()
        {
            var filename = "ItemsSQLite.db3";
            string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(folder, filename);
            var connection = new SQLiteConnection(path);
            return connection;
        }
    }
}