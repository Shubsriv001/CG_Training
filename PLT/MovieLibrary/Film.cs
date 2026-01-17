using System;
using System.Collections.Generic;

class Film
{
    public  string? Title{get;set;}
   public string? Director{get;set;}
   public int Year{get;set;}
}

class FilmLibrary
{
    private List<Film> _films = new List<Film>();


    public void AddFilm(Film film)
    {
        _films.Add(film);
    }

    public void GetAllFilms()
    {
        
        foreach(var filmss in _films)
        {
            Console.WriteLine(filmss.Title);
        }
    }

    // public void RemoveFilm()
    // {
    //     Console.WriteLine("Enter the Movie Name to be removed:");
    //     string movieName = Console.ReadLine();

    //         foreach (var item in _films)
    //         {
                
    //     if (item.Title.Contains(movieName))
    //     {
    //         _films.Remove();
    //     }
    //         }
    // }

    

    public int GetTotalFilms()
    {
        return _films.Count;
    }

    public void SearchFilms(string Title)
    {

        foreach(var movie in _films)
        {
            if(movie.Title.Contains(Title, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Title: {movie.Title}, Director: {movie.Director}, Year: {movie.Year}");
            }
        }
       
    }
}