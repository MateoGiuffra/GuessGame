using System;
using System.DirectoryServices;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Guesser
{
    public partial class AdivinatorApp : Form
    {
        private Random random;
        private int randomNumber;
        private int attempts;
        private List<string> lowMessages;
        private List<string> highMessages;

        public AdivinatorApp()
        {
            InitializeComponent();
            InitializeMessages();
            StartNewGame();

        }

        private void InitializeMessages()
        {
            highMessages = new List<string>
            {
                "Lower. Try Again",
                "You Crossed. Try With A Lower Number",
                "Too high. Write Another One."
            };
            lowMessages = new List<string>
            {
                "You Almost Get It, Try With A Higher Number.",
                "Too low... You Can!",
                "Very cold. Use Your Instinct!"
            };
        }

        private void StartNewGame()
        {
            attempts = 0;
            random = new Random();
            randomNumber = random.Next(1, 101);
            txtInput.Clear();
            txtInput.Focus();
        }


        private string randomMessages(List<string> messages)
        {
            int index = random.Next(messages.Count);
            return messages[index];
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            newNumberAdded();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                newNumberAdded();
                e.SuppressKeyPress = true;
            }
        }

        private void newNumberAdded()
        {
            if (int.TryParse(txtInput.Text, out int number))
            {

                if (number == randomNumber)
                {
                    numberGuessed();
                }
                else if (number > randomNumber)
                {
                    lblFeedback.Text = randomMessages(highMessages);
                }
                else
                {
                    lblFeedback.Text = randomMessages(lowMessages);
                }
                attempts++;
                lblCounter.ResetText();
                lblCounter.Text = attempts.ToString();
                txtInput.Clear();
                txtInput.Focus();
            }
            else
            {
                MessageBox.Show("Please, write a valid number.");
                txtInput.Clear();
                txtInput.Focus();
            }
        }

        private void numberGuessed()
        {
            MessageBox.Show($"¡Congratulations! The Random Number was {randomNumber}. You're right.");
            var result = MessageBox.Show("¿Do you want to play again?", "New Game", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                StartNewGame();
            }
            else
            {
                System.Windows.Forms.Application.Exit();
            }
        }

    }

}

