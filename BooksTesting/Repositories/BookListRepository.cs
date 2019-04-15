using BooksTesting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BooksTesting.Repositories
{
    public class BookListRepository:IBookListRepository
    {
        private static List<BookModel> bookModel = new List<BookModel>();

        //private Guid contactId;
        /// <summary>
        /// Get Books List
        /// </summary>
        /// <returns></returns>
        public JsonResult GetBooksList()
        {
            //log : start get book list
            try
            {
                if (bookModel == null || bookModel.Count == 0)
                {
                    bookModel = XmlOperations.readXML();
                }
                return new JsonResult() { Data = bookModel };
                //end log 
            }

            catch (Exception ex)
            {
                //throw null;
                return new JsonResult() { Data = bookModel };
            }
        }
        /// <summary>
        /// Borrow
        /// </summary>
        /// <param name="BookID"></param>
        /// <param name="username"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public JsonResult Borrow(string bookID,string username)
        {
            bool result = false;
            try
            {
                var book = bookModel.FirstOrDefault(o => o.Id == bookID);
                if (book != null)
                {
                    book.BorrowBy = new UserModel() { Name = username };
                }
                result = true;
            }
            catch (Exception ex)
            {
                // log errir here 
                throw ex;
            }
            return new JsonResult() { Data = result };
        }
        /// <summary>
        /// UndoBorrow
        /// </summary>
        /// <param name="bookID"></param>
        /// <returns></returns>
        public JsonResult UndoBorrow(string bookID)
        {
            bool result = false;
            try
            {
                var book = bookModel.FirstOrDefault(o => o.Id == bookID);
                if (book != null)
                {
                    book.BorrowBy = null;
                }
                result = true;
            }
            catch (Exception ex)
            {
                // log errir here 
                throw ex;
            }
            return new JsonResult() { Data = result };
        }
    }
}