using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OnlineMovieStore___Contestant_7
{
    public partial class Form1 : Form
    {
        List<Movie> movies = new List<Movie>();
        private const string Source = "OnlineMovieStore";
        #region Ratings Dictionary

        //Dictionaries are faster than Switch statments. 
        //inside a region just to help hide it.
        Dictionary<string, Rating> stringToRating = new Dictionary<string, Rating>
        {
            {"g", Rating.G},
            {"pg", Rating.PG},
            {"pg13", Rating.PG13},
            {"r", Rating.R},
        };

        #endregion

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Form1()
        {
            try
            {
                InitializeComponent();
                //Load the movies
                loadMovies();
                
                //Set default sort
                ckbRatingSort.Checked = true;
                ckbYearSort.Checked = true;

                cmbRatingSort.SelectedIndex = 1;
                cmbYearSort.SelectedIndex = 0;

                //Display them to the user
                displayMovies(movies);
            }
            catch(Exception ex)
            {
                showError(Properties.Resources.ErrorOccur + ex.Message);
                logException(ex);
            }
        }

        #region Events

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            AddMovie frmAdd = new AddMovie();
            try
            {
                //Show model to stop the execution of this code.
                frmAdd.ShowDialog();
                //Check to see if the form was canceled.
                if (!frmAdd.Canceled)
                {
                    //An extra check. If their are no movies, Canceled should be true.
                    if (frmAdd.Movies.Count > 0)
                    {
                        //Add all the movies to our movie collection.
                        movies.AddRange(frmAdd.Movies);
                    }
                }
                //Close the form we left open.
                frmAdd.Close();
                //Display the list with the new entries to the user.
                displayMovies(movies);
            }
            catch (Exception ex)
            {
                showError(Properties.Resources.ErrorOccur + ex.Message);
                logException(ex);
            }
            finally
            {
                //Make sure the form gets properly disposed. No Memory Leaks.
                if (frmAdd != null)
                    frmAdd.Dispose();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //Working collection so we don't mess up our entire collection
                List<Movie> searchResult = movies;

                //Is the Title Search field filled in?
                if (!string.IsNullOrWhiteSpace(txtTitleSearch.Text))
                {
                    //use LINQ to search all the movies.
                    var titleSearch =
                        from movie in searchResult
                        where movie.Title.ToLower().Contains(txtTitleSearch.Text.ToLower().Trim())
                        select movie;

                    //set our results to what we found.
                    searchResult = titleSearch.ToList<Movie>();
                }

                //Is the year field filed in and did they select how they want to search?
                if (!string.IsNullOrWhiteSpace(txtYearSearch.Text) && cmbYearSearch.SelectedIndex != -1)
                {
                    int year = 1900;
                    if (!int.TryParse(txtYearSearch.Text, out year) || txtYearSearch.Text.Trim().Length != 4)
                    {
                        showError(Properties.Resources.YearError);
                    }
                    else
                    {

                        switch (cmbYearSearch.SelectedIndex)
                        {
                            //Search before year entered.
                            case 0:
                                var yearSearchBefore =
                                    from movie in searchResult
                                    where movie.YearReleased < int.Parse(txtYearSearch.Text)
                                    select movie;

                                searchResult = yearSearchBefore.ToList<Movie>();
                                break;
                            //Search before and on year entered.
                            case 1:
                                var yearSearchBeforeOn =
                                    from movie in searchResult
                                    where movie.YearReleased <= int.Parse(txtYearSearch.Text)
                                    select movie;

                                searchResult = yearSearchBeforeOn.ToList<Movie>();
                                break;
                            //Search After on On Year entered.
                            case 2:
                                var yearSearchAfterOn =
                                    from movie in searchResult
                                    where movie.YearReleased >= int.Parse(txtYearSearch.Text)
                                    select movie;

                                searchResult = yearSearchAfterOn.ToList<Movie>();
                                break;
                            //Search After year entered.
                            case 3:
                                var yearSearchAfter =
                                    from movie in searchResult
                                    where movie.YearReleased > int.Parse(txtYearSearch.Text)
                                    select movie;

                                searchResult = yearSearchAfter.ToList<Movie>();
                                break;

                        }
                    }
                }

                displayMovies(searchResult);
            }
            catch(Exception ex)
            {
                showError(Properties.Resources.ErrorOccur + ex.Message);
                logException(ex);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                //Get the current displaying movies
                List<Movie> sort = getCurrentDisplaying();
                //display them with the new sort settings the user has set.
                displayMovies(sort);
            }
            catch (Exception ex)
            {
                showError(Properties.Resources.ErrorOccur + ex.Message);
                logException(ex);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                //Display all movies from our master list.
                displayMovies(movies);

                //Were showing all, so clear the search
                txtTitleSearch.Text = "";
                txtYearSearch.Text = "";
                cmbYearSearch.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                showError(Properties.Resources.ErrorOccur + ex.Message);
                logException(ex);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Loads 5 default movies.
        /// </summary>
        private void loadMovies()
        {
            //Create new and add to list
            movies.Add(new Movie(2004, "Team America World Police", "Comedy", Rating.R, 9.99M));
            movies.Add(new Movie(2012, "The Bourne Legacy", "Action & Adventure", Rating.PG13, 14.99M));
            movies.Add(new Movie(1994, "Ace Ventura: Pet Detective", "Comedy", Rating.PG13, 8.99M));
            movies.Add(new Movie(2006, "Idiocracy", "Comedy", Rating.R, 11.99M));
            movies.Add(new Movie(1997, "The Saint", "Action", Rating.PG13, 6.47M));
        }

        /// <summary>
        /// Displays the moives in the list in the GridView
        /// </summary>
        /// <param name="toDisplay"></param>
        private void displayMovies(List<Movie> toDisplay)
        {
            //Get the DataTable
            DataTable table = createDataTable();

            //Sort the movies based on what the user has entered.
            sortMovies(ref toDisplay);

            //Add each movie to the table.
            foreach (Movie movie in toDisplay)
            {
                DataRow row = table.NewRow();
                row[0] = movie.YearReleased;
                row[1] = movie.Title;
                row[2] = movie.Genre;
                row[3] = string.Format("{0:C}", movie.PurchasePrice);
                row[4] = movie.Rating.ToString();
                table.Rows.Add(row);
            }
            //Bind the table to DataGridView.
            dgvMovies.DataSource = table;

            //Make sure all columns expand to fit their data.
            foreach (DataGridViewColumn column in dgvMovies.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        /// <summary>
        /// Creates the DataTabel for binding to the GridView
        /// </summary>
        /// <returns></returns>
        private DataTable createDataTable()
        {
            DataTable table = new DataTable("Movies");
            table.Columns.Add("Year Of Release");
            table.Columns.Add("Title");
            table.Columns.Add("Genre");
            table.Columns.Add("Purchase Price");
            table.Columns.Add("Rating");
            return table;
        }

        /// <summary>
        /// Gets the movies that are currently displayed in the GridView
        /// </summary>
        /// <returns></returns>
        private List<Movie> getCurrentDisplaying()
        {
            List<Movie> toReturn = new List<Movie>();
            //Get displaying movies as a Data Table
            DataTable tabel = (DataTable)dgvMovies.DataSource;
            //Parse the Data Table back into a list of Movie types.
            foreach (DataRow row in tabel.Rows)
            {
                Movie movie = new Movie();
                movie.YearReleased = int.Parse(row[0].ToString());
                movie.Title = row[1].ToString();
                movie.Genre = row[2].ToString();
                movie.PurchasePrice = decimal.Parse(row[3].ToString().Replace("$", ""));
                movie.Rating = stringToRating[row[4].ToString().ToLower().Trim()];
                toReturn.Add(movie);
            }
            return toReturn;
        }

        /// <summary>
        /// Sorts the movies by what the user has entered.
        /// toSort is referenced so I don't have to worry about returning anything. Saves some memory.
        /// </summary>
        /// <param name="toSort"></param>
        private void sortMovies(ref List<Movie> toSort)
        {
            //Are we sorting by year?
            if (ckbYearSort.Checked)
            {
                //Ascending = 0; Descending = 1
                if (cmbYearSort.SelectedIndex == 0)
                {
                    //Use LINQ to sort.
                    //Ascending
                    var sortedYearASC =
                        from movie in toSort
                        orderby movie.YearReleased
                        select movie;
                    toSort = sortedYearASC.ToList<Movie>();
                }
                else
                {
                    //Descending
                    var sortedYearDesc =
                        from movie in toSort
                        orderby movie.YearReleased descending
                        select movie;
                    toSort = sortedYearDesc.ToList();
                }

                //Are we sorting by Rating?
                if (ckbRatingSort.Checked)
                {
                    //Ascending = 0; Descending = 1;
                    if (cmbRatingSort.SelectedIndex == 0)
                    {
                        //Ascending
                        var sortedRatingASC =
                            from movie in toSort
                            orderby movie.Rating
                            select movie;
                        toSort = sortedRatingASC.ToList<Movie>();
                    }
                    else
                    {
                        //Desccending
                        var sortedRatingDesc =
                            from movie in toSort
                            orderby movie.Rating descending
                            select movie;
                        toSort = sortedRatingDesc.ToList<Movie>();
                    }
                }
            }
        }

        /// <summary>
        /// Logs an exception to the event log.
        /// </summary>
        /// <param name="ex"></param>
        private void logException(Exception ex)
        {
            //If the source doesn't exist in the event log, create it.
            if (!EventLog.SourceExists(Source))
                EventLog.CreateEventSource(Source, "Application");

            //build the string message.
            StringBuilder sb = new StringBuilder("An error occcured!\n");
            sb.Append("Message: " + ex.Message + "\n");
            sb.Append("Source: " + ex.Source + "\n");
            sb.Append("Stack Trace: " + ex.StackTrace + "\n\n");

            //Get the inner exception too if their is one. We don't want to lose any data.
            if (ex.InnerException != null)
            {
                sb.Append("Inner Message: " + ex.InnerException.Message + "\n");
                sb.Append("Inner Source: " + ex.InnerException.Source + "\n");
                sb.Append("Inner Stack Trace: " + ex.InnerException.StackTrace + "\n\n");
            }

            //Write entry to the event log.
            EventLog.WriteEntry(Source, sb.ToString(), EventLogEntryType.Error, 1001);
        }

        /// <summary>
        /// Displays an error message to the user.
        /// </summary>
        /// <param name="message"></param>
        private void showError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion
    }
}
