/*
 * Created by: Valeria Veverita
 * Created on: 14-November-2018
 * Created for: ICS3U Programming
 * Daily Assignment - Day #28 - TempConverter
 * This program calls a procedure that I created, which converts the degrees Celsius to Fahrenheit
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

namespace ConvertTempValeriaV
{
    public partial class frmConvertTemp : Form
    {
        public frmConvertTemp()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //convert the value from the text-box to an integer
            int userTemp = Convert.ToInt16(txtTemperature.Text);

            //call the ConvertToFaren procedure
            ConvertToFaren(userTemp);
        }

        /*
         * Procedure: ConvertToFaren
         * Input: int tempCelsius
         * Output: void
         * This procedure converts the Celsius temperature to Fahrenheit temperature; displays it in a message box
         */
        public void ConvertToFaren (int tempCelsius)
        {
            //convert the Celsius temperature to Fahrenheit temperature
            double tempFahrenheit = (tempCelsius * 9 / 5) + 32;

            //display the Fahrenheit temperature in a message box
            MessageBox.Show(tempCelsius + " °C is " + tempFahrenheit + " °F", "Fehrenheit Temperature");
        }
    }
}
