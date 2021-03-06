﻿using BookMaster.Service.Context;
using BookMaster.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMaster.Service.Service
{
    public class BookService
    {
        public BookContext Context = new BookContext();

        public List<PersonalBook> GetAll()
        {
            if (!Context.DatabaseExists())
            {
                Context.CreateDatabase();
            }
            if (Context.GetTable<PersonalBook>().Count()==0)
            {
                TestCreate();
            }
            return Context.GetTable<PersonalBook>().ToList();
        }

        public void TestCreate()
        {
            for(int i = 1; i < 10; i++)
            {
                PersonalBook book = new PersonalBook();
                book.Author = "南派三叔";
                book.BookId = 0;
                book.ChapterId = 0;
                book.ChapterTitle = "黄河鬼棺";
                book.Title = "盗墓笔记"+i;
                book.Id = i;
                book.UpdateTime = DateTime.Now;
                Context.GetTable<PersonalBook>().InsertOnSubmit(book);
            }
            Context.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
        }
    }
}
