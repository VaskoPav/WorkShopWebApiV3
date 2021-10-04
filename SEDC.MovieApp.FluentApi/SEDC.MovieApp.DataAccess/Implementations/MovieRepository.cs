using Microsoft.EntityFrameworkCore;
using SEDC.MovieApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.MovieApp.DataAccess.Implementations
{
    public class MovieRepository : IRepository<Movie>
    {
        private MovieAppDbContext _movieAppDbContext;

        public MovieRepository(MovieAppDbContext movieAppDbContext)
        {
            _movieAppDbContext = movieAppDbContext;
        }

        public void Add(Movie entity)
        {
            _movieAppDbContext.Add(entity);
            _movieAppDbContext.SaveChanges();
        }

        public void Delete(Movie entity)
        {
            _movieAppDbContext.Remove(entity);
            _movieAppDbContext.SaveChanges();
        }

        public List<Movie> GetAll()
        {
            return _movieAppDbContext
                  .Movies
                  .Include(x => x.User)
                  .ToList();
        }

        public Movie GetById(int id)
        {
            return _movieAppDbContext
                .Movies
                .Include(x => x.User)
                .FirstOrDefault(x => x.Id == id);
                
        }

        public void Update(Movie entity)
        {
            _movieAppDbContext.Movies.Update(entity);
            _movieAppDbContext.SaveChanges();
        }
    }
}
