using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EU_tagallamai
{
    class Class1
    {
        public string név { get; set; }
        public DateTime dátum { get; set; }


        public Class1(string sor)
        {
            string[] t = sor.Split(';');
            név = t[0];
            dátum = Convert.ToDateTime(t[1]);
        }
    }
}
