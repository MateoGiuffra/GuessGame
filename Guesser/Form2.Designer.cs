namespace Guesser
{
    partial class EndGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndGame));
            this.lblFinalMessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.lblRandomNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFinalMessage
            // 
            resources.ApplyResources(this.lblFinalMessage, "lblFinalMessage");
            this.lblFinalMessage.Name = "lblFinalMessage";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Name = "label2";
            // 
            // lblAttempts
            // 
            resources.ApplyResources(this.lblAttempts, "lblAttempts");
            this.lblAttempts.Name = "lblAttempts";
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.BackColor = System.Drawing.Color.Brown;
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPlayAgain
            // 
            resources.ApplyResources(this.btnPlayAgain, "btnPlayAgain");
            this.btnPlayAgain.BackColor = System.Drawing.Color.Green;
            this.btnPlayAgain.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // lblRandomNumber
            // 
            resources.ApplyResources(this.lblRandomNumber, "lblRandomNumber");
            this.lblRandomNumber.Name = "lblRandomNumber";
            // 
            // EndGame
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAttempts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblFinalMessage);
            this.Controls.Add(this.lblRandomNumber);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EndGame";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblFinalMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label lblRandomNumber;
    }
}
