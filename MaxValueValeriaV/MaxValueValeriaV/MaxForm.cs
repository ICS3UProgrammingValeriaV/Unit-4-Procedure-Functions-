/*
 * Created by: Valeria Veverita
 * Created on: 30-November-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - Find Max Value
 * This program an array of size 10 (MAX_ARRAY_SIZE), when the user clicks on the "Start" button it generates 10 random numbers, each between 1 and 500 (MAX_RANDOM_NUMBER)
   For each random number generated it displays it in a list box and  assigns it to the subsequent cell  in the array
   It then calls a function that:
                                    accepts the array passed by value
                                    scans the array to find the largest value 
                                    returns the largest value as a single variable
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

namespace MaxValueValeriaV
{
    public partial class frmMaxVal : Form
    {
        public frmMaxVal()
        {
            InitializeComponent();

        }

       
        private void btnStart_Click(object sender, EventArgs e)
        {
            //declare local varaibles
            Random randomNumber = new Random();
            int chosenValue;
            int maxValue;

            //create an array of size 10
            int[] arrayOfValues = new int[10];

            //clear the list box
            lstValues.Items.Clear();

            //initialize the counter to 0, check if the counter is less than 10
            for (int counter = 0; counter < 10; counter ++)
            {
                //generate a random number
                chosenValue = randomNumber.Next(1, 501);
                //assign it to the subsequent cell
                arrayOfValues[counter] = chosenValue;
                //add the item to the list box
                lstValues.Items.Add(chosenValue);
            }

            //call the function Findmax, send the array as an argumnet, assign the return to the maxValue
            maxValue =  FindMax(arrayOfValues);
            //display ina message box the max value
            MessageBox.Show("The maximum value is " + maxValue);


        }
        //Function: FindMax
        //Input: int[]tmpArray
        //Output: int tmpmaxValue
        //Description:  this function scans the array to find the largest value  and returns the largest value as a single variable

        private int FindMax(int[] tmpArray)
        {
            int tmpMaxValue = 0;
            tmpMaxValue = tmpArray.Max();
            return tmpMaxValue;
        }
    }
}
