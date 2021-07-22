using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bergsen_BlackJack
{
    class Programmability
    {
        string[] typ;
        int[] arrayNummer;
        private List<string> UsedCards;

        public Programmability()
        {
            this.typ = new string[] { "Spader", "Hjärter", "Klöver", "Ruter" };
            this.arrayNummer = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            this.UsedCards = new List<string>();

        }


        public string genereraKort()
        {

            while(true)
            {
                Random rand = new Random();

                var randomIndex = rand.Next(0, typ.Length);
                var randomindexInt = rand.Next(0, arrayNummer.Length);
                var nummer = arrayNummer[randomindexInt];
                var typKort = typ[randomIndex];
                string varde = typKort + nummer;

                Boolean kontroll = KontrolleraOmKortFinns(varde);
                if (!kontroll == true)
                {
                    this.UsedCards.Add(varde);
                    return varde;
                }

            }

        }

        private Boolean KontrolleraOmKortFinns(string varde)
        {

            foreach(string usedcard in UsedCards)
            {
               
                Console.WriteLine(usedcard);

            }


            int result = UsedCards.IndexOf(varde);

            if (result != -1)
            {
                Console.WriteLine("Hittade ett värde redan: " + varde);
                return true;
            }
            else
            {

                return false;

            }
        }

        public void clearCheckList()
        {
            UsedCards.Clear();

        }

    }
}