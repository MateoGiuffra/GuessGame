using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Guesser

{
    partial class AdivinatorApp
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSubmit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblMessage = new Label();
            txtInput = new TextBox();
            btnSubmit = new Button();
            lblFeedback = new Label();
            label1 = new Label();
            lblCounter = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(13, 12);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(193, 15);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Write a nomber between 1 and 100 ";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(16, 32);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(88, 23);
            txtInput.TabIndex = 1;
            txtInput.TextChanged += txtInput_TextChanged;
            txtInput.KeyDown += txtInput_KeyDown;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(109, 32);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(66, 22);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblFeedback
            // 
            lblFeedback.AutoSize = true;
            lblFeedback.Location = new Point(16, 62);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(67, 15);
            lblFeedback.TabIndex = 3;
            lblFeedback.Text = "Good Luck!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(206, 12);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 4;
            label1.Text = "ATTEMPTS";
            // 
            // lblCounter
            // 
            lblCounter.AutoSize = true;
            lblCounter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCounter.Location = new Point(232, 36);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(14, 15);
            lblCounter.TabIndex = 5;
            lblCounter.Text = "0";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AdivinatorApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 85);
            Controls.Add(lblCounter);
            Controls.Add(label1);
            Controls.Add(lblFeedback);
            Controls.Add(btnSubmit);
            Controls.Add(txtInput);
            Controls.Add(lblMessage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdivinatorApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guess the number";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblFeedback;
        private Label label1;
        private Label lblCounter;
        private ErrorProvider errorProvider1;
    }
}
