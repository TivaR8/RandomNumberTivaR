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
            this.SuspendLayout();
            // 
            // lblRandomNumberQuestion
            // 
            this.lblRandomNumberQuestion.AutoSize = true;
            this.lblRandomNumberQuestion.Location = new System.Drawing.Point(29, 23);
            this.lblRandomNumberQuestion.Name = "lblRandomNumberQuestion";
            this.lblRandomNumberQuestion.Size = new System.Drawing.Size(107, 13);
            this.lblRandomNumberQuestion.TabIndex = 0;
            this.lblRandomNumberQuestion.Text = "Press The button To ";
            // 
            // frmRandomNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblRandomNumberQuestion);
            this.Name = "frmRandomNumber";
            this.Text = "Random Number By Tiva Rait";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRandomNumberQuestion;
    }
}

