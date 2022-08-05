using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Airline_Reservation_System
{
    public class Seat
    {
        //Holder for the first name
        public string FirstName { get; set; }
        //Holder for the last Name
        public string LastName { get; set; }
        //What type of seat this is
        public SeatClass PassengerSeatClass { get; set; }
        // The seat number
        public int SeatNumber { get; set; }
        // Has the seat been reserved
        public bool Reserved { get; set; }

        /// <summary>
        /// Creates new seat of the specified SeatClass
        /// </summary>
        /// <param name="seatClass"></param>
        public Seat(SeatClass seatClass)
        {
            this.PassengerSeatClass = seatClass;
        }
    }

    /// <summary>
    /// Types of Seat Classes available on this plane.
    /// </summary>
    public enum SeatClass
    {
        First,
        Economy
    }
}
