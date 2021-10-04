using SEDC.MovieApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieApp.DataAccess.Intefaces
{
    public interface IUserRepository:IRepository<User>
    {
        User GetUserByUsername(string username);
        User LoginUser(string username, string password);
    }
}
