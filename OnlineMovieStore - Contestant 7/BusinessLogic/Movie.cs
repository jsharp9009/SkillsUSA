namespace OnlineMovieStore___Contestant_7
{
    /// <summary>
    /// For holding data related to a movie.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Movie()
        {
        }

        /// <summary>
        /// Constructor to initial with all variables set.
        /// </summary>
        /// <param name="yearReleased"></param>
        /// <param name="title"></param>
        /// <param name="genre"></param>
        /// <param name="rating"></param>
        /// <param name="purchasePrice"></param>
        public Movie(int yearReleased, string title, string genre, Rating rating, decimal purchasePrice)
            : base() //Call the base constructor too, just in case their is some logic we need.
        {
            this.YearReleased = yearReleased;
            this.Title = title;
            this.Genre = genre;
            this.Rating = rating;
            this.PurchasePrice = purchasePrice;
        }

        private int yearReleased;
        /// <summary>
        /// Year the movie was released.
        /// </summary>
        public int YearReleased
        {
            get { return yearReleased; }
            set { yearReleased = value; }
        }

        private string title;
        /// <summary>
        /// Title of the movie
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string genre;
        /// <summary>
        /// Genre of the move (ie. Comedy, Horror, Action, etc.).
        /// </summary>
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        private Rating rating;
        /// <summary>
        /// The movies rating (R, PG13, PG, G).
        /// </summary>
        public Rating Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        private decimal purchasePrice;
        /// <summary>
        /// Price for the movie.
        /// </summary>
        public decimal PurchasePrice
        {
            get { return purchasePrice; }
            set { purchasePrice = value; }
        }
       
    }

    /// <summary>
    /// Enumeration for holding the available ratings.
    /// </summary>
    public enum Rating
    {
        G,
        PG,
        PG13,
        R
    }
}
