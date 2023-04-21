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
            XmlDocument doc = new XmlDocument();
            doc.Load("C:/Users/digis/Documents/Angel Rafael Acosta Villa/AAcostaConsiss/XML/DatosXML.xml");

            foreach (XmlNode n1 in doc.DocumentElement.ChildNodes)
            {
                bool noticia = n1.Attributes["noticia"] != null;

                foreach (XmlNode n2 in n1.ChildNodes)
                {
                    Console.WriteLine(n2.Name + " " + n1.InnerText);
                }
            }
            Console.ReadLine();
        }
    }
}