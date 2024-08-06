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
            SetIconErrorProviderLocation();
            StartNewGame();

        }

        private void SetIconErrorProviderLocation()
        {
            errorProvider1.SetIconAlignment(txtInput, ErrorIconAlignment.MiddleLeft);
        }

        private void InitializeMessages()
        {
            highMessages = new List<string>
            {
                "Try with a lower number. Try Again",
                "You Crossed. Try With A Lower Number",
                "Too high. Write Another One."
            };
            lowMessages = new List<string>
            {
                "You Almost Get It, Try With A Higher Number.",
                "Too low... You Can!",
                "Very low. Use Your Instinct!"
            };
        }

        public void StartNewGame()
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
            newTextAdded();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                newTextAdded();
                e.SuppressKeyPress = true;
            }
        }


        private void newTextAdded()
        {
            if (int.TryParse(txtInput.Text, out int number))
            {
                newNumberAdded(number);
            }
            else
            {
                errorProvider1.SetError(txtInput, "The text must be a number.");
            }
            txtInput.Clear();
            txtInput.Focus();


        }

        private void newNumberAdded(int number)
        {
          
            if (number < 0 || number > 101)
                {
                    errorProvider1.SetError(txtInput, "The number is out of range.");
                    return;

                }
            attempts++;
            if (number == randomNumber)
                {
                    numberGuessed();
                }else if (number > randomNumber)
                {
                    lblFeedback.Text = randomMessages(highMessages);
                }
                else
                {
                    lblFeedback.Text = randomMessages(lowMessages);
                }
            
            errorProvider1.SetError(txtInput, "");
            lblCounter.ResetText();
            lblCounter.Text = attempts.ToString();
            

        }

        private void numberGuessed()
        {
            this.Hide();     
            using (TabEndGame tabEndGame = new TabEndGame(this, this.randomNumber, this.attempts, this.Location))
                tabEndGame.ShowDialog();

        }

        public void newStartPosition(Point lastLocation)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = lastLocation;
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

