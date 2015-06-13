using BookMaster.Service.Model;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMaster.Service.Context
{
    public class BookContext:DataContext
    {
        public BookContext() : base("Data Source='isostore:/bookdb.sdf';Password='111111'")
        {

        }

        public Table<PersonalBook> PersonalBook { get; set; }
    }
}
