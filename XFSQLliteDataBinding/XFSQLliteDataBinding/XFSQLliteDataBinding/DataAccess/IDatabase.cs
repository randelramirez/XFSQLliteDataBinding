using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XFSQLliteDataBinding.DataAccess
{
    public interface IDatabase
    {
        SQLiteConnection DBConnect();
    }
}
