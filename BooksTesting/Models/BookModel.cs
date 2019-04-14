using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BooksTesting.Models
{
    [XmlRoot(ElementName = "book")]
    public class BookModel
    {
        public UserModel BorrowBy { get; set; }

        public bool IsAvailable
        {
            get
            {
                bool result = true;
                if (BorrowBy != null)
                {
                    result = string.IsNullOrEmpty(BorrowBy.Name);
                }
                return result;
            }
        }

        public BookModel()
        {
            BorrowBy = new UserModel();
        }

        [XmlRoot(ElementName = "catalog")]
        public class Catalog
        {
            [XmlElement(ElementName = "book")]
            public List<BookModel> Book { get; set; }
        }

        [XmlElement(ElementName = "author")]
        public string Author { get; set; }
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
        [XmlElement(ElementName = "genre")]
        public string Genre { get; set; }
        [XmlElement(ElementName = "price")]
        public string Price { get; set; }
        [XmlElement(ElementName = "publish_date")]
        public string Publish_date { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }
}


