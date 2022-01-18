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
            Console.WriteLine($"3. feladat: EU tagállamainak száma: {tagok.Count} db");
            //4.
            Console.WriteLine($"4. feladat: 2007-ben {tagok.Where(x => x.dátum.Year == 2007).Count()} ország csatlakozott");
            //5.
            Console.WriteLine($"5. feladat: magyarország csatlakozásának dátuma: {tagok.Find(x => x.név == "Magyarország").dátum:d}");
        }
    }
}
