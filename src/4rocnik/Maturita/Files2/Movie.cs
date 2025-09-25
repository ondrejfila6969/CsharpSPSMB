namespace Files
{
    public class Movie
    {
        public string _name;
        public string _genre;
        public string _studio;
        public double _score;
        public double _profitability;
        public int _rottenTomatoes;
        public string _worldwideGross;
        public int _year;

        public Movie(string name, string genre, string studio, double score, double profitability, int rottenTomatoes, string worldwidegross, int year)
        {
            _name = name;
            _genre = genre;
            _studio = studio;
            _score = score;
            _profitability = profitability;
            _rottenTomatoes = rottenTomatoes;
            _worldwideGross = worldwidegross;
            _year = year;
        }
        
    }
}