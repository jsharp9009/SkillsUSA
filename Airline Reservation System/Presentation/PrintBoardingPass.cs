using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Airline_Reservation_System
{
    public partial class PrintBoardingPass : Form
    {
        //Holder for if the ok button was clicked on the save dialog form
        public bool OkClicked = false;

        //Seat to display the boarding pass for.
        public Seat PassengerSeat{ get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PrintBoardingPass()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Display the seat passed to me as a boarding pass.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintBoardingPass_Load(object sender, EventArgs e)
        {
            //Initialize string builder with name line.
            StringBuilder sb = new StringBuilder("Name: " + PassengerSeat.FirstName.Replace(' ', '_') + " " 
                + PassengerSeat.LastName.Replace(' ', '_') + System.Environment.NewLine + System.Environment.NewLine);
            //Add seat number
            sb.Append("Seat Number: " + PassengerSeat.SeatNumber + System.Environment.NewLine 
                + System.Environment.NewLine);
            //Add what Seat Class
            sb.Append(PassengerSeat.PassengerSeatClass == SeatClass.Economy ? "Economy Class" : "First Class");
            //Display
            labelPass.Text = sb.ToString();
        }

        /// <summary>
        /// Prints the boarding pass to a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            //Should I close the screen
            bool close = false;

            try
            {
                //Using to make sure it gets disposed.
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    //Make sure the path exists
                    dialog.CheckPathExists = true;
                    //Prompt of they attempt to overrite a file.
                    dialog.OverwritePrompt = true;
                    //Set filter to text file. Thats all we support
                    dialog.Filter = ".txt|*.txt";
                    //Set default file name. They can change if they want.
                    dialog.FileName = PassengerSeat.FirstName + "_"
                        + PassengerSeat.LastName + "_" + "Boarding_Pass";
                    //Attach to FileOK method so we can flip the OKClicked flag when they click save.
                    dialog.FileOk += dialog_FileOk;
                    //Show the modal dialog
                    dialog.ShowDialog();
                    //If they didn't cancel
                    if (OkClicked)
                    {
                        //Write out the file
                        System.IO.File.WriteAllText(dialog.FileName, labelPass.Text);
                        //signal that form is ready to close.
                        close = true;
                    }
                }
                //If the form is ready to close
                if (close)
                    this.Close();
            }
            catch (Exception ex)
            {
                //OH NO! Tell the user
                MessageBox.Show("An Error has occured. Please contact your administrator." + System.Environment.NewLine 
                    + "Message: " + ex.Message);
                //And collect information for debugging.
                BusinessLogic.WriteExceptionToEventLog(ex);
            }
        }

        /// <summary>
        /// Fliips the OkClicked Flag so we know they didn't cancel out of the save dialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void dialog_FileOk(object sender, CancelEventArgs e)
        {
            OkClicked = true;
        }
    }
}
