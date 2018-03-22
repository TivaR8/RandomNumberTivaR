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
            //Random number generate
            Random randomNumberGenerator = new Random();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int usersGuess;

            correctNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

            usersGuess = int.Parse(txtEnterNumber.Text);

            //If then statenment to tell the users if they are correct.
            if (usersGuess == correctNumber)
            {
                lblCorrectGuess.Show();
            }
            else
            {
                lblWrongGuess.Show();
            }
        }
    }
}
