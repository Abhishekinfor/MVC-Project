using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webgentle.BookStore.Models;

namespace Webgentle.BookStore.Repositary
{
    public class BookRepositary
    {
        public List<BookModel> GetAllBooks() {
            return DataSource();
        }

        public BookModel GetABookByID(int id)
        {
            return DataSource().Where(x => x.ID == id).FirstOrDefault();
        }

        public List<BookModel> SearchBooks(string BookName, string AuthorName)
        {
            return DataSource().Where(x => x.Title == BookName && x.Author == AuthorName).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
              new BookModel(){ID=1, Title="MVC", Author="Nitish"},
              new BookModel(){ID=2, Title="MVC", Author="John"},
              new BookModel(){ID=3, Title="C#", Author="Monika"},
              new BookModel(){ID=4, Title="Java", Author="Webgentle"},
              new BookModel(){ID=5, Title="PHP", Author="Webgentle"},
            };
            
        }
    }
}
