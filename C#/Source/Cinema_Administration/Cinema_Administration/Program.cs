using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Administration
{
    class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema();
            string userCommand = "";
            while (userCommand != "exit")
            {
                Console.Write("Cinema Administration: ");
                userCommand = Console.ReadLine().ToLower();
                switch (userCommand)
                {
                    case "add":
                        Console.Write("Movie Name: ");
                        string movieName = Console.ReadLine();
                        Console.Write("Minutes: ");
                        int minutes;
                        try
                        {
                            minutes = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            minutes = 0;
                        }
                        Console.Write("Audience Rating: ");
                        string audienceRating = Console.ReadLine();
                        Movie movie = new Movie();
                        movie.setNameAndMinutes(movieName, minutes, cinema.getMovies());
                        movie.setAudienceRating(audienceRating);
                        cinema.add(movie);
                        break;
                    case "remove":
                        Console.Write("Movie Name: ");
                        movieName = Console.ReadLine();
                        cinema.remove(movieName);
                        break;
                    case "show":
                        Console.Write("Movie Name: ");
                        movieName = Console.ReadLine();
                        movie = cinema.findMovieItem(movieName);
                        if (movie != null)
                        {
                            Console.WriteLine(movie.show());
                        }
                        else
                        {
                            Console.WriteLine(movieName + " Not found");
                        }
                        break;
                    case "list":
                        string movieNames = "";
                        string[] movies = cinema.getMovieNames();
                        for (int i = 0; i < movies.Length; i++)
                        {
                            if (movies[i] != null)
                            {
                                movieNames += movies[i] + "\n";
                            }
                        }
                        string newText = "";
                        for (int i = 0; i < movieNames.Length - 1; i++)
                        {
                            newText += movieNames[i];
                        }
                        movieNames = newText;
                        Console.WriteLine(movieNames);
                        break;
                    case "minutes":
                        Console.WriteLine(cinema.getTotalMinutes());
                        break;
                    case "update minutes":
                        Console.Write("Movie Name: ");
                        movieName = Console.ReadLine();
                        Console.Write("Minutes: ");
                        try
                        {
                            minutes = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            minutes = 0;
                        }
                        cinema.findMovieItem(movieName).setMinutes(minutes);
                        break;
                    case "update rating":
                        Console.Write("Movie Name: ");
                        movieName = Console.ReadLine();
                        Console.Write("Audience Rating: ");
                        audienceRating = Console.ReadLine();
                        cinema.findMovieItem(movieName).setAudienceRating(audienceRating);
                        break;
                    case "help":
                        Console.WriteLine("add - adds a new movie");
                        Console.WriteLine("remove - removes movie");
                        Console.WriteLine("show - shows the name, minutes and audience rating of a movie");
                        Console.WriteLine("list - lists all movies");
                        Console.WriteLine("minutes - shows total minutes");
                        Console.WriteLine("update minutes - updates the minutes of a movie");
                        Console.WriteLine("updates rating - updates the audience rating of a movie");
                        Console.WriteLine("help - shows this help");
                        Console.WriteLine("exit - exits the program");
                        break;
                    default:
                        Console.WriteLine("Command not recorgnized. Type 'help' for a list of commands.");
                        break; 
                }
            }
        }
    }


    class Movie
    {
        private string name = "movie name";
        private int minutes = -1;
        private string audienceRating = "not set";

        public void setMinutes(int minutes)
        {
            if (minutes > 0)
            {
                this.minutes = minutes;
            }
        }

        public void setAudienceRating(string audienceRating)
        {
            if (this.audienceRating == "not set")
            {
                this.audienceRating = audienceRating.ToUpper();
            }
        }

        public void setNameAndMinutes(string movieName, int minutes, Movie[] movies)
        {
            bool nameExists = false;
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i] != null)
                {
                    if (movies[i].name == movieName)
                    {
                        nameExists = true;
                    }
                } 
            }
            if (!nameExists)
            {
                name = movieName;
                setMinutes(minutes);
            }
        }

        public string show()
        {
            return "Name: " + name + ", Minutes: " + minutes + ", Audience Rating: " + audienceRating;
        }

        public string getName()
        {
            return name;
        }

        public int getMinutes()
        {
            return minutes;
        }

        public string getRating()
        {
            return audienceRating;
        }

    }


    class Cinema
    {
        private Movie[] movies = new Movie[1000];

        public void add(Movie movie)
        {
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i] == null)
                {
                    movies[i] = movie;
                    return;
                }
            }
        }

        public string[] getMovieNames()
        {
            string[] movieNames = new string[1000];
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i] != null)
                {
                    movieNames[i] = movies[i].getName();
                }
            }
            return movieNames;
        }

        public void remove(string movieName)
        {
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i] != null)
                {
                    if (movies[i].getName() == movieName)
                    {
                        movies[i] = null;
                    }
                }
            }
        }

        public Movie findMovieItem(string movieName)
        {
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i] != null)
                {
                    if (movies[i].getName() == movieName)
                    {
                        return movies[i];
                    }
                }
            }
            return null;
        }

        public string[] findRatedMovieNames(string audienceRating)
        {

            string[] movieNames = new string[1000];
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i] != null)
                {
                    if (movies[i].getRating() == audienceRating.ToUpper())
                    {
                        movieNames[i] = movies[i].getName();
                    }
                }
            }
            return movieNames;
        }

        public int getTotalMinutes()
        {
            int totalMinutes = 0;
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i] != null)
                {
                    totalMinutes += movies[i].getMinutes();
                }
            }
            return totalMinutes;
        }

        public Movie[] getMovies()
        {
            return movies;
        }
    }
}
