using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webgentle.BookStore.Models;
using Webgentle.BookStore.Repositary;

namespace Webgentle.BookStore.Properties.Controllers
{
        public class BookController : Controller
        {

        private readonly BookRepositary _bookRepositary = null;

        public BookController()
        {
            _bookRepositary = new BookRepositary();
        }
            public ViewResult GetAllBooks()
            {
                //var data = _bookRepositary.GetAllBooks();
                  return View();
            }

            public BookModel GetBookByID(int id)
            {
                return _bookRepositary.GetABookByID(id);
            }

            public List<BookModel> SearchBooks(string BookName, string AuthorName)
            {
                return _bookRepositary.SearchBooks(BookName,AuthorName);
            }

        }
    }
