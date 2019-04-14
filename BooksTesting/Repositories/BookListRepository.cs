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
        private List<BookModel> bookModel = new List<BookModel>();

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
                bookModel = XmlOperations.readXML();
                return new JsonResult() { Data = bookModel };
                //end log 
            }
            
            catch(Exception ex)
            {
                throw null;
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
                book.BorrowBy = new UserModel() {  };
                result = true;
            }
            catch (Exception ex)
            {
                // lof errir here 
                throw ex;
            }
            return new JsonResult() { Data = result };
        }
    }
}