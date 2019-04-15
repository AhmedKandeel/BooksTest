using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using System.Configuration;
using static BooksTesting.Models.BookModel;
using System.Reflection;

namespace BooksTesting.Models
{
    public class XmlOperations
    {
        /// <summary>
        /// Read XML file
        /// </summary>
        /// <returns>
        /// list books
        /// </returns>
        public static List<BookModel> readXML()
        {
            //define varaible
            // add log start readXML function 
            List<BookModel> listOfBooks = null;
            try
            {
                string xmlPath= ConfigurationManager.AppSettings.Get("XMLPath");
                if (!string.IsNullOrEmpty(xmlPath))
                {
                   XmlSerializer serializer = new XmlSerializer(typeof(Catalog));
                   using (FileStream fileStream = new FileStream(HttpContext.Current.Server.MapPath(xmlPath), FileMode.Open))
                   {
                       Catalog result = (Catalog)serializer.Deserialize(fileStream);
                       listOfBooks = result.Book;
                   }  
                }
            }
            catch (Exception ex)
            {
                //log your expoection here    
                throw ex;
            }
            // add log end readXML function 
            return listOfBooks;
        }
    }
}