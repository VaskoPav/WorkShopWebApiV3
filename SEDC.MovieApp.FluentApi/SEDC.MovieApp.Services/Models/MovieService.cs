using SEDC.MovieApp.DataAccess;
using SEDC.MovieApp.Domain;
using SEDC.MovieApp.Mappers;
using SEDC.MovieApp.Models;
using SEDC.MovieApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieApp.Services.Models
{
    public class MovieService : IMovieService
    {
        private IRepository<Movie> _movieRepository;
        public MovieService(IRepository<Movie> movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public void AddMovie(MovieModel movieModel)
        {
           
            Movie movieModels = movieModel.ToMovie();

            _movieRepository.Add(movieModels);
        }

        public void DeleteMovie(int id)
        {
            Movie movieDb = _movieRepository.GetById(id);
            if (movieDb == null)
            {
                throw new Exception($"Note with id {id} was not found");
            }
           _movieRepository.Delete(movieDb);
        }

        public List<MovieModel> GetAllMovie()
        {
            List<Movie> moviesDb = _movieRepository.GetAll();
            List<MovieModel> movieModels = new List<MovieModel>();
            foreach (Movie movies in moviesDb)
            {
                movieModels.Add(movies.ToMovieModel());
            }
            return movieModels;
        }

        public MovieModel GetMovieById(int id)
        {
            Movie movieDb = _movieRepository.GetById(id);
            if (movieDb == null)
            {
                throw new Exception($"Note with id {id} was not found");
            }

            return movieDb.ToMovieModel();
        }

        public void UpdateMovie(MovieModel movieModel)
        {
            Movie movieDb = _movieRepository.GetById(movieModel.Id);

            if (movieDb == null)
            {
                throw new Exception($"Note with id {movieModel.Id} was not found!");
            }

            if (string.IsNullOrEmpty(movieModel.Title))
            {
                throw new Exception("The property Title for note is required");
            }
            if (string.IsNullOrEmpty(movieModel.Description))
            {
                throw new Exception("The property Description for note is required");
            }
            if (string.IsNullOrEmpty(movieModel.Genre))
            {
                throw new Exception("The property Genre for note is required");
            }

            movieDb.Title = movieModel.Title;
            movieDb.Description = movieModel.Description;
            movieDb.Genre = movieModel.Genre;
            _movieRepository.Update(movieDb);

        }
    }
}
