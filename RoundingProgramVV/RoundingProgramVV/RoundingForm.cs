/*
 * Created by: Valeria Veverita
 * Created on: 22-November-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #31 - Rounding Program
 * This program takes a number from the user and rounds it to the number of decimals chosen by the user
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoundingProgramVV
{
    public partial class frmRounding : Form
    {
        public frmRounding()
        {
            InitializeComponent();
        }

        private void RoundingForm_Load(object sender, EventArgs e)
        {

        }
        /*
         * Procedure: Rounding
         * Input: ref double number, int decimalNum
         * Output: void
         * This procedure rounds user number to a certain decimkal place
         */
        public void Rounding (ref double number, int decimalNum)
        {
            //calculate the number
            number = number * Math.Pow(10, decimalNum);
            number = number + 0.5;
            number = Math.Truncate(number);
            number = number / Math.Pow(10, decimalNum);

            //display the answer to a messagebox
            MessageBox.Show("The rounded number is " + number);
        }
        private void btnRound_Click(object sender, EventArgs e)
        {
            //get user inputs (number and decimal places)
            double userNumber = Convert.ToDouble(txtDecimal.Text);
            int decimalNumber = Convert.ToInt16(nudDecimal.Value);

            //call the rounding procedure
            Rounding(ref userNumber, decimalNumber);
        }
    }
}
