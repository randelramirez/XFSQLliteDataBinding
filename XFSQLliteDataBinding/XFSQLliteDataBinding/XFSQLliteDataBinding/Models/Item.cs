using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using XFSQLliteDataBinding.DataAccess;

namespace XFSQLliteDataBinding.Models
{
    public class Item : IObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(15)]
        public string Name { get; set; }

        [Ignore]
        public string Title { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }
    }
}
