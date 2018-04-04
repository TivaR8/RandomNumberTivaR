using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Created by: Tiva Rait
 * Created on: 22-03-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #16 - Random Number
 * This program generates a random number then asks the user...
 * ...to guess the number
*/
namespace RandomNumberTivaR
{
    public partial class frmRandomNumber : Form
    {
        //Defines constants and variables
        int correctNumber;
        Random randomNumberGenerator = new Random();
        const int MIN_NUM = 1;
        const int MAX_NUM = 10;


        public frmRandomNumber()
        {
            InitializeComponent();
            // Hides the meassages
            lblWrongGuess.Hide();
            lblCorrectGuess.Hide();
            // Random number generate
            Random randomNumberGenerator = new Random();

            // To disable everything until the play button is clicked
            txtEnterNumber.Enabled = false;
            btnCheck.Enabled = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int usersGuess;

            usersGuess = int.Parse(txtEnterNumber.Text);

            // If then statenment to tell the users if they are correct.
            if (usersGuess == correctNumber)
            {
                lblCorrectGuess.Show();
                lblWrongGuess.Hide();
                btnPlay.Enabled = true;
                btnCheck.Enabled = false;
            }
            else
            {
                lblWrongGuess.Show();
                lblCorrectGuess.Hide();
                btnPlay.Enabled = false;
                btnCheck.Enabled = true;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // To enable everything now that the play button has been clicked
            txtEnterNumber.Enabled = true;
            btnCheck.Enabled = true;

            // To Disable the play button
            btnPlay.Enabled = false;

            // To clear the text Box 
            txtEnterNumber.Text = (" ");

            // Now to generate the new random number
            correctNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
        }
    }
}
