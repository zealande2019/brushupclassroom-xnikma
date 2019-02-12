using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Studerende
    {
        public string Navn;
        public int Fødselsmåned;
        public int Fødselsdag;

        public Studerende()
        {

        }

        public Studerende(string navn, int fødselsdag, int fødselsmåned)
        {
            this.Navn = navn;
            this.Fødselsdag = fødselsdag;
            if (fødselsmåned > 0 && fødselsmåned < 13)
                this.Fødselsmåned = fødselsmåned;
            else
                this.Fødselsmåned = 1;
        }

        public string Season()
        {
            int month = this.Fødselsmåned;
            string x = "Autist";
            if (month == 1 || month == 2 || month == 12)
            {
                x = "Vinter";
            }
            if (month >= 3 && month <= 5)
            {
                x = "Forår";
            }
            if (month >= 6 && month <= 8)
            {
                x = "Sommer";
            }
            if (month >= 9 && month <= 11)
            {
                x = "Efterår";
            }
            return (this.Navn + " er født i " + x);
        }

    }
}
