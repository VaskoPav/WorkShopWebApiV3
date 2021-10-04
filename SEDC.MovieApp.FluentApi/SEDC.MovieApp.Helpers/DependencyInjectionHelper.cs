using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SEDC.MovieApp.DataAccess;
using SEDC.MovieApp.DataAccess.Implementations;
using SEDC.MovieApp.DataAccess.Intefaces;
using SEDC.MovieApp.Domain;
using SEDC.MovieApp.Services.Interfaces;
using SEDC.MovieApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieApp.Helpers
{
    public static class DependencyInjectionHelper
    {
        public static void InjectDbContext(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<MovieAppDbContext>(x =>
                x.UseSqlServer(connectionString));
        }

        public static void InjectRepository(IServiceCollection services)
        {
            services.AddTransient<IRepository<Movie>, MovieRepository>();
            services.AddTransient<IUserRepository, UserRepository>(); 

        }
        public static void InjectServices(IServiceCollection services)
        {
            services.AddTransient<IMovieService, MovieService>();
            services.AddTransient<IUserService, UserService>();
        }
    }
}
