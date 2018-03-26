using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Toll.K47.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application Start: {0}\n-----------------\n", DateTime.Now);

            XDocument xd = XDocument.Load("K47Base.xml");

            Console.WriteLine("***");
            foreach (XElement xe in xd.Elements())
                Console.WriteLine(xe.ToString());
            Console.WriteLine("***");

            Console.WriteLine("\n\n---------------\nApplication End: {0}", DateTime.Now);
        }
    }
}
