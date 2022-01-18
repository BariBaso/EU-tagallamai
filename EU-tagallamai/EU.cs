using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EU_tagallamai
{
    class EU
    {
        static void Main(string[] args)
        {
            List<Class1> tagok = new List<Class1>();
            foreach (var x in File.ReadAllLines("EUcsatlakozas.txt"))
            {
                tagok.Add(new Class1(x));
            }

            //3.
            Console.WriteLine($"EU tagállamainak száma: {tagok.Count}");

        }
    }
}
