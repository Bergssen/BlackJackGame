using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bergsen_BlackJack
{
    public partial class SpelRum : Form     
    {
        private int AntaletPengar = 5000;         //Fields, fält av olika datatyper och klasser som lagrar data och som ändras beroende på vad som händer under programmets gång.
        private int summaDealer = 0;
        private int summaSpelare = 0;
        private int satsadePengar = 0;
        private int kontrollSpelarDealer = 1;
        CardHandler drawCard;
        SoundPlayer player;
        SoundPlayer playerWin;     
        public SpelRum()       //Klassens konstruktor, kör koden nedan när kl
        {
            InitializeComponent();
            MaximizeBox = false;           //Tillåt inte omskalning av applikationen ddd
            MinimizeBox = false;
            Pengar.BackColor = Color.Transparent;   //Bakgrundsfärgen ska vara transparant
            SpelareSumma.BackColor = Color.Transparent;
            DealerSumma.BackColor = Color.Transparent;
            SpelareSumma.Hide();
            TextIPratbubbla.BackColor = Color.White;      //Sätt backgrundsfärg på rubrik containrar
            TextIPratbubbla.Hide();                       // Göm containrar när klassen 
            KortNummer.BackColor = Color.White;
            KortNummer.Hide();
            KortBild.Hide();
            Pratbubbla.Hide();

            DealerSumma.Hide();
            FormBorderStyle = FormBorderStyle.FixedSingle;   
            Pengar.Text = "Kr: " + AntaletPengar.ToString();  //Konvertera antalet pengar till string för att visas i Label1
            HitKnapp.Hide();
            StandKnapp.Hide();
            drawCard = new CardHandler();  //instansiering av nytt objekt av klassen Programmability, objektet drawCard kommer 
            player = new SoundPlayer(Bergsen_BlackJack.Properties.Resources.DrawCard);     //Ny instansiering av klasserna SoundPlayer, där vi skickar med åtkomstpunkten för ljuderfilerna, ena är för dragning av kortet, andra när spelaren vinner
            playerWin = new SoundPlayer(Bergsen_BlackJack.Properties.Resources.WinSound);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void Bet500_Click(object sender, EventArgs e)
        {
            kontrollSpelarDealer = 1;
            labelHideAndShow(500); //Kör metoden LabelHideAndShow där vi skickar med parameter på summans man satsar, detta kommer sedan lagras 
        }


        private void displayCounterOchCard()       //Metoden körs varje gång ett kort dras (antingen när spelaren trycker på bet eller hit, samt när dealern drar sina kort.
        {
            while (true) {                              //While(true) används här för att loopa oändligt, tills en "break" längre stannar loopen.

           string value = drawCard.genereraKort();                // Generera ett kort av typen string (genereraKort() returnerar en string)
           string cardType = "";                                  // Variabler som tillfälligt lagrar data, dessa är enbart "giltiga" inom klamrarna och försvinner när metoden har körts eller körs utanför klamrarna.
           string cardValueString = "";

            for (int i = 0; i < value.Length; i++)                  // metoden genereraKort() genererar ett värde av formatet ex: Klöver5, vi loopar igenom värdet och särskiljer på numret och bokstäverna med hjälp av Char.Isdigit()
            {                                                       // Loopar igenom alla bokstäver och lägger till dem i variabeln cardType, enbart för bokstäverna
                if (!Char.IsDigit(value[i]))
                    cardType = cardType + value[i];
            }

            for (int i = 0; i < value.Length; i++)                       //Loopar igenom strängen och tar enbart ut siffror från value, lägger till siffrorna i variabeln cardValueString, måste vara av typen string då de inte ska adderas
            {
                if (Char.IsDigit(value[i])) 
                    cardValueString = cardValueString + value[i];
            }

            int cardValueInt = Int32.Parse(cardValueString);              // Gör om från string till int, då vi ska ha värdet som nummer och inte sträng, lagra värdet i variabeln cardValueInt
                player.Play(); 
                visaKortOchNummer(cardType, cardValueInt); 

                if (cardValueInt == 11 | cardValueInt == 12 | cardValueInt == 13)       //Villkorssats, om värdet är 11 (knäckt), 12 (dam) eller 13 (kung) så ska det i blackjack räknas som 10.
            {
                cardValueInt = 10;
            }
            else if ((kontrollSpelarDealer == 1 & cardValueInt == 1 & (summaSpelare + 11) < 22) | (kontrollSpelarDealer == 0 & cardValueInt == 1 & (summaDealer + 11) < 22)) //Villkorssats, ett A ger alltid 11 om inte det skulle ge spelare mer än 21 för då blir det 1.
            {
                cardValueInt = 11;
            }

              if (kontrollSpelarDealer == 1)                        // kontrollSpelarDealer är en kontrollvariabel och används för se om det är spelaren eller dealer som drar kort.
                        {
                            
                             summaSpelare = summaSpelare + cardValueInt;               
                              SpelareSumma.Text = summaSpelare.ToString();          //Visa värdet av summaSpelare i containern
                            
                        if(summaSpelare > 21)
                            {
                        labelHideAndShow();
                        VannSpelare(false);
                        summaSpelare = 0;
                        break;                               // När det är spelaren som spelar så ska loopen alltid stoppas, då spelare ska ha möjlighet att välja "hit" eller "stop"
                                  }
                    else
                    {
                        break;
                    }



                        }


              if(kontrollSpelarDealer == 0)                           // Om det är dealern som spelar så ska loopen köras på till dealern antingen hamnar på samma värde som spelaren, eller högre,
                {                                                      // om dealern kommer över eller lika med spelaren men inte mer än 21 så vinner dealern, annars förlorar dealern.
                    DealerSumma.Show();
                    summaDealer = summaDealer + cardValueInt;
                    DealerSumma.Text = summaDealer.ToString();
                    ApplicationWait();                                     //Här används wait metoden där vi skickar med millisekundrar som parameter av typen int, wait-metoden ser till att pausa programmet 
                                                                    // så att spelaren ska kunna hinna se vilka kort dealern drar.
                    if (summaDealer > 21)
                    {
                        labelHideAndShow();
                        VannSpelare(true);
                        summaDealer = 0;
                        break;
                    }

                    else if ((summaDealer == summaSpelare & summaDealer < 21) | (summaDealer > summaSpelare & summaDealer < 22))
                    {
                        labelHideAndShow();
                        VannSpelare(false);
                        summaDealer = 0;
                        break;
                    }
                }

            }

        }


        private void Bet250_Click(object sender, EventArgs e)
        {
            kontrollSpelarDealer = 1;
            labelHideAndShow(250);

        }

        private void visaKortOchNummer(string korttyp, int varde)            // metoden bestämmer vilket kort (bild) och nummer det ska visas beroende vad metoden genereraKort() genererat, metoden anropas i metoden displayCounterAndCard()
        { 

            string tal;                              //Beroende på vilket villkor som stämmer så ska talet/korttypen visas

            if(varde == 1)
            {
                tal = "A";
            }
            else if (varde == 11)
            {
                tal = "Kn";
            }
            else if (varde == 12)
            {
                tal = "D";
            }
            else if (varde == 13)
            {
                tal = "K";
            }
            else
            { 
                tal = varde.ToString();         // konvertera om inkommet parametervärde varde int till string och lagra i variabeln tal
            }



            KortNummer.Show();
            KortBild.Show();

            if(korttyp == "Hjärter" | korttyp == "Ruter")
            {
                KortNummer.ForeColor = System.Drawing.Color.Red;    //Ändra färg på rubrik-containern, ruter och hjärter ska ha rött, annars svart
                KortNummer.Text = tal;
            }
            else {
                KortNummer.ForeColor = System.Drawing.Color.Black;
                KortNummer.Text = tal;
            }




            if (korttyp == "Hjärter")      // Villkorsats, beroende på vilket villkor som stämmer så ska en viss bild visas
            {

                KortBild.Image = Bergsen_BlackJack.Properties.Resources.Hjärter;      
                KortBild.SizeMode = PictureBoxSizeMode.StretchImage;                   // Ser till bilden justeras till rätt storlek
            }

            if(korttyp == "Spader")
            {
                KortBild.Image = Bergsen_BlackJack.Properties.Resources.spader;
                KortBild.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (korttyp == "Klöver")
            {
                KortBild.Image = Bergsen_BlackJack.Properties.Resources.klöver;
                KortBild.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (korttyp == "Ruter")
            {
                KortBild.Image = Bergsen_BlackJack.Properties.Resources.ruter;
                KortBild.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        public  void ApplicationWait()  
        {
            Application.DoEvents();           // Kör UI (user interface) processerna som har lagts på kö, detta för att synka ihop UI containrarna med de "ordinarie" processorer utanför UI. 
                                               // DoEvents() är i grunden opålitlig och i framtiden ska någon form av backgroundWorker implementeras istället.
            Thread.Sleep(1000);                  //Stoppar programmet för 1 sekund, snarare stoppar den aktuella threaden för 1 sekund, detta för att spelaren ska hinna se vilka kort dealern drar

                                                //För denna konstruktion används Thread.Sleep, det är dock i framtiden bättre att skapa en timer av något slag, då thread.sleep är opålitlig
        }



        private void Bet100_Click(object sender, EventArgs e) //BetKnapp
        {
            kontrollSpelarDealer = 1;
            labelHideAndShow(100);
        }

        private void HitKnapp_Click(object sender, EventArgs e) //Hit-Knapp
        {

            displayCounterOchCard();
        }

        private void StandKnapp_Click(object sender, EventArgs e) //Stop-knapp
        {
            kontrollSpelarDealer = 0;
            StandKnapp.Hide();
            HitKnapp.Hide();
           displayCounterOchCard();
        }


        //Overload
        public void labelHideAndShow(int moneyBet)         //Dölj/visa containrar som är av intresse, samt justering av de globala variabler (fieldsen) som lagrar data
        {
            TextIPratbubbla.Hide();
            SpelareSumma.Show();
            Pratbubbla.Hide();
            summaDealer = 0;
            summaSpelare = 0;
            DealerSumma.Hide();
            AntaletPengar = AntaletPengar - moneyBet;
            satsadePengar = moneyBet;
            Pengar.Text = "Kr: " + AntaletPengar.ToString();
            Betta500.Hide();
            Betta250.Hide();
            Betta100.Hide();
            HitKnapp.Show();
            StandKnapp.Show();
            displayCounterOchCard();
        }

        //Overload
        public void labelHideAndShow()       //Dölj/visa containrar som är av intresse
        {
            Pratbubbla.Show();
            TextIPratbubbla.Show();
            TextIPratbubbla.BringToFront();
            Betta500.Show();
            Betta250.Show();
            Betta100.Show();
            HitKnapp.Hide();
            StandKnapp.Hide();
        }

        public void VannSpelare(bool didPlayerWin)         //Dölj/visa text beroende på om boolean didPlayerWin är false eller true
        {
            if (didPlayerWin)
            {
                AntaletPengar = AntaletPengar + (satsadePengar * 2);
                Pengar.Text = "Kr: " + AntaletPengar.ToString();
                TextIPratbubbla.Text = "Du vinner!";
                satsadePengar = 0;
                drawCard.clearCheckList();
                Console.WriteLine("-------------NyttDeck");
                playerWin.Play();
            }

            else
            {
                TextIPratbubbla.Text = "Tyvärr, dealer vinner";
                satsadePengar = 0;
                drawCard.clearCheckList();
                Console.WriteLine("-------------NyttDeck");
            }
        }


    }

}


