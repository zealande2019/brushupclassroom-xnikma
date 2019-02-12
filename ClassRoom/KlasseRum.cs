using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class KlasseRum
    {
        public string KlasseNavn;
        public List<Studerende> KlasseListe;
        public DateTime SemesterStart;

        public KlasseRum()
        {
            this.KlasseListe = new List<Studerende>();
        }
        public void CountSeasons()
        {

            int sommer = 0, autumn = 0, winter = 0, spring = 0;
            foreach (Studerende x in this.KlasseListe)
            {
                int month = x.Fødselsmåned;
                if (month == 1 || month == 2 || month == 12)
                {
                    ++winter;
                }
                if (month >= 3 && month <= 5)
                {
                    ++spring;
                }
                if (month >= 6 && month <= 8)
                {
                    ++sommer;
                }
                if (month >= 9 && month <= 11)
                {
                    ++autumn;
                }
            }
            Console.WriteLine("Fødsels Sæsonner");
            Console.WriteLine("Vinter: " + winter);
            Console.WriteLine("Forår: " + spring);
            Console.WriteLine("Sommer: " + sommer);
            Console.WriteLine("Efterår: " + autumn);
        }
    }
}
