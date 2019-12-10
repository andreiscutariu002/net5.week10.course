namespace Week09.XML.Serialization
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Publisher Publisher { get; set; }
    }

    public class Publisher
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var list = new List<Book>
            {
                new Book {Id = 1, Name = "Carte 1", Publisher = new Publisher {Id = 1, Name = "Mihai"}},
                new Book {Id = 2, Name = "Carte 2", Publisher = new Publisher {Id = 2, Name = "Andrei"}}
            };

            // json


            // xml

            var typeOfListBook1 = list.GetType();
            var typeOfListBook = typeof(List<Book>);
            var typeOfBook = typeof(Book);

            XmlSerializer xmlSerializer = new XmlSerializer(typeOfListBook);

            // stream de scriere [unde o sa scriem in timp ce serializam]
            StringWriter stringWriter = new StringWriter(); 
            StringBuilder sb = new StringBuilder();

            XmlWriter writer1 = XmlWriter.Create(stringWriter); 
            XmlWriter writer2 = XmlWriter.Create(sb); 
            XmlWriter writer3 = XmlWriter.Create("file.xml"); 

            xmlSerializer.Serialize(writer3, list);

            //var serializeXml = sb.ToString();
        }
    }
}
