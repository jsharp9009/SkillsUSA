using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OnlineMovieStore___Contestant_7
{
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
            //Set to false only if we have data to return.
            this.Canceled = true;
        }

        #region Events

        private void btnAddExit_Click(object sender, EventArgs e)
        {
            //Was their data to add?
            if (addMovieToList())
            {
                //Yes, then canceled is false.
                this.Canceled = false;
                //Hide instead of close so we can get the property values.
                this.Hide();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            //Was their data to add?
            if (addMovieToList())
            {
                //Yes, so clear the form and get ready for another entry
                clearForm();
                //Cancel is false since their is data to return.
                this.Canceled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Just hide the so we can get the property values.
            //Cancel is set based on if their is data to return, so no need to set 
            //Canceled here, it'll already be set to the correct value
            this.Hide();
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Adds the currently displaying data as a new Movie.
        /// </summary>
        /// <returns></returns>
        private bool addMovieToList()
        {
            Movie movie = new Movie();
            //temp variable to hold the out of int.TryParse.
            int year = 0;
            //Is the year a valid integer year?
            if (txtYear.Text.Trim().Length == 4 && int.TryParse(txtYear.Text, out year))
                movie.YearReleased = year;
            else
            {
                showError(Properties.Resources.YearError);
                //false to show a field was invalid
                return false;
            }

            //Is the title blank?
            if (!string.IsNullOrWhiteSpace(txtTitle.Text))
                movie.Title = txtTitle.Text;
            else
            {
                showError(Properties.Resources.TitleError);
                //false to show a field was invalid
                return false;
            }

            //Is the Genre blank?
            if (!string.IsNullOrWhiteSpace(txtGenre.Text))
                movie.Genre = txtGenre.Text;
            else
            {
                showError(Properties.Resources.GenreError);
                //false to show a field was invalid
                return false;
            }

            //temp variable to hold the out of decimal.TryParse
            decimal price = 0.00M;
            //Is the purchase price a valid decimal? 
            //Get rid of the dollar sign, just in case the user put it in.
            if (decimal.TryParse(txtPurchasePrice.Text.Replace("$", ""), out price))
                movie.PurchasePrice = price;
            else
            {
                showError(Properties.Resources.PriceError);
                //false to show a field was invalid
                return false;
            }
            
            //Is their a rating selected?
            if (cmbRating.SelectedIndex != -1)
                movie.Rating = (Rating)cmbRating.SelectedIndex;
            else
            {
                showError(Properties.Resources.RatingError);
                //false to show a field was invalid
                return false;
            }

            //Add the completed movie to the list.
            movies.Add(movie);
            //true to show that all fields were valid.
            return true;
        }
        
        /// <summary>
        /// Clears the form back to its original empty state.
        /// </summary>
        private void clearForm()
        {
            txtYear.Text = "";
            txtTitle.Text = "";
            txtPurchasePrice.Text = "";
            txtGenre.Text = "";
            cmbRating.SelectedIndex = -1;
        }

        /// <summary>
        /// Shows a message box with the specified error message.
        /// </summary>
        /// <param name="errorMessage"></param>
        private void showError(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        #region Properties

        private List<Movie> movies = new List<Movie>();
        /// <summary>
        /// Property acsessor for getting the movies that were entered.
        /// </summary>
        public List<Movie> Movies
        {
            get
            {
                return movies;
            }
        }

        /// <summary>
        /// Was the form canceled before any data was entered.
        /// </summary>
        public bool Canceled
        {
            //Property acsessor
            get;
            //Prive set, because nothing outside of this form needs to set this.
            private set;
        }

        #endregion

    }
}
