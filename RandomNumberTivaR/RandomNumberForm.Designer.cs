namespace RandomNumberTivaR
{
    partial class frmRandomNumber
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
            this.lblRandomNumberQuestion = new System.Windows.Forms.Label();
            this.lblCorrectGuess = new System.Windows.Forms.Label();
            this.lblWrongGuess = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtEnterNumber = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRandomNumberQuestion
            // 
            this.lblRandomNumberQuestion.AutoSize = true;
            this.lblRandomNumberQuestion.Location = new System.Drawing.Point(12, 39);
            this.lblRandomNumberQuestion.Name = "lblRandomNumberQuestion";
            this.lblRandomNumberQuestion.Size = new System.Drawing.Size(215, 13);
            this.lblRandomNumberQuestion.TabIndex = 0;
            this.lblRandomNumberQuestion.Text = "Can you guess what number I\'m thinking of?";
            // 
            // lblCorrectGuess
            // 
            this.lblCorrectGuess.AutoSize = true;
            this.lblCorrectGuess.Location = new System.Drawing.Point(227, 117);
            this.lblCorrectGuess.Name = "lblCorrectGuess";
            this.lblCorrectGuess.Size = new System.Drawing.Size(44, 13);
            this.lblCorrectGuess.TabIndex = 2;
            this.lblCorrectGuess.Text = "Correct!";
            // 
            // lblWrongGuess
            // 
            this.lblWrongGuess.AutoSize = true;
            this.lblWrongGuess.Location = new System.Drawing.Point(227, 130);
            this.lblWrongGuess.Name = "lblWrongGuess";
            this.lblWrongGuess.Size = new System.Drawing.Size(122, 13);
            this.lblWrongGuess.TabIndex = 3;
            this.lblWrongGuess.Text = "Sorry, that is not correct.";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(249, 72);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtEnterNumber
            // 
            this.txtEnterNumber.Location = new System.Drawing.Point(249, 36);
            this.txtEnterNumber.Name = "txtEnterNumber";
            this.txtEnterNumber.Size = new System.Drawing.Size(100, 20);
            this.txtEnterNumber.TabIndex = 5;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(29, 106);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // frmRandomNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 179);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtEnterNumber);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblWrongGuess);
            this.Controls.Add(this.lblCorrectGuess);
            this.Controls.Add(this.lblRandomNumberQuestion);
            this.Name = "frmRandomNumber";
            this.Text = "Random Number By Tiva Rait";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRandomNumberQuestion;
        private System.Windows.Forms.Label lblCorrectGuess;
        private System.Windows.Forms.Label lblWrongGuess;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtEnterNumber;
        private System.Windows.Forms.Button btnPlay;
    }
}

