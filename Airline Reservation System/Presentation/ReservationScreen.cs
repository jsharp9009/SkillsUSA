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
    public partial class ReservationScreen : Form
    {
        //Container for all first class seats.
        private Seat[] firstClass = new Seat[5];
        //Counter, set to 1, the begining first class seat
        int firstClassCounter = 1;
        //Container for all economy class seats.
        private Seat[] economyClass = new Seat[5];
        //Counter, set to 6, the begining economy seat
        int economyClassCounter = 6;

        #region Events

        /// <summary>
        /// Initializes the Screen
        /// </summary>
        public ReservationScreen()
        {
            InitializeComponent();
            //Initialize the first class array
            BusinessLogic.initializeSeats(firstClass, SeatClass.First);
            //Initialize the economy class array
            BusinessLogic.initializeSeats(economyClass, SeatClass.Economy);
        }

        /// <summary>
        /// Reserve first class seat.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFirstClass_Click(object sender, EventArgs e)
        {
            ReserveSeat(SeatClass.First);
        }

        /// <summary>
        /// Exits the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close(); //End Program
        }

        /// <summary>
        /// Reserves an economy seat.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Economy_Click(object sender, EventArgs e)
        {
            ReserveSeat(SeatClass.Economy);
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Try to reserve a seat of the specified SeatClass
        /// </summary>
        /// <param name="seatClass"></param>
        private void ReserveSeat(SeatClass seatClass)
        {
            //Validate the name to make sure they typed something.
            if (!BusinessLogic.ValidateName(textFirstName.Text, textLastName.Text))
            {
                MessageBox.Show("You must enter a valid First and Last name to reserve a seat.", "Invalid Name",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Invalid name, go no further.
                return;
            }

            //Are we working witn an economy seat?
            if (seatClass == SeatClass.Economy)
            {
                //Check if any seats are open
                if (BusinessLogic.isSeatAvailable(economyClass))
                {
                    //Reserve the seat.
                    Seat seat = BusinessLogic.getNextAvailableSeet(economyClass);
                    seat.FirstName = textFirstName.Text.Trim();
                    seat.LastName = textLastName.Text.Trim();
                    seat.Reserved = true;
                    seat.PassengerSeatClass = SeatClass.Economy;
                    //Set number THEN increment counter
                    seat.SeatNumber = economyClassCounter++;
                    //Show the boarding pass
                    ShowBoardingPass(seat);
                }
                //No economy seats open
                else
                {
                    //Check if first class seats available
                    if (BusinessLogic.isSeatAvailable(firstClass))
                    {
                        //Ask if first class is alright.
                        DialogResult result = MessageBox.Show("Their are no more seats available in Economy Class. Would you like to book a First Class seat?",
                            "Economy Unavailable", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        //Yes, rerun this method with first class
                        if (result == System.Windows.Forms.DialogResult.Yes)
                            ReserveSeat(SeatClass.First);
                        else
                        //Display apology
                            MessageBox.Show("We are sorry we could not book you a seat on this flight. The next flight leaves in 3 hours.",
                                "Next Flight", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //No Open seats on the flight
                    else
                    {
                        MessageBox.Show("We are sorry, their is no more seats available for this flight. The next flight leaves in 3 hours.", 
                            "Full Plane", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            //Are we booking first class?
            else if (seatClass == SeatClass.First)
            {
                //check to see if a seat is available
                if (BusinessLogic.isSeatAvailable(firstClass))
                {
                    //Book seat
                    Seat seat = BusinessLogic.getNextAvailableSeet(firstClass);
                    seat.FirstName = textFirstName.Text.Trim();
                    seat.LastName = textLastName.Text.Trim();
                    seat.Reserved = true;
                    seat.PassengerSeatClass = SeatClass.First;
                    //Assing value THEN increment the counter
                    seat.SeatNumber = firstClassCounter++;
                    //Display the boarding pass.
                    ShowBoardingPass(seat);
                }
                else
                //No first class seats available
                {
                    //Check if economy has open seats.
                    if (BusinessLogic.isSeatAvailable(economyClass))
                    {
                        //Ask if economy is ok
                        DialogResult result = MessageBox.Show("Their are no more seats available in First Class. Would you like to book an Economy Class seat?",
                            "First Class Unavailable", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        //Yes, rerun this method with Economy
                        if (result == System.Windows.Forms.DialogResult.Yes)
                            ReserveSeat(SeatClass.Economy);
                        else
                            //Show apology
                            MessageBox.Show("We are sorry we could not book you a seat on this flight. The next flight leaves in 3 hours.",
                                "Next Flight", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    //Entire flight is full
                    {
                        MessageBox.Show("We are sorry, their is no more seats available for this flight. The next flight leaves in 3 hours.",
                            "Full Plane", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        /// <summary>
        /// Displays the boarding pass in a new screen.
        /// </summary>
        /// <param name="seat"></param>
        private void ShowBoardingPass(Seat seat)
        {
            //Create form in using so it gets properly disposed
            using (PrintBoardingPass form = new PrintBoardingPass())
            {
                //Pass the reserved seat.
                form.PassengerSeat = seat;
                //Show Modal
                form.ShowDialog();
            }
            //Reset the form for the next seat.
            ClearForm();
        }

        /// <summary>
        /// Resets the form.
        /// </summary>
        private void ClearForm()
        {
            //Clear the names.
            textFirstName.Text = "";
            textLastName.Text = "";
            //Set focus back to the top
            textFirstName.Focus();
        }

        #endregion

    }
}
