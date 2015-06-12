using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMaster.Service.Model
{
    [Table]
    public class PersonalBook : INotifyPropertyChanged, INotifyPropertyChanging
    {
        [Column(IsDbGenerated =true, IsPrimaryKey =true)]
        public long Id { get; set; }

        public long BookId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public long ChapterId { get; set; }

        public string ChapterTitle { get; set; }

        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
