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
        [Column(IsDbGenerated =false, IsPrimaryKey =true, DbType ="bigint")]
        public long Id { get; set; }

        [Column(DbType = "bigint")]
        public long BookId { get; set; }

        [Column(DbType = "nvarchar(255)")]
        public string Title { get; set; }

        [Column(DbType = "nvarchar(255)")]
        public string Author { get; set; }
        [Column(DbType = "bigint")]
        public long ChapterId { get; set; }

        [Column(DbType = "nvarchar(255)")]
        public string ChapterTitle { get; set; }
        [Column(DbType = "datetime")]
        public DateTime UpdateTime { get; set; }

        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
