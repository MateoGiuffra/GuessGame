namespace Guesser
{
    partial class TabEndGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFinalMessage = new Label();
            btnPlayAgain = new Button();
            btnExit = new Button();
            lblRandomNumber = new Label();
            lblAttempts = new Label();
            lblAttemptsName = new Label();
            SuspendLayout();
            // 
            // lblFinalMessage
            // 
            lblFinalMessage.AutoSize = true;
            lblFinalMessage.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFinalMessage.Location = new Point(15, 7);
            lblFinalMessage.Name = "lblFinalMessage";
            lblFinalMessage.Size = new Size(251, 17);
            lblFinalMessage.TabIndex = 0;
            lblFinalMessage.Text = "Congratulation! The random number was:";
            // 
            // btnPlayAgain
            // 
            btnPlayAgain.BackColor = Color.Green;
            btnPlayAgain.ForeColor = SystemColors.Control;
            btnPlayAgain.Location = new Point(13, 52);
            btnPlayAgain.Name = "btnPlayAgain";
            btnPlayAgain.Size = new Size(75, 23);
            btnPlayAgain.TabIndex = 1;
            btnPlayAgain.Text = "Play Again";
            btnPlayAgain.UseVisualStyleBackColor = false;
            btnPlayAgain.Click += btnPlayAgain_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Brown;
            btnExit.ForeColor = SystemColors.Control;
            btnExit.Location = new Point(198, 52);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblRandomNumber
            // 
            lblRandomNumber.AutoSize = true;
            lblRandomNumber.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRandomNumber.Location = new Point(124, 21);
            lblRandomNumber.Name = "lblRandomNumber";
            lblRandomNumber.Size = new Size(25, 30);
            lblRandomNumber.TabIndex = 3;
            lblRandomNumber.Text = "0";
            // 
            // lblAttempts
            // 
            lblAttempts.AutoSize = true;
            lblAttempts.Location = new Point(167, 56);
            lblAttempts.Name = "lblAttempts";
            lblAttempts.Size = new Size(13, 15);
            lblAttempts.TabIndex = 4;
            lblAttempts.Text = "1";
            // 
            // lblAttemptsName
            // 
            lblAttemptsName.AutoSize = true;
            lblAttemptsName.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAttemptsName.ForeColor = Color.IndianRed;
            lblAttemptsName.Location = new Point(94, 56);
            lblAttemptsName.Name = "lblAttemptsName";
            lblAttemptsName.Size = new Size(71, 15);
            lblAttemptsName.TabIndex = 5;
            lblAttemptsName.Text = "ATTEMPTS";
            // 
            // TabEndGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 85);
            Controls.Add(lblAttemptsName);
            Controls.Add(lblAttempts);
            Controls.Add(lblRandomNumber);
            Controls.Add(btnExit);
            Controls.Add(btnPlayAgain);
            Controls.Add(lblFinalMessage);
            Name = "TabEndGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guess the number";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFinalMessage;
        private Button btnPlayAgain;
        private Button btnExit;
        private Label lblRandomNumber;
        private Label lblAttempts;
        private Label lblAttemptsName;
    }
}