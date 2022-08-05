/// Contestant # 510
/// Currency Conversion Program # 1

using System;
using System.Windows.Forms;

namespace CurrencyConversion
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CurrencyConversion());
        }
    }
}