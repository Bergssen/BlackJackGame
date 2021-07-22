using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bergsen_BlackJack
{
    public partial class Form2 : Form
    {
        private int AntaletPengar = 5000;
        private int summaDealer = 0;
        private int summaSpelare = 0;
        private int satsadePengar = 0;
        private int kontrollSpelarDealer = 1;
        Programmability drawCard;
        SoundPlayer player;
        SoundPlayer playerWin; //Test 
        public Form2()
        {
            InitializeComponent();
            MaximizeBox = false;           //Tillåt inte omskalning av applikationen ddd
            MinimizeBox = false;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label2.Hide();
            label6.BackColor = Color.White;
            label6.Hide();
            label5.BackColor = Color.White;
            label5.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();

            label3.Hide();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            label1.Text = "Kr: " + AntaletPengar.ToString();  //Konvertera antalet pengar till string för att visas i Label1
            button4.Hide();
            button5.Hide();
            this.drawCard = new Programmability();
            player = new SoundPlayer("C:/Users/Nathalie/Desktop/DrawCard.Wav");
            playerWin = new SoundPlayer("C:/Users/Nathalie/Desktop/WinSound.Wav");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            kontrollSpelarDealer = 1;
            labelHideAndShow(500);
        }


        private void displayCounterAndCard()
        {
            while (true) { 

           string value = drawCard.genereraKort();
                Console.WriteLine(value);
           string cardType = "";
           string cardValueString = "";

            for (int i = 0; i < value.Length; i++)
            {
                if (!Char.IsDigit(value[i]))
                    cardType = cardType + value[i];
            }

            for (int i = 0; i < value.Length; i++)
            {
                if (Char.IsDigit(value[i]))
                    cardValueString = cardValueString + value[i];
            }

            int cardValueInt = Int32.Parse(cardValueString);
                player.Play();
                visaKortOchNummer(cardType, cardValueInt);

                if (cardValueInt == 11 | cardValueInt == 12 | cardValueInt == 13)
            {
                cardValueInt = 10;
            }
            else if ((kontrollSpelarDealer == 1 & cardValueInt == 1 & (summaSpelare + 11) < 22) | (kontrollSpelarDealer == 0 & cardValueInt == 1 & (summaDealer + 11) < 22))
            {
                cardValueInt = 11;
            }

              if (kontrollSpelarDealer == 1)
                        {
                            
                             summaSpelare = summaSpelare + cardValueInt;
                              label2.Text = summaSpelare.ToString();
                            
                        if(summaSpelare > 21)
                            {
                        labelHideAndShow();
                        didPlayerWin(false);
                        summaSpelare = 0;
                        break;
                                  }
                    else
                    {
                        break;
                    }



                        }


              if(kontrollSpelarDealer == 0)
                {
                    label3.Show();
                    summaDealer = summaDealer + cardValueInt;
                    label3.Text = summaDealer.ToString();
                    wait(1000);

                    if (summaDealer > 21)
                    {
                        labelHideAndShow();
                        didPlayerWin(true);
                        summaDealer = 0;
                        break;
                    }

                    else if ((summaDealer == summaSpelare & summaDealer < 21) | (summaDealer > summaSpelare & summaDealer < 22))
                    {
                        labelHideAndShow();
                        didPlayerWin(false);
                        summaDealer = 0;
                        break;
                    }
                }

            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            kontrollSpelarDealer = 1;
            labelHideAndShow(250);

        }

        private void visaKortOchNummer(string korttyp, int varde)
        {
            //Console.WriteLine(varde);
            string tal;

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
                tal = varde.ToString();
            }



            label5.Show();
            pictureBox1.Show();

            if(korttyp == "Hjärter" | korttyp == "Ruter")
            {
                label5.ForeColor = System.Drawing.Color.Red;
                label5.Text = tal;
            }
            else {
                label5.ForeColor = System.Drawing.Color.Black;
                label5.Text = tal;
            }




            if (korttyp == "Hjärter")
            {

                pictureBox1.Image = Bergsen_BlackJack.Properties.Resources.Hjärter;      //Image.FromFile(@"C:\Users\Nathalie\Desktop\Hjärter.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if(korttyp == "Spader")
            {
                pictureBox1.Image = Bergsen_BlackJack.Properties.Resources.spader;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (korttyp == "Klöver")
            {
                pictureBox1.Image = Bergsen_BlackJack.Properties.Resources.klöver;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (korttyp == "Ruter")
            {
                pictureBox1.Image = Bergsen_BlackJack.Properties.Resources.ruter;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }


        public void wait(int milliseconds) // Tagen från StackoverFlow, ändra framöver.
        {
            var timer = new System.Windows.Forms.Timer();
            if (milliseconds == 0 | milliseconds < 0) return;
            timer.Interval = milliseconds;
            timer.Enabled = true;
            timer.Start();

            timer.Tick += (s, e) =>
            {
                timer.Enabled = false;
                timer.Stop();
            };

            while (timer.Enabled)
            {
                Application.DoEvents();
            }
    }


        private void button3_Click(object sender, EventArgs e)
        {
            kontrollSpelarDealer = 1;
            labelHideAndShow(100);
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // genereraKort();
            displayCounterAndCard();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kontrollSpelarDealer = 0;
        //    genereraKortDealer();
            button5.Hide();
            button4.Hide();
           displayCounterAndCard();
        }


        public void labelHideAndShow(int moneyBet)
        {
           // UsedCards.Clear();
            label6.Hide();
            label2.Show();
            pictureBox2.Hide();
            summaDealer = 0;
            summaSpelare = 0;
            label3.Hide();
            AntaletPengar = AntaletPengar - moneyBet;
            satsadePengar = moneyBet;
            label1.Text = "Kr: " + AntaletPengar.ToString();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Show();
            button5.Show();
            //genereraKort();
            displayCounterAndCard();
        }

        public void labelHideAndShow()
        {
            pictureBox2.Show();
            label6.Show();
            label6.BringToFront();
            button1.Show();
            button2.Show();
            button3.Show();
            button4.Hide();
            button5.Hide();
            //label5.Hide();
            //pictureBox1.Hide();
        }

        public void didPlayerWin(bool didPlayerWin)
        {
            if (didPlayerWin)
            {
                AntaletPengar = AntaletPengar + (satsadePengar * 2);
                label1.Text = "Kr: " + AntaletPengar.ToString();
                label6.Text = "Du vinner!";
                satsadePengar = 0;
                drawCard.clearCheckList();
                Console.WriteLine("-------------NyttDeck");
                playerWin.Play();
            }

            else
            {
                label6.Text = "Tyvärr, dealer vinner";
                satsadePengar = 0;
                drawCard.clearCheckList();
                Console.WriteLine("-------------NyttDeck");
            }
        }


    }

}


