using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMaster.Service.DTO
{
    public class Book
    {
        public string Title { get; set; }

        public long BookId { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public DateTime UpdateTime { get; set; }

        public string LastChapter { get; set; }

        public string Image { get; set; }
    }
}
