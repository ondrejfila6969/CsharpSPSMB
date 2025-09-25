// See https://aka.ms/new-console-template for more information

using System.Globalization;
using Files;

List <Movie> movies = new List<Movie>();
try
{
  var lines = File.ReadLines("movies.csv");
  bool isHeader = true;
  foreach (string line in lines)
  {
    if (isHeader)
    {
      isHeader = false; 
      continue;
    }
    movies.Add(ParseMovie(line));
  }
  
  var movieYears = movies.Select(movie => movie._year).Distinct().OrderBy(year => year);

  foreach (var year in movieYears)
  {
    var moviesInYear = movies.Where(movie => movie._year == year).ToList();
    if (moviesInYear.Count == 0) return;
    
    var bestRatingMovie = moviesInYear.MaxBy(movie => movie._rottenTomatoes);
    var worstRatingMovie = moviesInYear.MinBy(movie => movie._rottenTomatoes);
    
    var mostProfitable = moviesInYear.MaxBy(movie => movie._profitability);
    var leastProfitable = moviesInYear.MinBy(movie => movie._profitability);
    
    double avgGross = moviesInYear.Average(movie =>
    {
      string s = movie._worldwideGross.Replace("$", "").Replace(",", "").Trim();
      return double.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out double val) ? val : 0;
    });

    Console.WriteLine($"Rok: {year}");
    Console.WriteLine($"  Nejlépe hodnocený film: {bestRatingMovie._name} ({bestRatingMovie._rottenTomatoes}%)");
    Console.WriteLine($"  Nejhůře hodnocený film: {worstRatingMovie._name} ({worstRatingMovie._rottenTomatoes}%)");
    Console.WriteLine($"  Nejvíce výdělečný film: {mostProfitable._name} ({mostProfitable._profitability})");
    Console.WriteLine($"  Nejméně výdělečný film: {leastProfitable._name} ({leastProfitable._profitability})");
    Console.WriteLine($"  Průměr WorldwideGross: {avgGross:F3}");
    Console.WriteLine();
  }
  
  var sortedYears = movies.Select(m => m._year).OrderBy(y => y).ToList();
  int count = sortedYears.Count;
  double medianYear = (count % 2 == 1) ? sortedYears[count / 2] : (sortedYears[count / 2 - 1] + sortedYears[count / 2]) / 2.0;
  Console.WriteLine($"Medián roků je: {medianYear}");
  
} catch (FileNotFoundException ex)
{
  throw new FileNotFoundException("File not found", ex);
}
Movie ParseMovie(string line)
{
  var words = line.Split(',');
  return new Movie(words[0],
    words[1], 
    words[2], 
    Int32.Parse(words[3]), 
    Double.Parse(words[4], CultureInfo.InvariantCulture), 
    Int32.Parse(words[5]), 
    words[6], 
    Int32.Parse(words[7]));
}


