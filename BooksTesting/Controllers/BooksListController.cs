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
        protected JsonResult GetBooksList()
        {
            return bookListRepository.GetBooksList();
        }
        protected JsonResult BorrowBook(string id,string username)
        {
            return bookListRepository.Borrow(id, username);
        }
        public ActionResult Index()
        {
            return View("/Views/BooksList/index.cshtml", this.GetBooksList());
        }
    }
}