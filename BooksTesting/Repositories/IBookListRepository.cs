using BooksTesting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BooksTesting.Repositories
{
    public interface IBookListRepository
    {
        JsonResult GetBooksList();
        JsonResult Borrow(string bookID,string username);
        JsonResult UndoBorrow(string bookID);
    }
}