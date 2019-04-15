using BooksTesting.Models;
using BooksTesting.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace BooksTesting.Controllers
{
    public class BookApiController : ApiController
    {


        protected readonly IBookListRepository bookListRepository;
       // uowRepo uow = new uowRepo(new XmlOperations());


        public BookApiController()
        {
            this.bookListRepository = new BookListRepository();
        }

        public JsonResult BorrowBook(string id, string username)
        {
             return bookListRepository.Borrow(id, username);
           // return uow.bookListRepository.Borrow(id, username);
        }
    }
}
