/*
 * Created by: Valeria Veverita
 * Created on: 22-November-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - Address Program
 * This program gets the input from the user (data) and sdisplays it in a message box
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

namespace AdressProgramValeriaV
{
    public partial class frmAdressProgram : Form
    {
        public frmAdressProgram()
        {
            InitializeComponent();
        }

        private void txtAptNum_TextChanged(object sender, EventArgs e)
        {

        }

        /*
         * Procedure: DisplayData
         * Input: String address, String postalCode, String city, String province
         * Output: void
         * This procedure display user's street adress, postal code, city and province in a message box
         */
        private void DisplayData(String address, String postalCode, String city, String province)
        {
            MessageBox.Show("You're living on " + address + ", " + postalCode + ", " + city + ", " + province);
        }

        /*
        * Procedure: DisplayData
        * Input: String address, String postalCode, String city, String province, String aptNum
        * Output: void
        * This procedure display user's apartment number, street adress, postal code, city and province in a message box
        */
        private void DisplayData(String address, String postalCode, String city, String province, String aptNum)
        {
            MessageBox.Show("You're living in unit " + aptNum + " on " + address + ", " + postalCode + ", " + city + ", " + province);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //declare local variables, get the input from the user
            String userAdress = txtAdress.Text;
            String userApt = txtAptNum.Text;
            String userPostalCode = txtPost.Text;
            String userCity= txtCity.Text;
            String userProvince = txtProvince.Text;

            //check if userAdress is empty ask the user to enter the adress
            if (userAdress == "")
            {
                MessageBox.Show("Enter your street address!");
            }
            //check if userPostalCode is empty ask the user to enter the postal code
            else if (userPostalCode == "")
            {
                MessageBox.Show("Enter your postal code!");
            }
            //check if userCity is empty ask the user to enter the city
            else if (userCity == "")
            {
                MessageBox.Show("Enter your city!");
            }
            //check if userProvince is empty ask the user to enter the province
            else if (userProvince == "")
            {
                MessageBox.Show("Enter your province!");
            }
            //check if userApt is empty, call the DisplayData() without the aptNum parameter
            else if (userApt == "")
            {
                DisplayData(userAdress, userPostalCode, userCity, userProvince);
            }
            //call the DisplayData() with the aptNum parameter
            else
            {
                DisplayData(userAdress, userPostalCode, userCity, userProvince, userApt);
            }


        }
    }
}
