using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Studerende Nikolai = new Studerende("Nikolai", 25, 1);
            Studerende Jannick = new Studerende("Jannick", 2, 5);
            Studerende Frederick = new Studerende("Frederick", 5, 9);
            KlasseRum klasse3b = new KlasseRum();
            klasse3b.SemesterStart = new DateTime(2018, 9, 4);
            klasse3b.KlasseListe.Add(Nikolai);
            klasse3b.KlasseListe.Add(Jannick);
            klasse3b.KlasseListe.Add(Frederick);

            Console.WriteLine(Nikolai.Navn + " " + klasse3b.SemesterStart);
            foreach (Studerende x in klasse3b.KlasseListe)
            {
                Console.WriteLine(x.Navn + " dag:" + x.Fødselsdag + " måned:" + x.Fødselsmåned);
            }
            Console.WriteLine(Nikolai.Season() + Jannick.Season() + Frederick.Season());

            klasse3b.CountSeasons();

            Console.ReadKey();
            Console.ReadLine();
        }
    }
}
