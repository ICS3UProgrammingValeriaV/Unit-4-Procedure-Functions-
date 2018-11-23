/*
 * Created by: Valeria Veverita
 * Created on: 23-November-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Percentage Program
 * This program takes the grae from the user adn converts it to perecentage
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

namespace PercentageProgramVV
{
    public partial class frmPercentage : Form
    {
        public frmPercentage()
        {
            InitializeComponent();
        }

        //Function: ConvertToPerecent
        //Input: string level
        //Output: int perecentage
        //This function converts user's grade level to percentage
        private int ConvertToPercent(String level)
        {
            int percentage;
            switch (level)
            {
                case "4++":
                    percentage = 98;
                    break;
                case "4+":
                    percentage = 95;
                    break;
                case "4":
                    percentage = 87;
                    break;
                case "4-":
                    percentage = 83;
                    break;
                case "3+":
                    percentage = 78;
                    break;
                case "3":
                    percentage = 75;
                    break;
                case "3-":
                    percentage = 72;
                    break;
                case "2+":
                    percentage = 68;
                    break;
                case "2":
                    percentage = 98;
                    break;
                case "2-":
                    percentage = 95;
                    break;
                case "1+":
                    percentage = 87;
                    break;
                case "1":
                    percentage = 83;
                    break;
                case "1-":
                    percentage = 78;
                    break;
                case "0":
                    percentage = 75;
                    break;
                case "0-":
                    percentage = 72;
                    break;
                case "0--":
                    percentage = 68;
                    break;
                case "0---":
                    percentage = 75;
                    break;
                case "0----":
                    percentage = 72;
                    break;
                default:
                    percentage = -1;
                    break;
            }
            return percentage;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //get the user level
            String userLevel = txtGrade.Text;
            //call ConvertToPercent() and assign the output to userPercentage variable
            int userPercentage = ConvertToPercent(userLevel);
            //display the answer in a message box
            MessageBox.Show(userLevel + " is " + userPercentage + "%");
        }
    }
}
