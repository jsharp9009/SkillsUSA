using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Airline_Reservation_System
{
    class BusinessLogic
    {
        //Source for writing to event log
        private const string SOURCE = "Airline Reservation System";
        //The log to write to in the event log
        private const string LOG = "Application";

        /// <summary>
        /// Validates that the first and last name are both filled in.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public static bool ValidateName(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                return false;
            if (string.IsNullOrWhiteSpace(lastName))
                return false;

            //If we haven't returned by now, its valid.
            return true;
        }

        /// <summary>
        /// Checks if a seat is available in the given array.
        /// </summary>
        /// <param name="seats"></param>
        /// <returns></returns>
        public static bool isSeatAvailable(Seat[] seats)
        {
            return seats.Any(s => s.Reserved == false);
        }

        /// <summary>
        /// Retrieves the next available seat for the given array
        /// </summary>
        /// <param name="seats"></param>
        /// <returns></returns>
        public static Seat getNextAvailableSeet(Seat[] seats)
        {
            return seats.First(s => s.Reserved == false);
        }

        /// <summary>
        /// Initializes an array of seats to the specified SeatClass
        /// </summary>
        /// <param name="seats"></param>
        /// <param name="seatClass"></param>
        public static void initializeSeats(Seat[] seats, SeatClass seatClass)
        {
            for (int i = 0; i < seats.Length; i++)
            {
                seats[i] = new Seat(seatClass);
            }
        }

        /// <summary>
        /// Writes an exception to the event log.
        /// </summary>
        /// <param name="ex"></param>
        public static void WriteExceptionToEventLog(Exception ex)
        {
            try
            {
                //Stringbuilder is more efficient.
                StringBuilder sb = new StringBuilder("An error has occured!" + System.Environment.NewLine);
                //Collect data to help debug.
                sb.Append("Message: " + ex.Message + System.Environment.NewLine);
                sb.Append("Stack Trace: " + ex.StackTrace + System.Environment.NewLine);

                //If an inner exceptio exists, collect that data too.
                if (ex.InnerException != null)
                {
                    sb.Append(System.Environment.NewLine + "Inner Exception" + System.Environment.NewLine);
                    sb.Append("Message: " + ex.Message + System.Environment.NewLine);
                    sb.Append("Stack Trace: " + ex.StackTrace + System.Environment.NewLine);
                }

                //Check if event log source exists.
                if (!EventLog.SourceExists(SOURCE))
                    //Create event log source
                    EventLog.CreateEventSource(SOURCE, LOG);

                //Write exception to event log.
                EventLog.WriteEntry(SOURCE, sb.ToString(), EventLogEntryType.Error, 1001);
            }
            catch
            {
                //Data is lost....
            }
        }
    }
}
