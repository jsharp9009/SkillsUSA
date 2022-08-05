/// Contestant # 510
/// Currency Conversion Program # 1

using System;
using System.Diagnostics;
using System.Text;

namespace CurrencyConversion
{
    internal class ErrorHandler
    {
        /// <summary>
        /// Event Log source
        /// </summary>
        private const string SOURCE = "CurrencyConversion";

        /// <summary>
        /// Event Log log to write to.
        /// </summary>
        private const string LOG = "Application";

        /// <summary>
        /// Writes an exception to the event log and display a message to the user.
        /// </summary>
        /// <param name="ex"></param>
        public static void LogException(Exception ex)
        {
            try
            {
                StringBuilder sb = new StringBuilder("Error Occured with Currency Conversion\n");
                //Get the information for the exception.
                sb.Append("Message: " + ex.Message + System.Environment.NewLine);
                sb.Append("Sourece: " + ex.Source + System.Environment.NewLine);
                sb.Append("Stack Trace: " + ex.Source + System.Environment.NewLine);

                //Check to see if their is an inner exception.
                if (ex.InnerException != null)
                {
                    //Get the information for the inner exception.
                    sb.Append("\nInner Exception\n");
                    sb.Append("Message: " + ex.InnerException.Message + System.Environment.NewLine);
                    sb.Append("Sourece: " + ex.InnerException.Source + System.Environment.NewLine);
                    sb.Append("Stack Trace: " + ex.InnerException.Source + System.Environment.NewLine);
                }

                //Check to see if our source exists. If it does not, create it.
                if (!EventLog.SourceExists(SOURCE))
                    EventLog.CreateEventSource(SOURCE, LOG);

                //Write the exception information to the event log so we can look at it later.
                EventLog.WriteEntry(SOURCE, sb.ToString());
            }
            catch
            {
                // Supress the error so the user does not see. A message will be shown to them.
                // The data is lost becasue we could not write to the event log.
            }
            finally
            {
                //Display a message to the user so they know something has gone wrong.
                System.Windows.Forms.MessageBox.Show("We are sorry. An error has occured. Please close" +
                   " the application and try again. If this issues persists, please contact support.",
                   "Exception", System.Windows.Forms.MessageBoxButtons.OK,
                   System.Windows.Forms.MessageBoxIcon.Exclamation);
            }
        }
    }
}