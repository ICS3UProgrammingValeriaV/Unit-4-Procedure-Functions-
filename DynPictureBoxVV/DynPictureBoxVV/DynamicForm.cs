/*
 * Created by: Valeria Veverita
 * Created on: 23-November-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - Dynamic Picture Box
 * This program creates a Picture Box dynamically and then responds to a mouse click
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
using System.Threading;

namespace DynPictureBoxVV
{
    public partial class frmDynamic : Form
    {
        public frmDynamic()
        {
            InitializeComponent();

            //hide the instructions
            lblInstructions.Hide();
        }
        //Procedure: GeneratePicBoxes
        //Input: void
        //Output: void
        //This procedure generates pictures boxes and sets their position
        private void GeneratePicBoxes()
        {
            //call the GeneratePicBox() to generate each picture on the form
            GeneratePicBox(61, 78);
            GeneratePicBox(464, 78);
            GeneratePicBox(61, 358);
            GeneratePicBox(464, 358);

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            //display the instruction
            lblInstructions.Show();

            //display the picture boxes
            GeneratePicBoxes();

        }

        private void GeneratePicBox(int x, int y)
        {
            //declare local variables for the picture box(es) and the position
            PictureBox picMan = new PictureBox();
            Point picIndex = new System.Drawing.Point(x, y);

            //set the location of the picture
            picMan.Location = picIndex;

            //assign the image to the picture box
            picMan.Image = Properties.Resources.walk1;

            //stretch the image to the size of the picture box
            picMan.SizeMode = PictureBoxSizeMode.StretchImage;

            //change the height and width of the picture box = height and width of the image
            picMan.ClientSize = new Size(Properties.Resources.walk1.Width, Properties.Resources.walk1.Height);

            //add the event listener
            picMan.Click += new System.EventHandler(PictureBox_Click);

            //add the picture to the form
            this.Controls.Add(picMan);

        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            //cast the sender object into a picture box
            PictureBox picMan = (PictureBox)sender;

            //write to the console what picture box was clicked
            Console.WriteLine("Picture Box ( " + picMan.Location.X + picMan.Location.Y + " ) was clicked");

            //declare local variables and constants
            const byte MAX_FRAMES = 10;
            int counter = 1;

            //continue the loop until the counter reaches the maximum amount of frames
            while (counter <= MAX_FRAMES)
            {
                if (counter == 1 )
                {
                    picMan.Image = Properties.Resources.walk1;
                }
                else if (counter == 2)
                {
                    picMan.Image = Properties.Resources.walk2;
                }
                else if (counter == 3)
                {
                    picMan.Image = Properties.Resources.walk3;
                }
                else if (counter == 4)
                {
                    picMan.Image = Properties.Resources.walk4;
                }
                else if (counter == 5)
                {
                    picMan.Image = Properties.Resources.walk5;
                }
                else if (counter == 6)
                {
                    picMan.Image = Properties.Resources.walk6;
                }
                else if (counter == 7)
                {
                    picMan.Image = Properties.Resources.walk7;
                }
                else if (counter == 8)
                {
                    picMan.Image = Properties.Resources.walk8;
                }
                else if (counter == 9)
                {
                    picMan.Image = Properties.Resources.walk9;
                }
                else if (counter == 10)
                {
                    picMan.Image = Properties.Resources.walk10;
                }

                //increase the counter
                counter++;

                //wait for 2 sec & refresh the screen
                this.Refresh();
                Thread.Sleep(100);
            }


        }
    }
}
