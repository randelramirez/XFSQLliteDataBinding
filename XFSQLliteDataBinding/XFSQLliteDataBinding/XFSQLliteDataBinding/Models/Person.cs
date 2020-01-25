using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using XFSQLliteDataBinding.DataAccess;

namespace XFSQLliteDataBinding.Models
{
    public class Person : IObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [MaxLength(25)]
        public string FirstName { get; set; }
        [MaxLength(25)]
        public string LastName { get; set; }

    }
}
