using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bergsen_BlackJack
{
    class CardHandler
    {
        string[] typ;
        int[] arrayNummer;
        private List<string> UsedCards;

        public CardHandler()        //Konstruktur, instansierar en ny string array, som lagrar värden av korttyper och en int array som lagrar kortvärden
        {
            typ = new string[] { "Spader", "Hjärter", "Klöver", "Ruter" };             
            arrayNummer = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }; 
            UsedCards = new List<string>();                   //Instansierar en ny List<string> som ska lagra kort som har dragits

        }


        public string genereraKort()
        {

            while(true)            //Loopa oändligt tills break eller något returneras
            {
                Random rand = new Random();         // Ny random klass, som används för att randomisera ett index (plats) i arrayerna

                var randomIndex = rand.Next(0, typ.Length);                      //randomIndex representerar platsen som slumpmässigt blev vald för korttypen
                var randomindexInt = rand.Next(0, arrayNummer.Length);           //ranomdindexInt representerar platsen som slumpmässigt blev valt för kortvärdet
                var nummer = arrayNummer[randomindexInt];                               //tar fram vad det är för värde på platsen, exempelvis "6"
                var typKort = typ[randomIndex];                                                 //tar fram vad det är för korttyp på platsen, exempelvis "Hjärter"
                string varde = typKort + nummer;                    //Beroende på kombinationen av randomiseringen så ska string variabeln bli korttyp + kortnumret, exempelvis "Hjärter6"

                Boolean kontroll = KontrolleraOmKortFinns(varde);      //Metoden som kontrollerar om kortet redan har dragits (om kortet finns i UsedCards)
                if (!kontroll == true)
                {                                                       //Om metoden returnerat false så kan kortet användas och kortet läggs då in i usedCards och return används, metoden stoppas, annars loopas om till ett kort som inte dragits dras
                    this.UsedCards.Add(varde);
                    return varde;
                }

            }

        }

        private Boolean KontrolleraOmKortFinns(string varde)     //Metod som kollar om kortet som drogs redan finns i UsedCards, returnerar antingen true eller false beroende på om kortet redan finns
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

        public void clearCheckList() //Ta bort alla kort från UsedCards
        {
            UsedCards.Clear();

        }

    }
}