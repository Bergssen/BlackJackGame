using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bergsen_BlackJack
{
    public partial class StartSida : Form
    {
        public StartSida()
        {
            InitializeComponent();
            this.BackColor = Color.Black; // Sätt bakgrundsfärg till svart på denna instansen, därav this. //Test
            MaximizeBox = false;           //Tillåt inte omskalning av applikationen
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle; //Tillåt inte omskalning av applikationen
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartHärKnapp_Click(object sender, EventArgs e)    // När man klickar på picturebox
        {
            var sida2 = new SpelRum();
            this.Hide();
            sida2.Show();

            

        }

        private void StartHärKnapp_MouseEnter(object sender, EventArgs e) //Hovrar över, gör bilden större, samt lokalisering
        {
            Size size = new Size(520, 130);
            StartHärKnapp.Size = size;
            StartHärKnapp.Location = new Point(340, 360);

        }

        private void StartHärKnapp_MouseLeave(object sender, EventArgs e) //När man ej längre hovrar över, gör bilden mindre, samt rätt lokalisering
        {
            Size size = new Size(487, 103);
            StartHärKnapp.Size = size;
            StartHärKnapp.Location = new Point(314, 337);

        }

        private void StartaKnapp_Click(object sender, EventArgs e)
        {

        }
    }

}   
