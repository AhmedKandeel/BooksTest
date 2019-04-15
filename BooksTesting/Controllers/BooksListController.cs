using BooksTesting.Models;
using BooksTesting.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BooksTesting.Controllers
{
    public class BooksListController : Controller
    {
        protected readonly IBookListRepository bookListRepository;
        public BooksListController()
        {
            this.bookListRepository = new BookListRepository();
        }
        public JsonResult GetBooksList()
        {
            return bookListRepository.GetBooksList();
        }
        
        public JsonResult BorrowBook(string id= null, string username = null)
        {
            return bookListRepository.Borrow(id, username);
        }
        public JsonResult UndoBorrowBook(string id = null)
        {
            return bookListRepository.UndoBorrow(id);
        }
        public ActionResult Index()
        {
            return View("/Views/BooksList/index.cshtml", this.GetBooksList());
        }
    }
}