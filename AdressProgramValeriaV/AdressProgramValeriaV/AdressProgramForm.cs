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

        private void DisplayData(String address, String postalCode, String city, String province)
        {
            MessageBox.Show("You're living on " + address + ", " + postalCode + ", " + city + ", " + province);
        }

        private void DisplayData(String address, String postalCode, String city, String province, String aptNum)
        {
            MessageBox.Show("You're living in unit " + aptNum + " on " + address + ", " + postalCode + ", " + city + ", " + province);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            String userAdress = txtAdress.Text;
            String userApt = txtAptNum.Text;
            String userPostalCode = txtPost.Text;
            String userCity= txtCity.Text;
            String userProvince = txtProvince.Text;

            if (userAdress == "")
            {
                MessageBox.Show("Enter your street address!");
            }
           else  if (userPostalCode == "")
           {
                MessageBox.Show("Enter your postal code!");
           }
           else if (userCity == "")
           {
                MessageBox.Show("Enter your city!");
           }
            else if (userProvince == "")
            {
                MessageBox.Show("Enter your province!");
            }
            else if (userApt == "")
            {
                DisplayData(userAdress, userPostalCode, userCity, userProvince);
            }
            else
            {
                DisplayData(userAdress, userPostalCode, userCity, userProvince, userApt);
            }


        }
    }
}
