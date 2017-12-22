using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {
           XmlDocument document = new XmlDocument();
            document.Load("Book.xml");
            //var children =document.ChidNodes;
            var root = document.DocumentElement;
            XmlElement element = document.CreateElement("book");
            element.SetAttribute("id", "34-03432324");
            root.AppendChild(element);
         
            foreach (XmlNode child in root.ChildNodes)
            {
                Book book = new Book();
                book.id = Guid.Parse(child.Attributes["Id"].InnerText);
            }
        }
    }
}
