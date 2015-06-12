using BookMaster.Service.Model;
using BookMaster.Service.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMaster.WP8Client.ViewModels
{
    public class BookViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<PersonalBook> Items { get; private set; }

        public bool IsDataLoaded { get; internal set; }

        public BookViewModel()
        {
            BookService bs = new BookService();
            this.Items = bs.GetAll();
        }

        internal void LoadData()
        {
            BookService bs = new BookService();
            this.Items = bs.GetAll();
        }
    }
}
