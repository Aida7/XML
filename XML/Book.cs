using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace XML
{
    public class Book
    {
        public Guid id { get; set; }
        public string Nmae { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
