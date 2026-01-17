using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        FilmLibrary filmLibrary_obj = new FilmLibrary();

        Film film1 = new Film { Title = "Alita Battle Angel", Director = "Robert Rodriguez", Year = 2019 };
        Film film2 = new Film { Title = "Interstellar", Director = "Christopher Nolan", Year = 2014 };

        filmLibrary_obj.AddFilm(film1);
        filmLibrary_obj.AddFilm(film2);

        Console.WriteLine($"Total number of films present in the list: {filmLibrary_obj.GetTotalFilms()}");

        Console.WriteLine("All films present in the list:");
         filmLibrary_obj.GetAllFilms();
       

        Console.WriteLine("Please enter the name to search the film:");
        string filmName = Console.ReadLine();

        // filmLibrary_obj.RemoveFilm();

        filmLibrary_obj.SearchFilms(filmName);
        Console.WriteLine();
    }
}
