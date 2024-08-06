using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guesser
{
    public partial class TabEndGame : Form
    {

        private AdivinatorApp lastTab;
        private int randomNumber;
        private int attempts;

        public TabEndGame(AdivinatorApp form, int randomNumber, int attempts, Point lastLocation)
        {
            InitializeComponent();
            lastTab = form;
            this.randomNumber = randomNumber;
            this.attempts = attempts;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = lastLocation;
            this.DisplayEndMessage();
        }

        private void DisplayEndMessage()
        {
            lblFinalMessage.Text = $"Congratulations! The random number was:";
            lblRandomNumber.Text = $"{randomNumber}";
            lblAttempts.Text = $"{this.attempts}";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            lastTab.newStartPosition(this.Location);
            lastTab.StartNewGame();
            lastTab.Show();
            this.Close();
        }

      
    }
}


