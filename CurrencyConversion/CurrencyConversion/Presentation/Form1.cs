/// Contestant # 510
/// Currency Conversion Program # 1

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CurrencyConversion
{
    public partial class CurrencyConversion : Form
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public CurrencyConversion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Occurs when the Convert button is clicked. this calculates the converted currency amount if
        /// all inputs are valid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal usAmount;

                if (!ValidateForm())
                    return;

                // Validate the Currency Amount entered.
                if (BusinessLogic.Validate(CurrencyAmount.Text, out usAmount))
                {
                    // Check to see if they selected the All option. It shold always be last 
                    // on the list.
                    if (CurrencyTypes.SelectedIndex != CurrencyTypes.Items.Count - 1)
                    {
                        decimal convertedAmount = BusinessLogic.Convert(usAmount,
                            (ConversionType)CurrencyTypes.SelectedIndex);

                        // Display the result to the user.
                        ResultLabel.Text = String.Format("Converted Amount in {0} is {1:f}",
                               CurrencyTypes.Items[CurrencyTypes.SelectedIndex], convertedAmount);
                    }
                    else
                    {
                        // The All option was selected, so show all of the conversion types.    
                        StringBuilder toDisplay = new StringBuilder();
                        decimal convertedAmount;

                        for (int i = 0; i < 5; ++i)
                        {
                            convertedAmount = BusinessLogic.Convert(usAmount, (ConversionType)i);
                            //Append the result to the string to be displayed.
                            toDisplay.Append((ConversionType)i + ": " + string.Format
                                ("{0:f}", convertedAmount) + ", ");
                        }

                        //Remove the last two places. THey will just be an extra comma and space.
                        toDisplay.Remove(toDisplay.Length - 2, 2);
                        ResultLabel.Text = toDisplay.ToString();
                    }
                }
                else
                {
                    // Display a message to the user saying their amount is invalid and explain what a 
                    // valid amount should be.
                    MessageBox.Show("Invalid US Dollar amount entered to convert. The amount should" +
                        " Consist of only numbers and a period. The number must contain 2 or no decimal" +
                        " places.", "Invalid Amount"
                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CurrencyAmount.Focus();
                    return;
                }

                //If all checks pass and we don't return by now, set focus to the Clear Button.
                ClearButton.Focus();
            }
            catch(Exception ex)
            {
                //An exception has occured! Log it.
                ErrorHandler.LogException(ex);
            }
        }

        /// <summary>
        /// Occures when the clear button is clicked. This clears the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            CurrencyTypes.SelectedIndex = -1;
            CurrencyAmount.Text = "";
            ResultLabel.Text = "";
            CurrencyAmount.Focus();
        }

        /// <summary>
        /// Occures when the Exit button is clicked. Exits the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Validates that data has been entered on the form.
        /// </summary>
        /// <returns></returns>
        private bool ValidateForm()
        {
            //Is their text in the Currency Amount field?
            if (string.IsNullOrWhiteSpace(CurrencyAmount.Text))
            {
                MessageBox.Show("Please enter an Amount to convert.", "Invalid Amount"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                CurrencyAmount.Focus();
                return false;
            }

            //Did they select a Currency Type to convert to.
            if (CurrencyTypes.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Currency Type to convert to.", "Invalid Type"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                CurrencyTypes.Focus();
                return false;
            }

            //If we havn't returned by now, return true.
            return true;
        }
    }
}
