using SEDC.MovieApp.Domain;
using SEDC.MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieApp.Mappers
{
    public static class MovieMapper
    {
        public static Movie ToMovie(this MovieModel movieModel)
        {
            return new Movie
            {
               Id=movieModel.Id,
               Title=movieModel.Title,
               Description=movieModel.Description,
               Year=movieModel.Year,
               Genre=movieModel.Genre
            };
        }
        public static MovieModel ToMovieModel(this Movie movie)
        {
            return new MovieModel
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                Year = movie.Year,
                Genre = movie.Genre
                
                
            };
        }
    }
}
