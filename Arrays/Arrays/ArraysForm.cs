/*
 * Created by: Valeria Veverita
 * Created on: 29-November-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #36 - Introduction to Arrays
 * This program generates random numbers and calculate their average
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

namespace Arrays
{
    public partial class frmArrays : Form
    {
        //declare global variales and constants
        const int MAX_SIZE = 10;
        int[] arrayOfMarks = new int[MAX_SIZE];

        public frmArrays()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declare local variables
            Random randomNumberGenerator = new Random();
            int generatedNumber = 0;
            //clear the list box
            lstMarks.Items.Clear();
            lblAverage2.Text = "";

            //while counter is less than 9
            for (int counter = 0; counter < 9; counter ++)
            {
                //generate a random number, add it to the array, add it to the list box, refresh the form
                generatedNumber = randomNumberGenerator.Next(1, MAX_SIZE + 1);
                arrayOfMarks[counter] = generatedNumber;
                lstMarks.Items.Add(generatedNumber);
                this.Refresh();
                
            }
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            //declare local variables
            double average = 0;
            double sum = 0;

            //while counter is less than 10
            for (int counter = 0; counter < arrayOfMarks.Length; counter++)
            {
                //calculate the sum of the marks
                sum += arrayOfMarks[counter];
            }

            //calculate the average and display it
            average = sum / arrayOfMarks.Length;
            lblAverage2.Text = Convert.ToString(average);

        }

        private void frmArrays_Load(object sender, EventArgs e)
        {

        }
    }
}
