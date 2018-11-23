/*
 * Created by: Valeria Veverita
 * Created on: 22-November-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Volume of a Cylinder
 * This program gets the height and radius from the user, and calculates the volume by calling the function
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

namespace VolumeProgramVV
{
    public partial class frmVolume : Form
    {
        public frmVolume()
        {
            InitializeComponent();
        }

        //Function: CalculateVolume
        //Input: double radius, double height
        //Output: double volume
        //This function calculates the volume and returns the double volume
        private double CalculateVolume(double radius, double height)
        {
            double volume = Math.PI * Math.Pow(radius,2)*height;
            volume = Math.Round(volume, 2);
            return volume;
        }
        private void btnVolume_Click(object sender, EventArgs e)
        {
            //get the user radius and height
            double userHeight = double.Parse(txtHeight.Text);
            double userRadius = double.Parse(txtRadius.Text);

            //declare local variable
            double userVolume;

            //call the function and pass the arguments
            userVolume = CalculateVolume(userRadius, userHeight);

            //display the volume
            MessageBox.Show("The volume of your cylinder is "+ userVolume + "cm3");
        }
    }
}
