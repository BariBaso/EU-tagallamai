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
            //6.
            Console.WriteLine($"6. feladat: Májusban {(tagok.Any(x => x.dátum.Month == 05) ? "vonlt": "Nem volt")} csatlakozás!");
            //7.
            Console.WriteLine($"7. feladat: Legutoljáta csatlakozott ország: {tagok.OrderBy(x => x.dátum).Last().név}");
            //8.
            Dictionary<int, int> statisztika = new Dictionary<int, int>();

            foreach (var s in tagok)
            {
                if (statisztika.ContainsKey(s.dátum.Year))
                {
                    statisztika[s.dátum.Year]++;
                }
                else
                {
                    statisztika.Add(s.dátum.Year, 1);
                }
            }

        }
    }
}
