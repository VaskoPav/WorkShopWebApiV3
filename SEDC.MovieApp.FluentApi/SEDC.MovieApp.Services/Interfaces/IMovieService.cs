using SEDC.MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieApp.Services.Interfaces
{
    public interface IMovieService
    {
        List<MovieModel> GetAllMovie();
        MovieModel GetMovieById(int id);
        void AddMovie(MovieModel movieModel);
        void UpdateMovie(MovieModel movieModel);
        void DeleteMovie(int id);
    }
}
